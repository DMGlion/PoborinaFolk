using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoborinaFolk.ViewModels
{
    public class MapPageViewModel
    {
        public MapPageViewModel()
        {
        }

        public class SiteLocations
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public string Label { get; set; }
            public string Icon { get; set; }

        }

        internal async Task<List<SiteLocations>> LoadSites()
        {

                    // We are using hardcoded data
                    List<SiteLocations> siteLocations = new List<SiteLocations>
                    {
                        new SiteLocations {Latitude="40.510006", Longitude="-0.857919",
                             Label="Camping One", Icon="camping.png"},
                        new SiteLocations {Latitude="40.512006", Longitude="-0.858919",
                             Label="Camping two", Icon="camping.png"},
                    };
                    return siteLocations;
         }
    }

}
