using System;
using PoborinaFolk.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace PoborinaFolk.ViewModels
{
    public class ConcertEventsViewModel: BaseViewModel
    {
        public ConcertEventsViewModel()
        {
            fridayList = GetFridayList();
            saturdayList = GetSaturdayList();
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


        public ICommand SelectionCommandFriday => new Command(ShowInfoBandFriday);

        private void ShowInfoBandFriday()
        {
            if (selectedConcert != null)
            {
                var viewModel = new InfoBandPageViewModel(selectedConcert, fridayList);
                var infoBandPage = new InfoBandPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(infoBandPage, true);
            }
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
                //Todo replace with a webview
                new Concerts {ImageList="ViernesGrupo.png", NameBand="first Band Name", TimePlay="00h30", PlacePlay="Escenario Central", InfoBand="" +
                "Description of band\n " +
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n\n  It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},

                new Concerts {ImageList="grupo1.png", NameBand="second Band Name", TimePlay="22h30", PlacePlay="Camping", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},
                new Concerts {ImageList="grupo2.png", NameBand="third Band Name", TimePlay="20h30", PlacePlay="Escenario Latera", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},
                new Concerts {ImageList="grupo3.png", NameBand="fourth Band Name", TimePlay="18h30", PlacePlay="Escenario Latera", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."}
            };

        }







        public ICommand SelectionCommandSaturday => new Command(ShowInfoBandSaturday);

        private void ShowInfoBandSaturday()
        {
            if (selectedConcert != null)
            {
                var viewModel = new InfoBandPageViewModel(selectedConcert, saturdayList);
                var infoBandPage = new InfoBandPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(infoBandPage, true);
            }
        }



        public ObservableCollection<Concerts> SaturdayList
        {
            get { return saturdayList; }
            set
            {
                saturdayList = value;
            }
        }

        ObservableCollection<Concerts> saturdayList;
        private ObservableCollection<Concerts> GetSaturdayList()
        {
            return new ObservableCollection<Concerts>
            {
                //Todo replace with a webview
                new Concerts {ImageList="sabadogroupo.png", NameBand="first Band Name", TimePlay="00h30", PlacePlay="Escenario Central", InfoBand="" +
                "Description of band\n " +
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n\n  It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},

                new Concerts {ImageList="sabadogroupo1.png", NameBand="second Band Name", TimePlay="22h30", PlacePlay="Camping", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},
                new Concerts {ImageList="sabadogroupo2.png", NameBand="third Band Name", TimePlay="20h30", PlacePlay="Escenario Latera", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."},
                new Concerts {ImageList="sabadogroupo3.png", NameBand="fourth Band Name", TimePlay="18h30", PlacePlay="Escenario Latera", InfoBand="" +
                " Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a " +
                "type specimen book.\n It has survived not only five centuries, but also the " +
                "leap into electronic typesetting, remaining essentially unchanged. It was popularised " +
                "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more&#x0a; " +
                "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. " +
                "Why do we use it? It is a long established fact that a reader will be distracted by the readable " +
                "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - " +
                "less normal distribution of letters, as opposed to using 'Content here, content here', making " +
                "it look like readable English. Many desktop publishing packages and web page editors now use " +
                "Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web " +
                "sites still in their infancy.Various versions have evolved over the years, sometimes by accident, " +
                "sometimes on purpose(injected humour and the like)."}
            };

        }
    }
}
