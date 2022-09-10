//Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N от большего к меньшему.
using System;

namespace exs64
{
    class Program
    {
        static void Main(string[] args)
        {
        string Number(int a, int b)
          {
            if(a>b)
            {
                return $"{a} " + Number(a-1,b);
            }
           if(b>a)
            {
               return $"{b} " + Number(b-1,a); 
            }
            else 
            {
                return $"{a}";
            }
           
          }
        Console.WriteLine(Number(5,5));
          
        }
    }
}
