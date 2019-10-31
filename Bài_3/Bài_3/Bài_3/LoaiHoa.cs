using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Bài_3
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int Maloai { get; set; }
        public string Tenloai { get; set; }

    }
}
