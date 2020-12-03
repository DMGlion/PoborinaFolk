using System;
using System.Diagnostics;
using System.Reflection;
using PoborinaFolk.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace PoborinaFolk
{
    public partial class MapPage : ContentPage
    {
        private ImageButton findBtn;
        private ImageButton getBtn;
        MapPageViewModel mapPageViewModel;
        private Position position;

        public MapPage()
        {
            InitializeComponent();
            BindingContext = mapPageViewModel = new MapPageViewModel();
            ApplyMapTheme();
            InitialyzeSites();
            findBtn = this.FindByName<ImageButton>("find_btn");
            getBtn = this.FindByName<ImageButton>("get_btn");
        }

        async void InitialyzeSites()
        {

            //Initialise first value
            Pin pinPobo = new Pin()
            {
                Type = PinType.Place,
                Label = "El Pobo",
                Address = "El Pobo, Teruel, Spain",
                Position = new Position(40.507391d, -0.860525d),
                Rotation = 33.3f,
                Tag = "id_tokyo",

            };
            map.Pins.Add(pinPobo);

            var contents = await mapPageViewModel.LoadSites();

            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin SitePins = new Pin()
                    {
                        Label = "",
                        Address = item.Label,
                        Type = PinType.Place,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("CarPins.png") : BitmapDescriptorFactory.FromView(new Image() { Source = item.Icon, WidthRequest = 30, HeightRequest = 30 }),
                        Position = new Position(Convert.ToDouble(item.Latitude), Convert.ToDouble(item.Longitude)),

                    };
                    map.Pins.Add(SitePins);
                }
            }

            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinPobo.Position, Distance.FromMeters(280)));
        }

        private void ApplyMapTheme()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"PoborinaFolk.MapResources.MapTheme.json");
            string themeFile;
            using (var reader = new System.IO.StreamReader(stream))
            {

                themeFile = reader.ReadToEnd();
                map.MapStyle = MapStyle.FromJson(themeFile);
            }
        }

        private async void startFind(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                findBtn.IsVisible = false;
                getBtn.IsVisible = true;
            });

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest()
                    {
                        DesiredAccuracy = GeolocationAccuracy.Low,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                if (location == null)
                    Debug.WriteLine("No GPS");
                else
                {
                    position = new Position(location.Latitude, location.Longitude);
                }

                map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMeters(280)));

                Pin mylocation = new Pin()
                {
                    Type = PinType.Place,
                    Label = "",
                    Address = "Vamos de camino al Poborina, Teruel, Spain",
                    Position = position,
                    Rotation = 33.3f,
                };
                map.Pins.Add(mylocation);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Something is wrong: {ex.Message}");
            }
        }

        private async void startGet(object sender, EventArgs args)
        {
            double latitud = 40.50812087254159;
            double longitud = -0.8615228416635071;
            string placeName = "El Pobo";

            var supportsUri = await Launcher.CanOpenAsync("comgooglemaps://");

            if (supportsUri)
                await Launcher.OpenAsync($"comgooglemaps://?q={latitud},{longitud}({placeName})");

            else
                await Xamarin.Essentials.Map.OpenAsync(latitud, longitud, new MapLaunchOptions { Name = placeName });
        }
    }
}
