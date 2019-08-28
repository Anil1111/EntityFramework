using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDBEntities ObjSample = new SampleDBEntities();
            List<CustomerTbl> ObjCustomer = ObjSample.CustomerTbls.ToList();




           
            CustomerTbl cc = ObjCustomer[1];



            cc.CustomerName = "SWATI";
            ObjSample.SaveChanges();

            //  ObjSample.Employees.Add(eee);//In Memory
            ObjSample.SaveChanges();//Data base
            Console.WriteLine("Record Inserted         ");

           foreach (CustomerTbl ee in ObjCustomer)
              Console.WriteLine("CUST Id     " + ee.CustomerID  + "CUST Name      " + ee.CustomerName );
            Console.WriteLine("Happy Coding       ");

            Console.ReadLine();
        }
    }
}
