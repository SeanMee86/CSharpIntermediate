using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var p = Person.Parse("Sean");
            // p.Introduce("Jeff");
            //var customer = new Customer(1, "John");
            //var customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Sean"
            //};
            //customer.Id = 1;
            //customer.Name = "Sean";
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            //*********** Inheritance **************

            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            //************ Composition **************

            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
