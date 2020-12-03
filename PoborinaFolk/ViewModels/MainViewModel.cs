using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using PoborinaFolk.Model;
using Xamarin.Forms;

namespace PoborinaFolk.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            musicList = GetMusics();
            recentMusic = musicList.Where(x => x.IsRecent == true).FirstOrDefault();
        }

        ObservableCollection<Music> musicList;
        public ObservableCollection<Music> MusicList
        {
            get { return musicList; }
            set
            {
                musicList = value;
                OnPropertyChanged();
            }
        }

        private Music recentMusic;
        public Music RecentMusic
        {
            get { return recentMusic; }
            set
            {
                recentMusic = value;
                OnPropertyChanged();
            }
        }

        private Music selectedMusic;
        public Music SelectedMusic
        {
            get { return selectedMusic; }
            set
            {
                selectedMusic = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(PlayMusic);

        private void PlayMusic()
        {
            if (selectedMusic != null)
            {
                var viewModel = new PlayerViewModel(selectedMusic, musicList);
                var playerPage = new PlayerPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(playerPage, true);
            }
        }

        private ObservableCollection<Music> GetMusics()
        {
            return new ObservableCollection<Music>
            {
                new Music { Title = "Cancion", Artist = "Nombre Grupo",
                    Url = "https://freesound.org/data/previews/425/425556_4929134-lq.mp3",
                    CoverImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTusundbRTmm2yqrnQ2JFagM1HyzafDL0I07w&usqp=CAU",
                    IsRecent = true},
            };
        }
    }
}
