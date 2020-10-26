using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class EmployeRepository
    {
        public List<Employe> SelectAllEmployes()
        {
            List<Employe> ListEmployees = new List<Employe>();

            ListEmployees.Add(new Employe() { Id = 1, Nom = "Pranaya", Departement = "IT" });
            ListEmployees.Add(new Employe() { Id = 2, Nom = "Kumar", Departement = "HR" });
            ListEmployees.Add(new Employe() { Id = 3, Nom = "Rout", Departement = "Payroll" });
            return ListEmployees;
        }
    }
}
