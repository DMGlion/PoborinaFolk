using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoborinaFolk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConcertEventsMain : TabbedPage
    {
        public ConcertEventsMain()
        {
            this.Children.Add(new ConcertEventsPage1());
            this.Children.Add(new ConcertEventsPage2());
            this.Children.Add(new ConcertEventsPage3());
        }
    }
}
