using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Bài_3
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CreateDatabase()
        {
            try
            {
                using (var connnection = new SQLiteConnection(System.IO.Path.Combine(folder," qlhoa.db")))
                {
                    connnection.CreateTable<LoaiHoa>();
                    connnection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch(SQLiteException ex)
            {
                return false;
            }
        }
        public bool InsertLoaiHoa (LoaiHoa loai)
        {
            try
            {
                using (var connection= new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        public List<LoaiHoa> selectLoaiHoa()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();

                } 

               
            }
            catch(SQLiteException ex)
            {
                return null;
            }
        }
        public bool insertHoa(Hoa hoa)
        {
            try
            {
                using (var connection=new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(hoa);
                }
                return true; 

            }
            catch(SQLiteException ex)
            {
                return false;
            }
        }
        public List<Hoa> selectHoa()
        {
            try
            {
                using(var connection =new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch(SQLiteException ex)
            {
                return null;
            }
        }
    }
}
