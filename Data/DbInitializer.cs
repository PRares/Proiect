using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PascanRares_Project.Models;

namespace PascanRares_Project.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreIT context)
        {
            context.Database.EnsureCreated();
            if (context.Laptops.Any())
            {
                return; // BD a fost creata anterior
            }
            var Laptops = new Laptop[]
            {
 new Laptop{Brand_Name="Asus",Processor="Intel Core i9",Price=Decimal.Parse("9963")},
 new Laptop{Brand_Name="Toshiba",Processor="AMD Ryzen 7",Price=Decimal.Parse("5900")},
 new Laptop{Brand_Name="Acer",Processor="Intel Core i3",Price=Decimal.Parse("2700")}
            };
            foreach (Laptop s in Laptops)
            {
                context.Laptops.Add(s);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

 new Customer{CustomerID=1050,Name="PopescuMarcela",BirthDate=DateTime.Parse("1979-09-01")},
 new Customer{CustomerID=1045,Name="MihailescuCornel",BirthDate=DateTime.Parse("1969-07-08")},

 };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
 new Order{LaptopID=1,CustomerID=1050},
 new Order{LaptopID=3,CustomerID=1045},
 new Order{LaptopID=1,CustomerID=1045},
 new Order{LaptopID=2,CustomerID=1050},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}