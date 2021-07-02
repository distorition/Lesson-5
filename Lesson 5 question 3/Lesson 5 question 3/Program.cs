using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Lesson_5_question_3
{
    class Program
    {
        class Num
        {
            public string SumNum { get; set; }
          
            public Num()
            {
                
            }
        }

        static void Main(string[] args)
        {
            
         


            Num num = new Num();
            num.SumNum = "12,123,124,51,43";

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(new FileStream("num.bin", FileMode.OpenOrCreate), num);
            Num num1 = (Num)binaryFormatter.Deserialize(new FileStream("num.bin", FileMode.Open));
            Console.WriteLine(num1.SumNum);
            

        }
    }
}
