using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class EmployeeLinq
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<EmployeeLinq> GetAllEmployee()
        {
            List<EmployeeLinq> employees = new List<EmployeeLinq>()
            {
                new EmployeeLinq { Id = 100, Name = "Asmita", Salary = 2345678, Department = "IT" },
                new EmployeeLinq { Id = 211 , Name = "Ankita", Salary = 5587387, Department = "ETC"},
                new EmployeeLinq { Id = 203 , Name = "Asmita", Salary = 578967456, Department = "MATH"},
                new EmployeeLinq { Id = 301 , Name = "UGHYDF", Salary = 8674656, Department = "PHYSICS"},
                new EmployeeLinq { Id = 134 , Name = "Ankita", Salary = 4677567, Department = "SCIENCE"},
            };
            return employees;
        }

        public void DistinctEmp()
        {
            var MethodSyntax = GetAllEmployee().Select(x =>x.Name).Distinct().ToList();

            var QuerySyntax = (from emp in EmployeeLinq.GetAllEmployee() select emp.Name).Distinct().ToList();

            Console.WriteLine("Using Method Sysntax : ");
            foreach (var Memp in MethodSyntax)
            {
                Console.WriteLine(Memp);
            }

            Console.WriteLine("Using Query Sysntax : ");
            foreach (var Qemp in  QuerySyntax)
            {
                Console.WriteLine(Qemp);
            }
        }
    }
}
