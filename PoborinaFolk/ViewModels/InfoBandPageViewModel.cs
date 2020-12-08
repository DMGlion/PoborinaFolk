using System.Collections.ObjectModel;
using PoborinaFolk.Model;

namespace PoborinaFolk.ViewModels
{
    public class InfoBandPageViewModel: BaseViewModel
    {
        public InfoBandPageViewModel(Concerts selectedConcert, ObservableCollection<Concerts> concertList)
        {
            this.selectedConcert = selectedConcert;
            this.concertList = concertList;
        }


        #region Properties
        ObservableCollection<Concerts> concertList;
        public ObservableCollection<Concerts> ConcertList
        {
            get { return concertList; }
            set
            {
                concertList = value;
                OnPropertyChanged();
            }
        }


        private Concerts selectedConcert;
        public Concerts SelectedConcert
        {
            get { return selectedConcert; }
            set
            {
                selectedConcert = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }


}
