using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class frmAddItem : Form
    {
        // metožu pārslogošana
        public double GetPrice(double pricePerUnit, int quantity)
        {
            double result = pricePerUnit * quantity;
            return result;
        }

        public double GetPrice(double totalPrice)
        {
            double pvn = (totalPrice * 21) / 100;
            double result = totalPrice + pvn;
            return result;
        }

        private frmInventory frm1; 

        public frmAddItem(frmInventory frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(Enums.InventoryProperties.Categories));
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string stringItemNo = txtItemNo.Text;
            string category = cmbCategory.Text;
            string title = txtTitle.Text;
            string descr = rtfItemDescription.Text;
            string stringQuantity = txtQuantity.Text;
            string stringPrice = txtPrice.Text;

            bool hasErrors = false;

            string[] str = { stringItemNo, category, title, descr, stringQuantity, stringPrice };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Trim().Equals(""))
                    hasErrors = true;
            }

            if (hasErrors)
                errEmptyFields.SetError(btnAddItem, "Kāds no laukiem ir tukšs!");

            try
            {
                int itemNo;
                bool isItemNoInt = Int32.TryParse(stringItemNo, out itemNo);
                if (!isItemNoInt)
                {
                    errCheckItemNo.SetError(txtItemNo, "Jāievada tikai veseli skaitļi!");
                    hasErrors = true;
                }

                int quantity;
                bool isQuantityInt = Int32.TryParse(stringQuantity, out quantity);
                if (!isQuantityInt)
                {
                    errCheckQuantity.SetError(txtQuantity, "Jāievada tikai veseli skaitļi!");
                    hasErrors = true;
                }

                double price;
                bool isDouble = Double.TryParse(stringPrice, out price);
                if (!isDouble)
                {
                    errCheckPrice.SetError(txtPrice, "Jāievada tikai skaitļi!");
                    hasErrors = true;
                }

                double totalPrice = GetPrice(price, quantity);
                double pvn = (totalPrice * 21) / 100;
                double priceWithPvn = GetPrice(totalPrice);

                string date = DateTime.Now.ToString("MM/dd/yyyy");
                string time = DateTime.Now.ToString("HH:mm:ss");

                // ja nav kļūdas ievadē, savienojamies ar DB un ievietojam datus tajā
                if (!hasErrors)
                {
                    var connection = ConnectionManager.GetOleDbConnection();

                    using (connection)
                    {
                        using (OleDbCommand saveData = new OleDbCommand())
                        {
                            saveData.Connection = connection;

                            saveData.CommandText = "INSERT INTO items (ItemNo, Category, Title, Description, Quantity, PricePerUnit, TotalPrice, PVN, PriceWithPVN, [Date], [Time]) " +
                                                   "VALUES (@itemNo, @category, @title, @descr, @quantity, @pricePerUnit, @totalPrice, @pvn, @priceWithPvn, @date, @time)";

                            saveData.Parameters.AddWithValue("@itemNo", OleDbType.Integer).Value = itemNo;
                            saveData.Parameters.AddWithValue("@category", OleDbType.Char).Value = category;
                            saveData.Parameters.AddWithValue("@title", OleDbType.Char).Value = title;
                            saveData.Parameters.AddWithValue("@descr", OleDbType.Char).Value = descr;
                            saveData.Parameters.AddWithValue("@quantity", OleDbType.Integer).Value = quantity;
                            saveData.Parameters.AddWithValue("@pricePerUnit", OleDbType.Double).Value = price;
                            saveData.Parameters.AddWithValue("@totalPrice", OleDbType.Double).Value = totalPrice;
                            saveData.Parameters.AddWithValue("@pvn", OleDbType.Double).Value = pvn;
                            saveData.Parameters.AddWithValue("@priceWithPvn", OleDbType.Double).Value = priceWithPvn.ToString();
                            saveData.Parameters.AddWithValue("@date", OleDbType.Char).Value = date;
                            saveData.Parameters.AddWithValue("@time", OleDbType.Char).Value = time;

                            Console.WriteLine(price);

                            saveData.ExecuteNonQuery();
                            MessageBox.Show("Item added!");
                            ConnectionManager.CloseOleDbConnection(connection);

                            frm1.RefreshGrid(); // atjaunojam datagridview pēc datu ievietošanas

                            this.Hide();
                        }
                    }
                }
            }

            catch
            {

            }
        }

    }
}
