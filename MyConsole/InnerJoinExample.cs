using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class InnerJoinExample
    {
        static void Main(string[] args)
        {
            //var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(), e => e.DepartmentID, d => d.ID, (employee, department) => new { Employees = employee, Department = department });

            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new { Employees = e, Department = d };

            foreach(var employee in result)
            {
                Console.WriteLine(employee.Employees.ID + "\t" + employee.Employees.Name + "\t" + employee.Department.Name);
            }

            Console.ReadLine();
        }
    }
}
