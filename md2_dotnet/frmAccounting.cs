using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class frmAccounting : Form
    {
        public frmAccounting()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder newOrderForm = new frmAddOrder(this);
            newOrderForm.ShowDialog();
        }

        private void frmAccounting_Load(object sender, EventArgs e)
        {

            dgdAccountingTable.AutoGenerateColumns = false;

            dgdAccountingTable.ColumnCount = 10;

            dgdAccountingTable.Columns[0].Name = "Order nr.";
            dgdAccountingTable.Columns[0].DataPropertyName = "OrderNo";
            dgdAccountingTable.Columns[1].Name = "Pizza type";
            dgdAccountingTable.Columns[1].DataPropertyName = "PizzaType";
            dgdAccountingTable.Columns[2].Name = "Pizza size";
            dgdAccountingTable.Columns[2].DataPropertyName = "PizzaSize";
            dgdAccountingTable.Columns[3].Name = "Quantity";
            dgdAccountingTable.Columns[3].DataPropertyName = "PizzaQuantity";
            dgdAccountingTable.Columns[4].Name = "Drink type";
            dgdAccountingTable.Columns[4].DataPropertyName = "DrinkType";
            dgdAccountingTable.Columns[5].Name = "Drink volume";
            dgdAccountingTable.Columns[5].DataPropertyName = "DrinkVolume";
            dgdAccountingTable.Columns[6].Name = "Quantity";
            dgdAccountingTable.Columns[6].DataPropertyName = "DrinkQuantity";
            dgdAccountingTable.Columns[7].Name = "Description";
            dgdAccountingTable.Columns[7].DataPropertyName = "Description";
            dgdAccountingTable.Columns[8].Name = "Total Price";
            dgdAccountingTable.Columns[8].DataPropertyName = "TotalPrice";
            dgdAccountingTable.Columns[9].Name = "Date and time";
            dgdAccountingTable.Columns[9].DataPropertyName = "DateTime";
 
        }

        }
    }



