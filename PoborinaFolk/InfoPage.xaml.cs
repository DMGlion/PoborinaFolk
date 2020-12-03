using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PoborinaFolk
{
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void btnCallEmergency(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("112");
            }
            catch
            {
                DisplayAlert("Unable to make the call to 112" , "please enter number", "OK");
            }
        }

        private void btnCallAmbulance(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("061");
            }
            catch
            {
                DisplayAlert("Unable to make the call to 061", "please enter number", "OK");
            }
        }

        private void btnPolice(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("062");
            }
            catch
            {
                DisplayAlert("Unable to make the call to 062", "please enter number", "OK");
            }
        }

        private void btnFireman(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("080");
            }
            catch
            {
                DisplayAlert("Unable to make the call to 080", "please enter number", "OK");
            }
        }

    }
}
