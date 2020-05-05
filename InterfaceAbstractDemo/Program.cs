using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { 
                DateOfBirth = new DateTime(0000,0,0),//Year,month,date
                FirstName = "Furkan Umut",
                LastName = "Ceylan",
                NationalityId = "12345678912" //Just to Turkey
            }); 
        }
    }
}
