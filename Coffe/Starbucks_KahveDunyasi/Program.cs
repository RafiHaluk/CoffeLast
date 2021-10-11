using System;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Managers;
using Starbucks_KahveDunyasi.MernisAdapter;

namespace Starbucks_KahveDunyasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainCustomerManager mainCustomer = new StarbucksCustomerManager(new MernisServiceAdapter());
            mainCustomer.Save(new Customers{BirthData = new DateTime(1990,4,1),
                FirstName = "xxx",Id = 544127,LastName = "xxx",NationalityId = 25311111111});
            Console.ReadLine();
        }
    }
}