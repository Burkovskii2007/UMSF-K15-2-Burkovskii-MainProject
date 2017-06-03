using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада =");
            string x = Console.ReadLine();
            double sum = double.Parse(x);
            Console.WriteLine("Введите процент =");
            string y = Console.ReadLine();
            double perc = double.Parse(y);
            double sum2 = (perc * sum) / 100 + sum;
            Console.WriteLine("В конце года сумма будет равна " + sum2);
            Console.ReadKey();


            
            

        }
    }
}
