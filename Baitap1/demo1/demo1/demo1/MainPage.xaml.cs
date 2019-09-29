using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace demo1
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_TinhTong());
        }

        private void Button_Clicked_2(object sender, EventArgs e) => Navigation.PushAsync(new MH_Chao());

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void cmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdgirdLayout_Cliclked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculator());
        }

        private void cmdlogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_Login());
        }

        private void cmdFlexLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdScrollView_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdEntry_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdListView1_Clicked(object sender, EventArgs e)
        {

        }
    }
}
