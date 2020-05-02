using ModelCrm.Models;
using ModelCrm.Options;
using ModelCrm.Services;
using System;

namespace ModelCrm
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOptions custOps = new CustomerOptions()
            {
                FirstName = "Konstantinos",
                LastName = "Thanaselos",
                Address = "Efpalio",
                VatNumber = "123456789",
                Email = "kthanaselos@gmail.com",
                Phone = "6976512900",
                Dob = new DateTime(1994, 7, 17),
            };

            CustomerCrud custCrud = new CustomerCrud();
            Customer customer = custCrud.CreateCustomer(custOps);

            Console.WriteLine($"Id={customer.Id} " +
                $"FirstName={customer.FirstName}");
        }
    }
}
