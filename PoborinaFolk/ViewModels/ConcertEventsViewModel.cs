using System;
using PoborinaFolk.Model;
using System.Collections.ObjectModel;

namespace PoborinaFolk.ViewModels
{
    public class ConcertEventsViewModel
    {
        public ConcertEventsViewModel()
        {
            fridayList = GetFridayList();
        }

        public ObservableCollection<Concerts> FridayList
        {
            get { return fridayList; }
            set
            {
                fridayList = value;
            }
        }

        ObservableCollection<Concerts> fridayList;
        private ObservableCollection<Concerts> GetFridayList()
        {
            return new ObservableCollection<Concerts>
            {
                new Concerts {ImageList="ViernesGrupo.png", NameBand="first Band Name", TimePlay="22h30", PlacePlay="Escenario Central"},
                new Concerts {ImageList="ViernesGrupo.png", NameBand="first Band Name", TimePlay="22h30", PlacePlay="Escenario Central"}
            };

        }
    }
}
