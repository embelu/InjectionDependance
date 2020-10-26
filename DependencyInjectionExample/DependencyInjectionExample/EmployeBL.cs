using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class EmployeBL
    {
        // ici, nous ne créons plus d'objet de type EmployeRepository
        // mais on passe l'interface au niveau du constructeur. Ce qui veut dire que n'importe quel objet qui
        // implémente l'interface IEmployeRepository peut être passé au constructeur.
        

        public IEmployeRepository _employeRepository;

        public EmployeBL(IEmployeRepository employeRepository)
        {
            _employeRepository = employeRepository;
        }

        public List<Employe> GetAllEmployes()
        {
            return _employeRepository.SelectAllEmployes();
        }
    }
}
