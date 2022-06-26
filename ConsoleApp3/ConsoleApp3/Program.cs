using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int a = 10;
            Console.WriteLine("read age");

            String age = Console.ReadLine();
            int num = int.Parse(age);

            if (num == 10)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("age is" + num);
                }
            }

            else
            {
                Console.WriteLine("age is not equal to 10");
            }



            //int age=Convert.ToInt32(Console.ReadLine());
            //int tid = int.Parse("10");
        }
    }
}
