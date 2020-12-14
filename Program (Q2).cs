using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CSharpQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running!");
            int[] a= new int[100];
            int[] b = new int[100];


            //number of array1
            Console.WriteLine("Please enter the nubmer of array 1!");
            int n = Convert.ToInt32(Console.ReadLine());

            //number of array2
            Console.WriteLine("Please enter the nubmer of array 2!");
            int m = Convert.ToInt32(Console.ReadLine());

            if ((n >= 1 && n <= 10) && (m >= 1 && m <= 10))
            {
                //array 1
                Console.WriteLine("Please enter the array 1!");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Enter the element number ");
                    Console.WriteLine(i);
                    int element = Convert.ToInt32(Console.ReadLine());
                    if (element < 1 || element > 100)
                    {
                        Console.WriteLine("Sorry, element is out of the range (1 to 100)");
                    }
                    a[i] = element;
                }
                Console.WriteLine("Thanks, the first array is filled now");
                Console.WriteLine("*************************************");
                Console.WriteLine("Now, you can fill the array 2");


                //array 2
                Console.WriteLine("Please enter the array 2!");
                for (int i = 1; i <= m; i++)
                {
                    Console.Write("Enter the element number ");
                    Console.WriteLine(i);
                    int element = Convert.ToInt32(Console.ReadLine());
                    while (element < 1 || element > 100)
                    {
                        Console.WriteLine("Sorry, element is out of the range (1 to 100)");
                    }
                    a[i] = element;
                }
                Console.WriteLine("Thanks, the second array is filled now");
                Console.WriteLine("*************************************");

                getTotalX(a, b);

            }
            else
                Console.WriteLine("Sorry, n, or m is out of the range");

        }

        private static void  getTotalX(int[] a, int[] b)
        {
            int res = 0;
            if (a.Max() < b.Min())
                res = Enumerable.Range(a.Max(), (b.Min() - a.Max() + 1))
                                .Where(x => a.All(s => x % s == 0) && b.All(s => s % x == 0))
                                .Count();
            Console.WriteLine(res);

        }
    } 
}
