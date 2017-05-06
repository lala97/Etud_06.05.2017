using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrixs
    {
        public int[,] ReadData(int n, int m)
        {
            int[,] data = new int[n,m];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return data;
        }

        public int[,] ShowData(int[,]value)
        {
            
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int j = 0; j < value.GetLength(1); j++)
                {
                    Console.Write(value[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            return value;
        }

        public int[,] Diaqonal(int[,] value)
        {
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int j = 0; j < value.GetLength(1); j++)
                {
                    if (i+j== value.GetLength(0)-1)
                    {
                        value[i, j] = 0;
                    }
                }
                
            }
            return value;
        }

        //triangle matrix
        public int[,] Triangle(int n,int m)
        {
            int[,] value = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                value[i, 0] = 1;

                for (int j = 0; j <= i; j++)
                {
                    if (j>0)
                    {
                        value[i, j] = value[i - 1, j] + value[i - 1, j-1];
                    }
                    Console.Write(value[i, j]+"\t");

                }

                Console.WriteLine("\n");
            }
            return value;
        }
    }
    
}
