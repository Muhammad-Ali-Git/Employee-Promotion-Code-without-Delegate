// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Employee
{
    public int ID{get; set; }
    public string Name{get; set; }
    public int Salary {get; set; }
    public int Experience {get; set; }

    public static void Promotion(List <Employee> EmployeeList)
    {
        foreach (Employee emp in EmployeeList)
        {
            if (emp.Experience >= 5)
            {
                Console.WriteLine("{0} Promoted", emp.Name);
            }
        }
    }
}

public class Ali
{
    public static void Main()
    {
        List <Employee> empList = new List<Employee> ();
        empList.Add(new Employee() {ID = 1, Name = "Mary Luisse", Salary = 5000, Experience = 5});
        empList.Add(new Employee() {ID = 2, Name = "John Lorusso", Salary = 4000, Experience = 4});
        empList.Add(new Employee() {ID = 3, Name = "Ibrahim Arabaki", Salary = 6000, Experience = 6});
        empList.Add(new Employee() {ID = 4, Name = "Spendthrift", Salary = 3000, Experience = 3});

        Employee.Promotion(empList);
    }
}