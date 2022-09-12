//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
using System;

namespace exs66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число M: ");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumberRec(m,n));
            Console.WriteLine($"Сумма четных элементов от {m} до {n} = {CountEvenSum(m,n)}");
           
        string NumberRec(int m, int n)
            {
                if (m < n)
                {
                    return $"{m} "+NumberRec(m+1,n);
                }
                
                if (n < m)
                {
                    return $"{n} "+NumberRec(n+1,m);
                }
                else
                {
                    return $"{n}";
                }
            }
            
                 
        int CountEvenSum(int m, int n)
            {   
                int sum = 0;
                if (m < n)
                {
                    if(m%2==0)
                    {
                        return sum=sum+m+CountEvenSum(m+1,n);
                    }
                    else
                    {
                        return sum=sum+CountEvenSum(m+1,n);
                    }
                }
           
                if (n < m)
                {
                    if(n%2==0)
                    {
                        return sum=sum+n +CountEvenSum(n+1,m);
                    }
                    else
                    {
                        return sum=sum+CountEvenSum(n+1,m);
                    }
                }
                else
                {
                    if (n==m & n%2==0)
                    {
                        return sum=sum+n;
                    }
                    else
                    {
                        return sum; 
                    }
                }
            }
        }
    }
}
