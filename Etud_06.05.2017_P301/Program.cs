using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;
namespace Etud_06._05._2017_P301
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrixs a = new Matrixs();

            //int[,] data=a.ReadData(3, 3);
            //a.ShowData(data);

            //int[,]result=a.Diaqonal(data);
            //a.ShowData(result);
            //Console.WriteLine("\t");


            //for triangle matrix

            int[,]result=a.Triangle(5, 5);
            Console.ReadKey();
        }
        
    }
}
