
using System;



  
public class Employee
{

    // Declare 3 variables - id,age and name
    int emp_id;
    int emp_age;
    string emp_name;

    // Get the to string method that returns
    // id , name and age
    public override string ToString()
    {
        return emp_id + " " + emp_name + " " + emp_age;
    }

    // Driver code
    static void Main(string[] args)
    {

        // Declare a list variable 
        List<Employee> emp1 = new List<Employee>()
    {
          
        // Create 8 employee details
        new Employee{ emp_id = 101, emp_name = "Rahul", emp_age = 23},
        new Employee{ emp_id = 102, emp_name = "sahil", emp_age = 24},
        new Employee{ emp_id = 103, emp_name = "disha", emp_age = 22},
        new Employee{ emp_id = 104, emp_name = "payal", emp_age = 24},
        new Employee{ emp_id = 105, emp_name = "jyothi", emp_age = 22},
        new Employee{ emp_id = 106, emp_name = "arun", emp_age = 30},
        new Employee{ emp_id = 107, emp_name = "sridhar", emp_age = 31},
        new Employee{ emp_id = 108, emp_name = "pallavi", emp_age = 28},
    };

        // Iterate the Employee by selecting Employee
        // id greater than 101
        // Using where clause
        IEnumerable<Employee> Query =
        from employee in emp1 where employee.emp_id > 100 select employee;

        // Display employee details
        Console.WriteLine("ID  Name  Age");
        Console.WriteLine("+++++++++++++");
        foreach (Employee e in Query)
        {

            // Call the to string method
            Console.WriteLine(e.ToString());
        }
    }

}