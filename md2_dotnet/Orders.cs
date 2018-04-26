using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class Orders : Component
    {
        public Orders()
        {
            InitializeComponent();
        }

        public Orders(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }

    class Order
    {
        public string OrderNo { get; set; }
        public string PizzaType { get; set; }
        public string PizzaSize { get; set; }
        public int PizzaQuantity { get; set; }
        public string DrinkType { get; set; }
        public string DrinkVolume { get; set; }
        public int DrinkQuantity { get; set; }
        public string Description { get; set; }
        public double TotalPrice { get; set; }
        public string DateTime { get; set; }

        public void OnOrderAdded(object source, EventArgs args)
        {
            MessageBox.Show("Order added");
        }
    }

    class ManageOrders
    {
        public List<Order> orders = new List<Order>();

        public List<Order> Orders
        {
            get { return orders; }
        }

        public delegate void OrderAddedEventHandler(object source, EventArgs args);
        public event OrderAddedEventHandler OrderAdded;

        public void AddOrder(string orderNo, string pizzaType, string pizzaSize, int pizzaQuantity,
            string drinkType, string drinkVolume, int drinkQuantity, string description, double totalPrice, string dateTime)
        {
            orders.Add(new Order
            {
                OrderNo = orderNo,
                PizzaType = pizzaType,
                PizzaSize = pizzaSize,
                PizzaQuantity = pizzaQuantity,
                DrinkType = drinkType,
                DrinkVolume = drinkVolume,
                DrinkQuantity = drinkQuantity,
                Description = description,
                TotalPrice = totalPrice,
                DateTime = dateTime
            });

            OnOrderAdded();
       }

            protected virtual void OnOrderAdded()
            {
                if (OrderAdded != null)
                {
                    OrderAdded(this, EventArgs.Empty);
                }

            }

    }
}


