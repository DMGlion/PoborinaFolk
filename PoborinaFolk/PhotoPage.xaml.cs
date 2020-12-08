using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace PoborinaFolk
{
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick a photo"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }

        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("Camera", "No camera available.", "OK");
                    return;
                }
                var mediaFile = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "test.jpg",
                });
                if (mediaFile == null)
                    return;
                resultImage.Source = ImageSource.FromStream(() =>
                {
                    return mediaFile.GetStreamWithImageRotatedForExternalStorage();
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception:>" + ex);
            }
            }
        }

}
