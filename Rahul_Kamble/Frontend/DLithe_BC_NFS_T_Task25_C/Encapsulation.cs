using System;

    class Student
    {
        private string name;//private member 
        private string dept;
    public int salary =350000;//public member
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            name = n;
        }
        public string GetDept()
        {
            return name;
        }
        public void SetDepartname(string d)
        {
            dept = d;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Department: {0}", dept);
        Console.WriteLine("Salary: {0}",salary);// public variable accessing directly
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Student e = new Student();
            e.SetName("MAYUR");
            e.SetDepartname("Electronics and Communication");
            e.Display();
            Console.ReadLine();
        }
    }
