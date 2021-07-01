using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__5_question_4
{
    class Program
    {
        static void Main(string[] args)
        {


            string pathDirect = @"D:\NewFather2";
            Console.WriteLine(Directory.Exists(pathDirect));

            string FatherPath = Path.Combine(pathDirect, "Notes");
            Directory.CreateDirectory(FatherPath);

            string namePathFile = "D:\\NewFather2\\Notes";
            string ourNotes = Path.Combine(FatherPath, "Документ с содержанием пути.txt");
            File.WriteAllText(ourNotes, namePathFile);

            string namePathFile1 = "D:\\NewFather2";
            string ourNotes1 = Path.Combine(pathDirect, "путь к файлам.txt");
            File.WriteAllText(ourNotes1, namePathFile1);

           






            //string pathFile = @"D:\NewFather";
            //Console.WriteLine(Directory.Exists(pathFile));

            ////создаем папку Notes
            ///
            //string notesFile = Path.Combine(pathFile, "Notes");

            //Directory.CreateDirectory(notesFile);

            ////создаем в папке нотес текстовый документ с названием "какой то текст" и передаем туда фрауз "Тут будет пути к файрам"
            //string noteText = "Тут будет пути к файлам"; //то что мы будем заносить в наши документы

            //string notePath = Path.Combine(notesFile, "какой то текст.txt");

            //File.WriteAllText(notePath, noteText);

            ////копируем содержимое

            //string copyOfNotePath = Path.Combine(pathFile, "Копия заметки2.txt");


            //File.Copy(notePath, copyOfNotePath);

            //Console.WriteLine(File.Exists(copyOfNotePath));

            //File.Move(copyOfNotePath, Path.Combine(notesFile, "Notes2.txt"));

            //Directory.CreateDirectory(Path.Combine(pathFile, "Documents"));

            //Directory.Move(notesFile, Path.Combine(pathFile, "Documents", "Notes"));

            //string[] enteirs = Directory.GetFileSystemEntries(pathFile, "*", SearchOption.AllDirectories);
            //for(int i=0;i<enteirs.Length;i++)
            //{
            //    Console.WriteLine(enteirs[i]);
            //}


        }
    }
}
