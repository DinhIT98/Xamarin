using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BT_4.Model;
using SQLite;
namespace BT_4.Helpers
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db"))) 
                {
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                }
            }
            
            catch(SQLiteException ex)
            {

            }
        }
        public List<LoaiHoa> GetLoaiHoas()
        {
            try
            {
                using ( var connection = new SQLiteConnection(System.IO.Path.Combine(folder,"qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
        public LoaiHoa GetLoaiHoaByID(int MaLoai)
        {
            try
            {
                using ( var connection =new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var Dsh = from lhs in connection.Table<LoaiHoa>().ToList()
                              where lhs.MaLoai == MaLoai
                              select lhs;
                    return Dsh.ToList<LoaiHoa>().FirstOrDefault();


                }
      

            }
            catch(SQLiteException ex)
            {
                return null;
            }

        }
        public bool InsertLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder,"qlhoa.db")))
                {
                    connection.Insert(lh);
                    return true;
                }
            }
            catch(SQLiteException ex)
            {
                return false;
            }

        }
        public bool UpdateLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder,"qlhoa.db")))
                {
                    connection.Update(lh);
                    return true;
                }
            }
            catch(SQLiteException ex)
            {
                return false;
            }
        }
        public bool DeleteLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(lh);
                    return true;
                }

            }
            catch(SQLiteException ex)
            {
                return false;
            }
        }
    }
}
