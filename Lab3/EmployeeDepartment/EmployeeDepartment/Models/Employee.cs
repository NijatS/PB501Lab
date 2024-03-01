using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
	public class Employee
	{
		private static int _count = 0;
		public readonly int Id;
		public string Name { get; set; }
		public string Surname { get; set; }
		public float Salary { get; set; }

        public Employee(string Name , string Surname , float Salary)
        {
			_count ++;
			Id = _count;
            this.Name = Name;
			this.Surname = Surname;
			this.Salary = Salary;
        }
		public override string ToString()
		{
			return "Id: " + this.Id +"  Name: " + this.Name + "  Surname: " + this.Surname + "  Salary: "+ this.Salary;
		}
	}
}
