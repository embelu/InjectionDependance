using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public interface IEmployeRepository
    {
        List<Employe> SelectAllEmployes();
    }
}
