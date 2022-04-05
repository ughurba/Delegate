using System;
using System.Collections.Generic;

namespace Delegat
{
    internal class Program
    {
        delegate bool Check(int num);
        //delegate void Write<T,U>(T str,U str2);
        //delegate C Write<in T,in U,out C>(T str, U str2);
        //delegate void Write1(bool t);
        //delegate void Write2(int n);
        delegate int Topla(int num1, int num2);
        static void Main(string[] args)
        {

            //Topla topla = delegate (int n, int m)
            //{
            //    int result = n + m;
            //  Console.WriteLine(result);
            //    return result;


            //};
            //topla += (n, m) =>
            //{
            //    Console.WriteLine("topla");
            //    return n - m;
            //};

            //Console.WriteLine(topla(5, 6));

          //  Action<int, int, int> test = (num1, num2, num3) =>
            //{
            //    num1 = 10;
            //    num2 = 20;
            //    num3 = 30;
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //};
           // Predicate<string> predicate = m => m.Length > 5;
           // Func<int, int, string> test3 = (n, m) => "test";
            //Console.WriteLine(Sum(new[] { 2, 3, 4, 10, 3, 2 }, n => n % 2 == 1));

            List<int> number = new List<int>();
            number.Add(2);
            number.Add(5);
            number.Add(4);
            number.Add(6);
            int num =  number.Find(n =>n > 2);
         List<int>nums = number.FindAll(n => n > 2);
            foreach (int num2 in nums)
            {
                Console.WriteLine(num2);
            }
           // Console.WriteLine(num);
        }
        static int Sum(int [] arr, Predicate<int> pred)
        {
            
            int result = 0;
            foreach (int i in arr)
            {
                if (pred(i))
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
