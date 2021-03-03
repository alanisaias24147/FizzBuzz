using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {


                int secuencia = i + 1; 

                if (secuencia % 15 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (secuencia % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }

                else if (secuencia % 3 == 0)
                {
                    Console.WriteLine("Fizz"); 
                }

                else  

                {
                    Console.WriteLine(secuencia);
                }

                
            }
        }
    }
}
      
