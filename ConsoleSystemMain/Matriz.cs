using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSystemMain
{
    class Matriz
    {

        static public int ChooseMatriz { get; set; } = 0;
        static public int[,] MatA { get; set; }
        static public int[,] MatB { get; set; }
        static public int[,] MatResult { get; set; }
        static public int MatSize { get; set; }
    
   
        static public void InitializerMatrizA()
        {
           MatA = new int[MatSize, MatSize];
        }

        static public void InitializerMatrizB()
        {
            MatB = new int[MatSize, MatSize];
        }

        static public void InitializerMatrizResult()
        {
            MatResult = new int[MatSize, MatSize];
        }

        static public void TypeValuesInMatrizA()
        {
            for(int i = 0; i <  MatSize; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < MatSize; j++)
                {
                    MatA[i, j] = int.Parse(values[j]);
                }
            }
        }

        static public void TypeValuesInMatrizB()
        {
            for (int i = 0; i < MatSize; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                    
                for (int j = 0; j < MatSize; j++)
                {
                    MatB[i, j] = int.Parse(values[j]);
                }
            }
        }

        static public void TypeValuesInMatrizResult()
        {
            for (int i = 0; i < MatSize; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < MatSize; j++)
                {
                    MatResult[i, j] = int.Parse(values[j]);
                }
            }
        }

        static public void SumOfMatriz()
        {
            for(int i = 0; i < MatSize; i++)
            {
                for(int j = 0; j < MatSize; j++)
                {
                    MatResult[i, j] = MatA[i, j] += MatB[i, j];
                }
            }
        }
        static public void SubtracionOfMatriz()
        {
            for (int i = 0; i < MatSize; i++)
            {
                for (int j = 0; j < MatSize; j++)
                {
                    MatResult[i, j] = MatA[i, j] -= MatB[i, j];
                }
            }
        }

        static public void PrintMatrizResult()
        {

            for (int i = 0; i < MatSize; i++)
            {
                for (int j = 0; j < MatSize; j++)
                {
                    Console.Write(MatResult[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
        }


    }
}

