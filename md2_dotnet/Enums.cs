using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2_dotnet
{
    public static class Enums
    {
        public static class OrderProperties
        {

            public enum PizzaSizes
            {
                Small,
                Medium,
                Large
            }

            public enum DrinkSizes
            {
                Small = (int)0.35,
                Medium = (int)0.5,
                Large = (int)1.0
            }

            public enum PizzaTypes
            {
               Pepperoni,
               Cheese,
               Mushrooms,
               Bacon,
               Chicken
            }

            public enum DrinkTypes
            {
                Cola,
                Pepsi,
                Fanta,
                Sprite,
                Coffee,
                Tea,
                Milkshake
            }

        }

        public static class InventoryProperties
        {

            public enum Categories
            {
                Coffee,
                Tea,
                Lemonades,
                Cheese,
                Sauces,
                Dough,
                Meat,
                Vegetables
            }

        }

    }
}
