
using EmployeeDepartment.Models;
bool IsContinue = true;
string Menu = "1. Add Employee \n" +
	"2. Show All Employees\n" +
	"3. Edit Employee\n" +
	"4. Remove Employee\n" +
	"q. Exit";
Department department = new Department("Code Academy");
while (IsContinue)
{
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine(Menu);
    Console.Write("Please enter step: ");
	string step = Console.ReadLine();
	Console.Clear();
	switch (step)
	{
		case "1":
			if(department.Employees.Count >= Department.EmployeeLimit)
			{
                Console.WriteLine("Siz limite catmisiniz!!!");
                break;
			}
			department.AddEmployee();
			break;
		case "2":
			if (department.Employees.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("There is not any employee. Firstly, please enter employee!!!");
				break;
			}
			department.ShowEmployee();
			break;
		case "3":
			if (department.Employees.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("There is not any employee.");
				break;
			}
			department.EditEmployee();
			break;
		case "4":
			if (department.Employees.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("There is not any employee.");
				break;
			}
			department.RemoveEmployee();
			break;
		case "q":
			IsContinue = false;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Exiting Program...");
			Thread.Sleep(2000);
			break;
		default:
            Console.WriteLine("\n\nPlease enter valid step");
            break;
	}
	Console.ForegroundColor = ConsoleColor.White;
}