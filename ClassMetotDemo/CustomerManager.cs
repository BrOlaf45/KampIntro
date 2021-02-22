using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer (Customer customer)
        {
            Console.WriteLine("Müşteri Id : "+ customer.Id +
                "\nMüşteri Adı : " + customer.CustomerName +
                "\nMüşteri Soyadı : " + customer.CustomerSurname +
                "\nMüşteri TCKN : " + customer.TCKN +
                "\nMüşteri Telefon No : " + customer.CustomerPhoneNumber + 
                "\n########################################\n");
        }

        public void ListCustomer(Customer[] customerList)
        {
            foreach (var customer in customerList)
            {
                if (customer != null)
                {
                    Console.WriteLine("Müşteri Id : " + customer.Id +
                        "\nMüşteri TCKN : " + customer.TCKN +
                        "\nMüşteri Adı ve Soyadı : " + customer.CustomerName + " " + customer.CustomerSurname +
                        "\nMüşteri Telefon No : " + customer.CustomerPhoneNumber);
                }
                else
                    continue;
            }
        }
    }
}
