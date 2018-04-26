using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgdInventoryTable.ColumnCount = 11;

            dgdInventoryTable.Columns[0].Name = "Item number";
            dgdInventoryTable.Columns[0].DataPropertyName = "ItemNo";
            dgdInventoryTable.Columns[1].Name = "Category";
            dgdInventoryTable.Columns[1].DataPropertyName = "Category";
            dgdInventoryTable.Columns[2].Name = "Title";
            dgdInventoryTable.Columns[2].DataPropertyName = "Title";
            dgdInventoryTable.Columns[3].Name = "Description";
            dgdInventoryTable.Columns[3].DataPropertyName = "Description";
            dgdInventoryTable.Columns[4].Name = "Quantity";
            dgdInventoryTable.Columns[4].DataPropertyName = "Quantity";
            dgdInventoryTable.Columns[5].Name = "Price per unit";
            dgdInventoryTable.Columns[5].DataPropertyName = "PricePerUnit";
            dgdInventoryTable.Columns[6].Name = "Total price";
            dgdInventoryTable.Columns[6].DataPropertyName = "TotalPrice";
            dgdInventoryTable.Columns[7].Name = "PVN";
            dgdInventoryTable.Columns[7].DataPropertyName = "PVN";
            dgdInventoryTable.Columns[8].Name = "Price + PVN";
            dgdInventoryTable.Columns[8].DataPropertyName = "PriceWithPVN";
            dgdInventoryTable.Columns[9].Name = "Date";
            dgdInventoryTable.Columns[9].DataPropertyName = "Date";
            dgdInventoryTable.Columns[10].Name = "Time";
            dgdInventoryTable.Columns[10].DataPropertyName = "Time";

            //izsaucam bazes klasi  metodi
            var connection = OperationsManager.GetOleDbConnection();

            string query = "SELECT * FROM items";
            using (connection)
            {
                //izsaucam mantotas klases apslepto metodi
                OperationsManager.readData(query, connection, dgdInventoryTable);
            }

            txtTotalPriceOfItemsInventory.Text = getTotalPrice(6).ToString(); ;
            txtTotalPVNInventory.Text = getTotalPrice(7).ToString();
            txtTotalPriceInventory.Text = getTotalPrice(8).ToString();

            int numRows = dgdInventoryTable.Rows.Count;
            txtTotalItems.Text = (numRows - 1).ToString();

        }

        public double getTotalPrice(int cellValue)
        {
            double sum = 0;
            for (int i = 0; i < dgdInventoryTable.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgdInventoryTable.Rows[i].Cells[cellValue].Value);
            }
            return sum;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem(this);
            addItem.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAccountingBrowse_Click(object sender, EventArgs e)
        {
            frmAccounting accountingForm = new frmAccounting();
            accountingForm.ShowDialog();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        public void RefreshGrid()
        {
            var connection = OperationsManager.GetOleDbConnection();
            string query = "SELECT * FROM items";

            using (connection)
            {
                //izsaucam mantotas klases apslepto metodi
                OperationsManager.readData(query, connection, dgdInventoryTable);
            }

            ConnectionManager.CloseOleDbConnection(connection);

            txtTotalPriceOfItemsInventory.Text = getTotalPrice(6).ToString(); ;
            txtTotalPVNInventory.Text = getTotalPrice(7).ToString();
            txtTotalPriceInventory.Text = getTotalPrice(8).ToString();
            int numRows = dgdInventoryTable.Rows.Count;
            txtTotalItems.Text = (numRows - 1).ToString();
        }

    }
}
