using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Strategy_Pattern
{
    public class ByCash : Payment
    {
        public String methodPay()
        {
            return "Thanh toán bằng tiền mặt ";

        }   
        public int pay(int a, int b)
        {
            return b - a;
        }
    }

}
