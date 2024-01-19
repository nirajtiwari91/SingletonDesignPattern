using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingletonCustomer
    {
        public void Method1()
        {
            SingletonLogger.Instance.Log("Method1 executed.");
        }

        public void Method2()
        {
            SingletonLogger.Instance.Log("Method2 executed.");
        }
    }
}
