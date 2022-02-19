namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)     // args missing
        {
            Example obj1 = new();        // obj could be done as obj1
            obj1.empid = 101;                // reference variable does not match
            obj1.ename = "pranaya";
            obj1.eage = 27;
            obj1.eaddress = "bbsr";
            Console.WriteLine("Employee details are:");
            Console.WriteLine("employee id:" + obj1.empid);
            Console.WriteLine("employee name:" + obj1.ename);
            Console.WriteLine("employee age:" + obj1.eage);   // should be _eage
            Console.WriteLine("employee address:" + obj1.eaddress);
            Console.ReadKey();
        }
    }
}
