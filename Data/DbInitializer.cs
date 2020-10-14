using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Panca_Delia_Lab2.Models;

namespace Panca_Delia_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return; // BD a fost creata anterior
            }
            var books = new Book[]
            {
 new Book{Title="Baltagul",Author="Mihail Sadoveanu",Price=Decimal.Parse("22")},
 new Book{Title="Enigma Otiliei",Author="George Calinescu",Price=Decimal.Parse("18")},
 new Book{Title="Maytrei",Author="Mircea Eliade",Price=Decimal.Parse("27")}
            };
            foreach (Book s in books)
            {
                context.Books.Add(s);
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
        }
    }
}
