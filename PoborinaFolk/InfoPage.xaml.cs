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

        private void Avaliar(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).CommandParameter);

            try
            {
                PhoneDialer.Open((String)(((Button)sender).CommandParameter));
            }
            catch
            {
                DisplayAlert("Unable to make the call", "No Sim", "OK");
            }
        }
    }
}
