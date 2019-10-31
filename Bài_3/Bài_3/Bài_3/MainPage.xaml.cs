using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bài_3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ThemLoaiHoa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemLoaiHoa());
        }

        private void DanhSachLoaiHoa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSachLoaiHoa());
        }
    }
}
