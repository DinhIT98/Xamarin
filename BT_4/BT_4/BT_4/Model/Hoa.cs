using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BT_4.Model
{
   public class Hoa
    {
        [PrimaryKey,AutoIncrement]
        public int MaHoa { get; set; }
        public int MaLoai { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string Mota { get; set; }
        public string Gia { get; set; }

    }
}
