using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadingCalc.Components
{
    //Порох           Цена банки\Количество банок\Количество в банке\Общая цена
    public class Powder : IComponents
    {
        public double Price { get; set; }
        public int Quantity { get ; set; }
        public int Weight { get; set; }

        public double AllPrice(double price, int quantity, int weight)
        {
            Price = price;
            Quantity = quantity;
            Weight = weight;
            double result = Price * Quantity;
            return result;
        }
    }
}
