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
    public partial class PageListViewHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public PageListViewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón Xuân", Gia = 5000, Hinh = "hinh_1.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 6000, Hinh = "hinh_2.jpg", Mota = "Hoa cúc vàng cam lá mỏng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 4500, Hinh = "hinh_3.jpg", Mota = "Hoa cúc tím " });
            lsvHoa.ItemsSource = Hoas;

        }

    }
}
