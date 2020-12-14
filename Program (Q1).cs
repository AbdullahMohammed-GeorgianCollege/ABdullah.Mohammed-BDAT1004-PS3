using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpQuestions
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Running!");

            //number of students
            Console.WriteLine("Please enter the nubmer of the teset case!");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t >= 1 && t <= 100)
            {
                for (int i = 1; i <= t; i++)
                {
                    Console.Write("Case numner ");
                    Console.WriteLine(i);

                    //number of students
                    Console.WriteLine("Please enter the nubmer of students!");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n >= 1 && n <= 1000)
                    {
                        //the threshold number of students
                        Console.WriteLine("Please enter threshold number of students!");
                        int k = Convert.ToInt32(Console.ReadLine());

                        if (k >= 1 && k <= n)
                        {
                            //entirng the arrival times on the array
                            Console.WriteLine("enter the arrive time for students");
                            string arrival = Console.ReadLine();

                            string[] split = arrival.Split(' ');



                            //the test case,
                            Console.WriteLine(AngryProfessor(k, split));

                            Console.WriteLine("well done!");
                        }
                        else
                            Console.WriteLine("Sorry, k is out of the range");
                    }
                    else
                        Console.WriteLine("Sorry, n is out of the range");
                }
            }
            else
                Console.WriteLine("Sorry, t is out of the range");
        }

        private static string AngryProfessor(int v, string[] split)
        {
            Console.WriteLine("The arriving data : ");
            int test = 0;
            foreach (string item in split)
            {
                Console.WriteLine(item);
                test++;
            }
            if (test < v) { return "YES"; }
            
            return "NO";
            
        }
    }
}
