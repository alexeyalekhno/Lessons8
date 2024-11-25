using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"D:\Домашняя работа\fileWithNumbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0,10));
                }
            }

            
            using (StreamReader sr = new StreamReader(path))
            {
                int sum = 0;
                string[] numbers = File.ReadAllLines(path, System.Text.Encoding.UTF8);
                for (int i = 0; i < 10; i++)
                {
                    sum += int.Parse(numbers[i]);

                }

                Console.WriteLine(sum);
                Console.ReadKey();
            }
                
            
             
              

        }
    }
}
