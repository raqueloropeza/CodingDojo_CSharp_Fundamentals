using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Loop that prints all values from 1-255
            // for (int i =1; i<=255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //Create a new loop that prints all values from 1-100 that are divisilbe by 3 or 5, but not both 
            for (int j=1; j<=100; j++)
            if(j%3 ==0 && j%5== 0)
            {
                continue;
            }
            else if (j %3 == 0 || j%5 ==0)
            {
                Console.WriteLine(j);
            }

            //Create a loop that prints "Fizz for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiple of both  and 5
            
            for (int k=1; k<=100; k++)
            if(k%3==0 && k%5==0)
            {
                Console.WriteLine("FizzBuzz!");

            }
            else if (k %3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (k%5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}
