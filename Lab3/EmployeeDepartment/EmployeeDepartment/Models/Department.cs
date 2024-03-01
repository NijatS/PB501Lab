using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDepartment.Models
{
	public class Department
	{
		public string Name { get; set; }
		public static int EmployeeLimit = 3;
		public static float SalartLimit = 250;
		public List<Employee> Employees = new List<Employee>();

        public Department(string Name)
        {
            this.Name = Name;
        }
        public void AddEmployee()
		{
			Employee employee = AddData();
			Employees.Add(employee);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Successfully added");
        }
		public void ShowEmployee()
		{
			foreach (Employee emp in Employees)
			{
				Console.WriteLine(emp.ToString());
			}
		}
		public void RemoveEmployee()
		{
            ShowEmployee();
            Console.Write("PLease Enter Id:");
			int id  = int.Parse(Console.ReadLine());

			foreach (var emp in Employees)
			{
				if(emp.Id == id)
				{
					Employees.Remove(emp);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Succesfully Remove");
					break;
                }
			}
        }
		public void EditEmployee()
		{
			ShowEmployee();
			Console.Write("PLease Enter Id:");
			int id = int.Parse(Console.ReadLine());
			foreach (var emp in Employees)
			{
				if (emp.Id == id)
				{
					Employee employee = AddData();
					emp.Name = employee.Name;
					emp.Surname = employee.Surname;
					emp.Salary = employee.Salary;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Succesfully Modified");
					break ;
                }
			}
		}
	
		public Employee AddData()
		{
			string name = String.Empty;
			string surname = String.Empty;
			float salary = 0;
			do
			{
				Console.Write("Please enter Employee name: ");
			      name = Console.ReadLine();
				Console.Write("Please enter surname: ");
				surname = Console.ReadLine();
				Console.Write("Salary: ");
				salary = float.Parse(Console.ReadLine());

			}
			while (!CheckSalary(salary) || !CheckString(name) || !CheckString(surname));

			Employee employee = new Employee(name, surname, salary);
			return employee;
		}
		private bool CheckString(string str)
		{
			if (!char.IsUpper(str[0]))
			{
				Console.WriteLine(str + " ilk herifi boyuk olmalidi");
				return false;
			}
			if (!str.All(char.IsLetter))
			{
				Console.WriteLine(str + " hamisi herif olmalidi");
				return false;
			}
			return true;
		}
		private bool CheckSalary(float salary)
		{
			if (SalartLimit > salary)
			{
				Console.WriteLine("Maas " + SalartLimit + "-den azdir");
				return false;
			}
			return true;
		}
	}
}
