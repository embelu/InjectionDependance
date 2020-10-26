using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class EmployeBL
    {
        public EmployeRepository employeRepository;


        public List<Employe> GetAllEmployes()
        {
            employeRepository = new EmployeRepository();
            return employeRepository.SelectAllEmployes();
        }
    }
}
