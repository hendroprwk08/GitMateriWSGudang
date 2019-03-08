using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nambahin
using System.Data;
using System.Data.SqlClient;

namespace AppWarehouse
{
    
    class DBClass
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private String connectionString;

        //constructor (kode yang pertama dijalankan saat class digunakan)
        public DBClass() {
            //connnectionstring.com
            connectionString = "Data Source = DESKTOP-0A8V1IK\\SQLEXPRESS; " + 
                               "Initial Catalog = DB_WAREHOUSE; " +
                               "Integrated Security = TRUE";
            conn = new SqlConnection(connectionString); 
        }

        public void open() {
            conn.Open();
        }

        public void close() {
            conn.Close();
        }

        //simpan, update, delete
        public void execute(String sql) {
            try
            {
                open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                close();
            }
        }

        //select
        public DataTable read(String sql)
        {
            DataTable myTable = new DataTable();

            try
            {
                open();
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(myTable);
                return myTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                close();
            }

            return null;
        }




    }
}
     