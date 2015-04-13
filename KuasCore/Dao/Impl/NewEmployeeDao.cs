
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "brown";
            employee1.Name = "熊大";
            employee1.Age = 15;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee1.Id = "lulu";
            employee1.Name = "露潞";
            employee1.Age = 18;
            employees.Add(employee2);

            return employees;

        }
        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "lulu";
            employees.Name = "露潞";
            employees.Age = 18;

            return employees;
        }
        

    }
}
