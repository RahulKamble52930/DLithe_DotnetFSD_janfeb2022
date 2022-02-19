namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Sum is {0}", c);

            c = a - b;
            Console.WriteLine("Difference is {0}", c);

            c = a * b;
            Console.WriteLine("Product is {0}", c);

            c = a / b;
            Console.WriteLine("Quotient is {0}", c);

            c = a % b;
            Console.WriteLine("Reminder is {0}", c);

            c = a++;
            Console.WriteLine("Post increment  {0}", c);

            c = a--;
            Console.WriteLine("Post decrement  {0}", c);
            Console.ReadLine();
        }
    }
}