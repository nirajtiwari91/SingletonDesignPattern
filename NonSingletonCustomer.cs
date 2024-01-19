using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class NonSingletonCustomer
    {
        private NonSingletonLogger logger = new NonSingletonLogger();

        public void Method1()
        {
            logger.Log("Method1 executed.");
        }

        public void Method2()
        {
            logger.Log("Method2 executed.");
        }
    }
}
