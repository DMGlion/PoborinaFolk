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
                new Concerts {ImageList="ViernesGrupo.png", NameBand="first Band Name", TimePlay="00h30", PlacePlay="Escenario Central"},
                new Concerts {ImageList="grupo1.png", NameBand="second Band Name", TimePlay="22h30", PlacePlay="Camping"},
                new Concerts {ImageList="grupo2.png", NameBand="third Band Name", TimePlay="20h30", PlacePlay="Escenario Latera"},
                new Concerts {ImageList="grupo3.png", NameBand="fourth Band Name", TimePlay="18h30", PlacePlay="Escenario Latera"}
            };

        }
    }
}
