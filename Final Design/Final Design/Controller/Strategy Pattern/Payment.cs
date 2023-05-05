using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Strategy_Pattern
{
    public interface Payment
    {
        String methodPay();
        int pay(int a, int b);
    }
}
