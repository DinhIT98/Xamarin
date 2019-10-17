using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_2
{
    class Loai_Hoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private Loai_Hoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<Loai_Hoa> Loaihoas { get; set; }
        public Loai_Hoa()
        {
            List<Loai_Hoa> l = new List<Loai_Hoa>
            {
                new Loai_Hoa("Hoa cúc")
                {
                    new hoa { TenHoa = "Đón Xuân", Gia = 5000, Hinh = "hinh_1.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" },
                    new hoa { TenHoa = "Hồn nhiên", Gia = 6000, Hinh = "hinh_2.jpg", Mota = "Hoa cúc vàng cam lá mỏng" },
                    new hoa { TenHoa = "Tím thủy chung", Gia = 4500, Hinh = "hinh_3.jpg", Mota = "Hoa cúc tím " }
                }


            };
            Loaihoas = l;
        }

    }

}
