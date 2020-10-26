using System;
using System.Collections.Generic;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {



            EmployeBL employeBL = new EmployeBL(new EmployeRepository());
            List<Employe> ListEmployee = employeBL.GetAllEmployes();


            foreach (Employe emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.Id, emp.Nom, emp.Departement);
            }





            Console.ReadKey();
        }
    }
}
