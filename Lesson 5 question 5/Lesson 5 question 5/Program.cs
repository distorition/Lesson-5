using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Lesson_5_question_5
{
    class ToDo
    {

        
        
        public string Title { get; set; }
        public int IsDone { get; set; }

        public ToDo()
        {
           
        
        }

       

        public string Mytarget()
        {
            Console.WriteLine("Ввидите свою задачу");
            string target = Console.ReadLine();

            return Title= target;
        }

        public void ShowArray(string[]arry)
        {
            string[] fileLines = arry;
            Console.WriteLine("Хотите увидеть список задач Yes or No");
            string choise = Console.ReadLine();
            int count = 0;
            if (choise == "Yes"|| choise=="да")
            {
                for (int i = 0; i < fileLines.Length; i++)
                {

                    Console.WriteLine(fileLines[i] + " " + count++);

                }
            }
            else if(choise=="No"||choise=="нет")
            {
                Console.WriteLine("программа закрыта ");
            }
            else
            {
                Console.WriteLine("Вводите как напсиано");
                ShowArray(fileLines);
            }
        }
        public void Show(string[] arry)
        {
            string[] fileLines = arry;

            Console.WriteLine("Показать списоку ? yes or no ");
            string choise1 = Console.ReadLine();
            if (choise1 == "yes" || choise1 == "да")
            {
                
                int count1 = 0;
                for (int i = 0; i < fileLines.Length; i++)
                {

                    Console.WriteLine(fileLines[i] + " " + count1++);

                }


            }
            else if(choise1=="no"|| choise1=="нет" )
            {
                Console.WriteLine("всего доброго");
            }    
            else
            {
                Console.WriteLine("Вводите как написанно");
                Show(fileLines);
            }
        }
        
        public int Count(int sum)
        {
            IsDone = sum+1;
            return IsDone;
        }
        public( string[], int sum) CreatPerson(string target)
        {

          


            string fileName = "ToDoList";
            File.AppendAllLines(fileName, new[] { target });

            string[] fileLines = File.ReadAllLines(fileName);

            ShowArray(fileLines);

            int count = 0;
            int sum = 0;
            Console.WriteLine("Ввидите номер задачи если вы ее сделали ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                
                Console.WriteLine($"[x] {fileLines[a]}");
                Remove(ref fileLines, a);
                File.WriteAllLines(fileName, fileLines);
                //string[] fileLines1 = File.ReadAllLines(fileName);
                //File.AppendAllLines(fileName,fileLines1);
                //string fileText = File.ReadAllText(fileName);
                Console.WriteLine("Заметка удалена");
               sum += count+1;
                Console.WriteLine($"Молодцы у вас уже {sum}+Выолненых заметок ");
              
                Show(fileLines);
                Count(sum);

            }
            else
            {
                Console.WriteLine("Пока-пока");
                
            }

            return (fileLines, sum);
           

        }

       
            public void Remove(ref string[] array, int index)
            {
                string[] newArr = new string[array.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    newArr[i] = array[i];
                }
                for (int i = index + 1; i < array.Length; i++)
                {
                    newArr[i - 1] = array[i];
                }

                array = newArr;
            }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            ToDo toDo = new ToDo();
           
            toDo.Mytarget();
            string a = toDo.Title;

            
            toDo.CreatPerson(a);
            Console.WriteLine(toDo.IsDone);
            string json = JsonConvert.SerializeObject(toDo);
            File.WriteAllText("ToDolist.json", json);
        }

    }
}
