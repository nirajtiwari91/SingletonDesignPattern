using System;
using Microsoft.Extensions.Logging; //Install through nuget packages.

namespace SingletonDesignPattern
{
    // A class representing some example functionality
    public class Customer
    {
        // Private field to store the ILogger instance
        private readonly ILogger<Customer> logger;

        // Constructor that takes an ILogger instance as a dependency
        public Customer(ILogger<Customer> logger)
        {
            this.logger = logger;
        }

        // Method1: Demonstrates logging information using the injected ILogger
        public void Method1()
        {
            logger.LogInformation("Method1 executed.");
            // Your method logic here
        }

        // Method2: Demonstrates logging information using the injected ILogger
        public void Method2()
        {
            logger.LogInformation("Method2 executed.");
            // Your method logic here
        }
    }
}
