using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int firstnumber;
            int secondnumber;            
            Console.WriteLine("Please Enter the First Number");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number");
            secondnumber = Convert.ToInt32(Console.ReadLine());  
          
            Console.WriteLine("Result is "+(firstnumber+secondnumber));
        }
    }
}