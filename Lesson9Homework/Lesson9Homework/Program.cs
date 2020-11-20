using System;

namespace Lesson9Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();
            address1.Index = 31245;
            address1.Country = "United Kingdom";
            address1.City = "London";
            address1.Street = "Soho";
            address1.House = 23;
            address1.Apartment = 15;

            Address address2 = new Address();
            address2.Index = 3456;
            address2.Country = "USA";
            address2.City = "New York";
            address2.Street = "Manhattan";
            address2.House = 1;
            address2.Apartment = 112;
            Console.WriteLine($"Address 1 Index:{address1.Index}, Country:{address1.Index}; City:{address1.City}, Street {address1.City}, Street:{address1.Street}, House:{address1.House}, Apartment:{address1.Apartment}");
            Console.WriteLine($"Address 2 Index:{address2.Index}, Country:{address2.Index}; City:{address2.City}, Street {address2.City}, Street:{address2.Street}, House:{address2.House}, Apartment:{address2.Apartment}");

        }
    }
}
