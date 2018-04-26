using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace md2_dotnet
{
    class ConnectionManager
    {
        public static OleDbConnection GetOleDbConnection()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md5_dotnet\inventory.mdb";
            var connection = new OleDbConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static OleDbConnection CloseOleDbConnection(OleDbConnection connection)
        {
            connection.Close();
            return connection;
        }
    }

    class OperationsManager : ConnectionManager
    {
        // pasleptaa metode
        new public static OleDbConnection GetOleDbConnection()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md5_dotnet\inventory.mdb";
            var connection = new OleDbConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static void readData(string query, OleDbConnection conn, DataGridView gridView)
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gridView.AutoGenerateColumns = false;
                gridView.DataSource = ds.Tables[0];
            }

        }

    }
}
