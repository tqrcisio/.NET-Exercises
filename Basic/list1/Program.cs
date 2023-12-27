using System.Globalization;
using list1.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee will be registered? ");
            int employeeBeRegistered = int.Parse(Console.ReadLine());

            List<Employee> listEmployees = new List<Employee>();

            for (int i = 1; i <= employeeBeRegistered; i++)
            {
                System.Console.WriteLine($"Employee #{i}:");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployees.Add(new Employee(id, name, salary));
                System.Console.WriteLine();
            }

            System.Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = listEmployees.Find(x => x.Id == searchId);
            if (emp != null)
            {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Updated list of employees:");

            foreach (Employee employeeString in listEmployees)
            {
                System.Console.WriteLine(employeeString);
            }
        }
    }
}