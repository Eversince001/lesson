using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson1
{

//    Разработайте и реализуйте консольное приложение, которое:
//  - запрашивает у пользователя данные о студенте, ФИО + оценки(запрос данных нужно
//    оформить в виде функции)

//  - хранит информацию о студенте и его успеваемости в некоторой структуре данных

//  - хранит список студентов в массиве, состоящем из 10 элементов

//  - позволяет пользователю либо добавить данные о новом студенте, либо прекратить
//    добавление данных

//  - выводит на экран полный список студентов; список студентов, имеющих только отличные
//  оценки; список студентов, имеющих хотя бы одну неудовлетворительную оценку

    class Students
    {

        private List<List<string>> students;

        public Students()
        {
            students = new List<List<string>>();
            StreamReader read = new StreamReader(@"C:\Users\Eversince001\source\repos\Lesson1\Lesson1\students.txt");

            string line = "";

            while (true)
            {
                line = read.ReadLine();
                if (line == null) break;
                students.Add(new List<string>());
                students[students.Count - 1].Add(line);
                line = read.ReadLine();
                students[students.Count - 1].Add(line);
            }

            read.Close();
        }

        public void AddData()
        {
            string FIOstudent;
            string rating;
            Console.WriteLine("Введите ФИО студента");
            FIOstudent = Console.ReadLine();
            Console.WriteLine("Введите оценки студента");
            rating = Console.ReadLine();

            Console.WriteLine("Добавить данные? Да/Нет");

            string n = Console.ReadLine();

            if (n.ToLower() == "да")
            {
                students.Add(new List<string>());
                students[students.Count - 1].Add(FIOstudent);
                students[students.Count - 1].Add(rating);

                StreamWriter writer = new StreamWriter(@"C:\Users\Eversince001\source\repos\Lesson1\Lesson1\students.txt");

                for (int i = 0; i < students.Count; i++)
                {
                    writer.WriteLine(students[i][0]);
                    writer.WriteLine(students[i][1]);
                }

                writer.Close();

                Console.WriteLine("Информация о студенте добавлена в базу данных \n");
            }   
            else
            {
                Console.WriteLine("Данные о студенте не были добавлены в базу данных \n");
            }    
        }

        public void getBestStudents()
        {
            Console.WriteLine("Стуенты обучающиеся на отлично:");

            for (int i = 0; i < students.Count; i++)
            {
                if (!students[i][1].Contains("2") && !students[i][1].Contains("3") && !students[i][1].Contains("4") && !students[i][1].Contains("1"))
                {
                    Console.WriteLine(students[i][0]);
                }
            }
            Console.WriteLine("\n");
        }

        public void getBadStudents()
        {
            Console.WriteLine("Стуенты плохо обучающиеся:");

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i][1].Contains("2") || students[i][1].Contains("1"))
                {
                    Console.WriteLine(students[i][0]);
                }
            }
            Console.WriteLine("\n");
        }
    }

}
