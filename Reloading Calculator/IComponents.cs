using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadingCalc
{
    interface IComponents
    {
        double Price { get; set; }
        int Quantity { get; set; }
        double AllPrice(double Price, int Quantity);
    }
}
