using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    class SqliteDataAccess
    {
        public static SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
        public static SQLiteCommand cmd = new SQLiteCommand();

        public static DataTable LoadPeople()
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT ID, FirstName, LastName, Honey, Quantity, Year from Customer";

            cnn.Open();
            using (SQLiteDataReader read = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(read);
                read.Close();
                cnn.Close();
                return dt;
            }


        }
        public static DataTable LoadAcacia()
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT ID, FirstName, LastName, Honey, Quantity, Year FROM Customer WHERE Honey = 'Acacia' ";
            cnn.Open();
            using (SQLiteDataReader read = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(read);
                read.Close();
                cnn.Close();
                return dt;
            }
        }
        public static DataTable LoadLime()
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT ID, FirstName, LastName, Honey, Quantity, Year FROM customer WHERE Honey = 'Lime'";
            cnn.Open();
            using (SQLiteDataReader read = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(read);
                read.Close();
                cnn.Close();
                return dt;
            }
        }
        public static DataTable LoadSunflower()
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT ID, FirstName, LastName, Honey, Quantity, Year FROM customer WHERE Honey = 'Sunflower'";
            cnn.Open();
            using(SQLiteDataReader read = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(read);
                read.Close();
                cnn.Close();
                return dt;
            }
        }
        public static DataTable LoadPolyFloral()
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT ID, FirstName, LastName, Honey, Quantity, Year FROM customer WHERE Honey = 'Polyfloral'";
            cnn.Open();
            using(SQLiteDataReader read = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(read);
                read.Close();
                cnn.Close();
                return dt;
            }
        }

      
        
       public static DataGridView DeletePerson(DataGridView dv)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cnn;
                for (int i = 0; i < dv.Rows.Count; i++) {
                    DataGridViewRow dr = dv.Rows[i];
                    if(dr.Selected == true)
                    {
                        string cout = dv.Rows[i].Cells[1].Value.ToString();
                        int number = int.Parse(cout);
              
                        dv.Rows.RemoveAt(i);
                        try
                        {
                            cnn.Open();
                            cmd.CommandText = "DELETE FROM Customer WHERE ID="+number+"";
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                           
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    
                }
                
            }
            return dv;
        }
    
  

        
        public static void SavePerson(PersonModel p)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
             
                cnn.Execute("insert into Customer(FirstName, LastName, Honey, Quantity, Year) values (@FirstName, @LastName, @Honey, @Quantity, @Year)", p);
                
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
