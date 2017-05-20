using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                A[i] = int.Parse(args[i]);
            }

            Console.WriteLine("square of the any number");

            for (int i = 0; i < args.Length; i++) 
            {
                for(int j = 1; j < args.Length; j++)
                {
                    if (A[i] == j * j)
                    {
                        Console.WriteLine(A[i]);
                    }
                }
            }

            Console.WriteLine("not divisible by 5");

            for (int i = 0; i < args.Length; i++) // not divisible by 5
            {
                if (A[i] % 5 != 0)
                {
                    Console.WriteLine(A[i]);
                }
            }

            
        }
    }
}
