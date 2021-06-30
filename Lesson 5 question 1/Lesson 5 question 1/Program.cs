using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_5_question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите что нибудь ");
            string a = Console.ReadLine();
            Console.WriteLine("и еще");
            string d = Console.ReadLine();
            Console.WriteLine("еще больше");
            string c = Console.ReadLine();
            
            
            File.AppendAllText(a, Environment.NewLine);
            File.AppendAllLines(a, new[] { d,c });

            string sum1 = File.ReadAllText(a);
            Console.WriteLine(sum1);
            string[] sum = File.ReadAllLines(a);
            Console.WriteLine(sum[2]);



        }
    }
}
