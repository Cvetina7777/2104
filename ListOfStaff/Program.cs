using System.Threading.Channels;

namespace ListOfStaff
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();
          Console.WriteLine("input count of staff");
            Employee staff = new Employee();
                Employee staffEmployee = new Employee();
                Console.Write("input name: ");
                staffEmployee.EmployeeName = Console.ReadLine();
                Console.WriteLine("input Salary");
                staffEmployee.Salary = double.Parse(Console.ReadLine());
                 Console.WriteLine("input Position"); 
                staffEmployee.Position = Console.ReadLine();
                Console.WriteLine("input email");
                staffEmployee.Email = Console.ReadLine();
                 Console.WriteLine("input age");
                staffEmployee.Age=int.Parse(Console.ReadLine());
                employee.Staff.Add(staffEmployee);
            
            
           
           
        }
    }
}