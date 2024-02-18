using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Reservation_system
{
    public class Calculate
    {
        int total;
        int deserttotal;
        int drinktotal;
        int snackprice;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public int DesertTotal
        {
            get { return deserttotal; }
            set { deserttotal = value; }
        }
        public int DrinkTotal
        {
            get { return drinktotal; }
            set { drinktotal = value; }
        }
        public int Snackprice
        {
            get { return snackprice; }
                set { snackprice = value; }
        }
    }
}
