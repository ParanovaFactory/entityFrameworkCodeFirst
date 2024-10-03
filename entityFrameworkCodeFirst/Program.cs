using entityFrameworkCodeFirst.DAL;
using entityFrameworkCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Customer customer = new Customer();

            void list()
            {
                var values = context.Customers.ToList();
                foreach (var value in values)
                {
                    Console.WriteLine(value.customerId + " " + value.customerName + " " + value.customerCity);
                }
            }


            //customer.customerName = "Berkay Karaduman";
            //customer.customerCity = "Gaziantep";
            //context.Customers.Add(customer);
            //context.SaveChanges();
            //list();


            //list();
            //int id = 6;
            //var valueDelete = context.Customers.Find(id);
            //context.Customers.Remove(valueDelete);
            //context.SaveChanges();
            //list();

            //list();
            //string name = Console.ReadLine();
            //var valueDelete = context.Customers.Where(x => x.customerName == name).FirstOrDefault();
            //context.Customers.Remove(valueDelete);
            //context.SaveChanges();
            //list();

            //list();
            //int id = int.Parse(Console.ReadLine());
            //var valueUpdate = context.Customers.Find(id);
            //valueUpdate.customerCity = "Chemnitz";
            //context.SaveChanges();
            //list();

            list();
            int id = int.Parse(Console.ReadLine());
            var valueUpdate = context.Customers.Where(x => x.customerId == id).FirstOrDefault();
            valueUpdate.customerCity = "Gaziantep";
            context.SaveChanges();
            list();
        }
    }
}
