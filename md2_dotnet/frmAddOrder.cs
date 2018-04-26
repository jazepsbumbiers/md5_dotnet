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

    public partial class frmAddOrder : Form
    {
        private frmAccounting form1;

        public frmAddOrder(frmAccounting form1)
        {
            InitializeComponent();

            this.form1 = form1;

            cmbPizzaSize.DataSource = Enum.GetValues(typeof(Enums.OrderProperties.PizzaSizes));
            cmbDrinkSize.DataSource = Enum.GetValues(typeof(Enums.OrderProperties.DrinkSizes));
            cmbPizzaType.DataSource = Enum.GetValues(typeof(Enums.OrderProperties.PizzaTypes));
            cmbDrinks.DataSource = Enum.GetValues(typeof(Enums.OrderProperties.DrinkTypes));
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("HH:mm:ss tt");
            double totalPrice = double.Parse(txtTotalPrice.Text);

            var orderList = new ManageOrders();
            var order = new Order();

            orderList.OrderAdded += order.OnOrderAdded;

            orderList.AddOrder(txtOrderNo.Text, cmbPizzaType.Text, cmbPizzaSize.Text, (int)numPizzas.Value,
                cmbDrinks.Text, cmbDrinkSize.Text, (int)numDrinks.Value, rtfDescription.Text, totalPrice, dateTime);
  
            var bindingList = new BindingList<Order>(orderList.orders);
            var source = new BindingSource(bindingList, null);
            form1.dgdAccountingTable.DataSource = source;
  
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            

        }


    }

    
}

