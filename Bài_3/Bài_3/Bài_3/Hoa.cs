using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Bài_3
{
    public class Hoa
    {
        [PrimaryKey,AutoIncrement]
        public int Mahoa { get; set; }
        public int Maloai { get; set; }
        public string Tenhoa { get; set; }
        public string Hinh { get; set; }
        public string Mota { get; set; }
        public string Gia { get; set; }

    }
}
