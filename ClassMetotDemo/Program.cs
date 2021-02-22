using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerId = 000;

            Customer customer01 = new Customer();
            customerId++;
            customer01.Id = customerId;
            customer01.CustomerName = "Çağatay";
            customer01.CustomerSurname = "KARASU";
            customer01.TCKN = "0123456789";
            customer01.CustomerPhoneNumber = "+905554443322";

            Customer customer02 = new Customer();
            customerId++;
            customer02.Id = customerId;
            customer02.CustomerName = "Gökhan";
            customer02.CustomerSurname = "TÜRKMEN";
            customer02.TCKN = "9876543210";
            customer02.CustomerPhoneNumber = "+905443332211";

            Customer[] customerList = new Customer[] { customer01, customer02 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer01);
            customerManager.AddCustomer(customer02);

            customerManager.ListCustomer(customerList);

        }
    }
}
