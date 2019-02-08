using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class matrix
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] B = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] C = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            Console.WriteLine("Matrix A: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + B[i, j]);
                }
                Console.WriteLine();
            }
           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < 3 ; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                        Console.Write(C[i, j] + " ");
                    }
                }
            }
            Console.WriteLine("Matrix multiplication: ");
            for (int i = 0; i <=2; i++)
            {
                for (int j = 0; j <=2; j++)
                {
                    Console.Write("\t" + C[i, j]);
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();



        }
    }
}
