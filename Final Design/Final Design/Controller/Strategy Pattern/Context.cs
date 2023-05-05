using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Strategy_Pattern
{
    public class Context
    {
        private Payment payment;
        public Context()
        { }
        public void SetPayment(Payment strategy)
        {
            this.payment = strategy;
        }
        public Payment getPayment()
        {
            return this.payment;

        }
        public String methodPay()
        {
            return this.payment.methodPay();
        }
        public int pay(int a, int b)
        {
            return payment.pay(a, b);
        }
    }
}
