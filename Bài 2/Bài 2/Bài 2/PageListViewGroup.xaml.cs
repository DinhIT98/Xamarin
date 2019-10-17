using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bài_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewGroup : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PageListViewGroup()
        {
            InitializeComponent();
            Loai_Hoa l = new Loai_Hoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }
    }
}
