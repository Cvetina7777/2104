using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStaff
{
    public class Employee
    {
        public string EmployeeName
        {
            get
            {
                return EmployeeName;
            }
          set { EmployeeName = value; }
        }
        
        public int countofStaff {  get; set; }


        

        public string Position { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    
    
      private List<Employee> staff = new List<Employee>();
        public List<Employee> Staff
        {
            get
            {
                return staff;

            }
            set 
            { 
            staff = value;
            }
            
        }
        public void PrintAll()
        {
            Console.WriteLine($"EmployeeName{this.EmployeeName}");
            foreach ( Employee emp in staff )
            {
                
            }
        }
    }
    
   

    
   

}
