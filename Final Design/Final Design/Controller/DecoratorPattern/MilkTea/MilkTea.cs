using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.MilkTea
{
    public interface MilkTea
    {
        string MakeMilkTea();
        int GetPrice();
    }
}