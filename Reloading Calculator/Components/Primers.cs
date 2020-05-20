using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadingCalc.Components
{
    //Капсюль Цена шт\Количество\Общая цена

    class Primers : IComponents
    {
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double AllPrice(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            double result = Price * Quantity;
            return result;
        }
    }
}
