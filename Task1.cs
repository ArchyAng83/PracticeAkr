using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAkr
{
    /*Дан одномерный массив состоящий из K элементов вещественного типа.
     *Определить методы для:
        - заполнения элементов массива случайными числами;
        - вывода элементов массива на экран;
        - возврата максимального элемента массива;
        - чтение элементов массива из текстового файла;
    */


    public class Task1
    {
        Random rnd = new Random();
        string path = "1.txt";

        public double[] CreateArray(int k)
        {
            double[] arr = new double[k]; 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 10 * rnd.NextDouble();
            }
            return arr;
        }

        public virtual void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0:f3}\t", arr[i]);
            }
        }

        public double Max(double[] arr)
        {
            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                max = arr[i] > max ? arr[i] : max;
            }
            return max;
        }

        public void SaveFile(double[] arr)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sw.Write("{0:f3}\t", arr[i]);
                }
            }
        }

        public void LoadFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                //string line;
                //while ((line = sr.ReadLine()) != null)
                //{
                //    Console.WriteLine(line);
                //}
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
