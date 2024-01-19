using Microsoft.Extensions.Logging;//Install through nuget packages
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Example usage with SingletonLogger
            SingletonCustomer customerobj = new SingletonCustomer();
            customerobj.Method1();
            customerobj.Method2();
            Console.ReadLine();


            ////Singleton By the using ilogger DLL
            //// Setting up LoggerFactory to configure logging
            //var loggerFactory = LoggerFactory.Create(builder =>
            //{
            //    // Adding a console logger, you can add other logging providers here
            //    builder.AddConsole();
            //});

            //// Creating an instance of the logger for Customer
            //var logger = loggerFactory.CreateLogger<Customer>();

            //// Creating an instance of Customer and injecting the logger
            //var customerobj = new Customer(logger);

            //// Calling methods on ExampleClass, which internally logs information
            //customerobj.Method1();
            //customerobj.Method2();
            //Console.ReadLine();

            // Example usage with NonSingletonLogger
            //NonSingletonCustomer customerobj = new NonSingletonCustomer();
            //customerobj.Method1();
            //customerobj.Method2();
            //Console.ReadLine();
        }
    }
}
