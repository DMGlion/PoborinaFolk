using System;
using System.Collections.Generic;
using PoborinaFolk.Model;
using System.Collections.ObjectModel;

namespace PoborinaFolk.ViewModels
{
    public class InfoMainViewModel
    {
        public InfoMainViewModel()
        {
            infoList = GetInfo();
        }

        public ObservableCollection<Info> InfoList
        {
            get { return infoList; }
            set
            {
                infoList = value;
            }
        }

        ObservableCollection<Info> infoList;
        private ObservableCollection<Info> GetInfo()
        {
            return new ObservableCollection<Info>
            {
                new Info { Image = "emergency.png", Information = "Emergencias", PhoneNumber = "112", PhoneImage="call.png", CallPhone="True" },
                new Info { Image = "ambulance.png", Information = "Ambulancia", PhoneNumber = "061", PhoneImage="call.png", CallPhone="True" },
                new Info { Image = "police.png", Information = "Guardia Civil", PhoneNumber = "062", PhoneImage="call.png", CallPhone="True"},
                new Info { Image = "fireman.png", Information = "Bomberos", PhoneNumber = "080", PhoneImage="call.png", CallPhone="True" },
                new Info { Image = "clinic.png", Information = "Centro de salud cercano,", InformationAdd="Calle Alcalá, Cedrillas", CallPhone="False"},
                new Info { Image = "pharmacy.png", Information = "Farmacia mas cercana,", InformationAdd="Calle Mayor, Cedrillas", CallPhone="False"},
                new Info { Image = "visa.gif", Information = "Cajero mas cecano,", InformationAdd="Calle Mayor, Cedrillas", CallPhone="False"},
                new Info { Image = "informa.png", Information = "información del Festival", InformationAdd="Caseta del Escenario Principal", CallPhone="False"}
            };
        }
    }
}
