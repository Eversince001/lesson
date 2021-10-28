using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson1
{

   //Дана информация  о владельцах  автомобилей одного  города в файле А1.
   //Элемент файла включает фамилию, имя, отчество владельца, марку автомобиля, год его выпуска и 
   //номер автомобиля (номер за-дается четырьмя цифрами). Найти:
   //а)  число автомобилей  каждой марки с учетом года выпуска. Эти сведения должны включать марку автомобиля, год выпуска, число автомобилей;
   //б)  фамилии(а также  имя, отчество)  владельцев автомобилей  заданной марки и номера их автомобилей;
   //в) возможных владельцев угнанных автомобилей и номера их автомобилей,  
   //если задан  список марок угнанных автомобилей.Список содержится в текстовом файле А2;
   //г) владельцев угнанных автомобилей, если задан список 
   //угнанных автомобилей в файле А3.Элемент файла включает номер автомобиля и его марку
    class auto
    {
        private List<List<string>> Auto;
        private List<string> Stolen;
        private List<List<string>> StolenG;
        public auto()
        {
            Auto = new List<List<string>>();
            Stolen = new List<string>();
            StolenG = new List<List<string>>();

            StreamReader read = new StreamReader(@"C:\Users\Eversince001\source\repos\Lesson1\Lesson1\A1.txt");

            string line = "";

            while (true)
            {
                line = read.ReadLine(); // Фио
                if (line == null) break;
                Auto.Add(new List<string>());
                Auto[Auto.Count - 1].Add(line);
                line = read.ReadLine(); // марка
                Auto[Auto.Count - 1].Add(line);
                line = read.ReadLine(); // год выпуска
                Auto[Auto.Count - 1].Add(line);
                line = read.ReadLine(); // номер
                Auto[Auto.Count - 1].Add(line);
            }

            read.Close();

        }

        public List<List<string>> Copy(List<List<string>> List)
        {
            List<List<string>> avt = new List<List<string>>();
            for (int i = 0; i < List.Count; i++)
            {
                avt.Add(new List<string>());

                for (int j = 0; j < List[i].Count; j++)
                {
                    avt[i].Add(List[i][j]);
                }

            }

            return avt;
        }

        public List<List<string>> A()
        {
            List<List<string>> tmp = new List<List<string>>(); //список результурующий
            List<List<string>> avt = new List<List<string>>(); 

            avt = Copy(Auto);

            if (avt.Count != 0)
            {
                tmp.Add(new List<string>());
                tmp[0].Add(avt[0][1]);
                tmp[0].Add(avt[0][2]);
                tmp[0].Add("1");
                avt.Remove(avt[0]);
            }

            while (avt.Count != 0)
            {
                for (int i = 0; i < avt.Count; i++)
                {
                    if (avt[i][1] == tmp[tmp.Count - 1][0] && avt[i][2] == tmp[tmp.Count - 1][1])
                    {
                        int count = Convert.ToInt32(tmp[tmp.Count - 1][2]);
                        count++;
                        tmp[tmp.Count - 1][2] = count.ToString();
                        avt.Remove(avt[i]);
                        i--;
                    }
                }

                if (avt.Count != 0)
                {
                    tmp.Add(new List<string>());
                    tmp[tmp.Count - 1].Add(avt[0][1]);
                    tmp[tmp.Count - 1].Add(avt[0][2]);
                    tmp[tmp.Count - 1].Add("1");
                    avt.Remove(avt[0]);
                }
            }


            return tmp;
        }

        public List<List<string>> B(string mark)
        {
            //б)  фамилии(а также  имя, отчество)  владельцев автомобилей  заданной марки и номера их автомобилей;
            List<List<string>> tmp = new List<List<string>>(); //список результурующий

            for (int i = 0; i < Auto.Count; i++)
            {
                if (Auto[i][1] == mark)
                {
                    tmp.Add(new List<string>());
                    tmp[tmp.Count - 1].Add(Auto[i][0]);
                    tmp[tmp.Count - 1].Add(Auto[i][3]);

                }
            }

            return tmp;

        }

        public List<List<string>> V()
        {
            StreamReader readA2 = new StreamReader(@"C:\Users\Eversince001\source\repos\Lesson1\Lesson1\A2.txt");
            string line = "";
            while (true)
            {
                line = readA2.ReadLine(); // Марка украденного автомобиля
                if (line == null) break;
                Stolen.Add(line);
            }

            readA2.Close();

            //в) возможных владельцев угнанных автомобилей и номера их автомобилей, если задан  список марок угнанных автомобилей.Список содержится в текстовом файле А2;
            List<List<string>> tmp = new List<List<string>>(); //список результурующий

            for (int i = 0; i < Auto.Count; i++)
            {
                for (int j = 0; j < Stolen.Count; j++)
                {
                    if (Stolen[j] == Auto[i][1])
                    {
                        tmp.Add(new List<string>());
                        tmp[tmp.Count - 1].Add(Auto[i][0]);
                        tmp[tmp.Count - 1].Add(Auto[i][3]);
                    }
                }
               
            }

            Stolen.Clear();
            return tmp;

        }

        public List<List<string>> G()
        {
            //г) владельцев угнанных автомобилей, если задан список 
            //угнанных автомобилей в файле А3.Элемент файла включает номер автомобиля и его марку
            List<List<string>> tmp = new List<List<string>>(); //список результурующий

            StreamReader readA2 = new StreamReader(@"C:\Users\Eversince001\source\repos\Lesson1\Lesson1\A3.txt");
            string line = "";
            while (true)
            {
                line = readA2.ReadLine(); // Марка украденного автомобиля
                if (line == null) break;
                StolenG.Add(new List<string>());
                StolenG[StolenG.Count - 1].Add(line);
                line = readA2.ReadLine(); // Номер украденного автомобиля
                StolenG[StolenG.Count - 1].Add(line);
            }

            readA2.Close();

            for (int i = 0; i < Auto.Count; i++)
            {
                for (int j = 0; j < StolenG.Count; j++)
                {
                    if (StolenG[j][0] == Auto[i][1] && StolenG[j][1] == Auto[i][3])
                    {
                        tmp.Add(new List<string>());
                        tmp[tmp.Count - 1].Add(Auto[i][0]);
                    }
                }

            }

            Stolen.Clear();
            return tmp;
        }
    }
}
