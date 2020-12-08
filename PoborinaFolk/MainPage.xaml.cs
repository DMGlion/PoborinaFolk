using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PoborinaFolk
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Navigation Buttons
        private async void btnConcerts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConcertEventsMain());
        }

        private async void btnPlayList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayList());
        }

        private async void btnMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }

        private async void btnPhoto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhotoPage());
        }

        private async void btnGame_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage());
        }

        private async void btnInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        // Link Buttons
        private void btnFacebook_Clicked(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("https://www.facebook.com/poborinafolk");
            }
            catch
            {
                DisplayAlert("Unable to open Facebook", "check your internet connection", "OK");
            }
        }

        private void btnTwitter_Clicked(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("https://twitter.com/poborinafolk");
            }
            catch
            {
                DisplayAlert("Unable to open Twitter", "check your internet connection", "OK");
            }
        }

        private void btnInstagram_Clicked(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("https://www.instagram.com/poborinafolk/");
            }
            catch
            {
                DisplayAlert("Unable to open Instagram", "check your internet connection", "OK");
            }
        }

    }
}
