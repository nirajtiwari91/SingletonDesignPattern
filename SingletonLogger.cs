using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingletonLogger
    {
        private static SingletonLogger _instance;

        // Private constructor to prevent instantiation
        private SingletonLogger() { }

        // Singleton instance
        public static SingletonLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonLogger();
                }
                return _instance;
            }
        }

        // Log method
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
