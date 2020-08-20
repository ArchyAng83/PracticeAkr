using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAkr
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 6;
            Task1 task1 = new Task1();
            double[] myArray = new double[k];
            myArray = task1.CreateArray(myArray.Length);
            task1.PrintArray(myArray);
            Console.WriteLine();
            double max = task1.Max(myArray);
            Console.WriteLine("{0:f3}", max);
            task1.SaveFile(myArray);
            Console.WriteLine("from file:");
            task1.LoadFile();
            Console.ReadKey();
        }
    }
}
