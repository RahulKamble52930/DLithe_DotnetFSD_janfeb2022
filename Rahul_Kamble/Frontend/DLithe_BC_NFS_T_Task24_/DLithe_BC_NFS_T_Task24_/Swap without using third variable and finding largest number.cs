using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        
        int a = 5, b = 10;


        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=50 (5*10)      
        b = a / b; //b=5 (50/10)      
        a = a / b; //a=10 (50/5)    
        Console.WriteLine("After swap a= " + a + " b= " + b);


        //swapping the number
        Console.WriteLine("Finding largest number");
        int first = 8, second = 30, third = 156;
        if (first > second)
        {
            
            if (first > third)
            {
                Console.WriteLine("largest number : " + first);
            }
            else
            {
                Console.WriteLine("largest number : " + third);
            }
        }
        else
        {
            if (second > third)
            {
                Console.WriteLine("largest number : " + second);
            }
            else
            {
                Console.WriteLine("largest number : " + third);
            }
        }
    }
}
