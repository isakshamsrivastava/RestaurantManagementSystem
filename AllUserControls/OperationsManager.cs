using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.AllUserControls
{
    public class OperationsManager
    {
       
        public long priceCalc(long qty, long price)
        {
            long total = qty * price;
            return total;
        }


        public string validateLogin(string uname, string pass)
        {
            if (uname == "saksham" && pass == "pass")
            {
                return "Admin";
            }
            else
            {
                return "";
            }
        }


    }
}
