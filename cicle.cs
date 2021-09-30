using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class cicle
    {
        public void task1(double x)
        {
            double y;
            double z = 1, ch = 1;

            int i = 2;

            do
            {
                z *= x - (i - 1);

                ch *= x - i; 

                i *= i;
            }
            while (i <= 64);

            y = ch / z;

            Console.WriteLine(y);
        }

        public void task2(int n)
        {

            double sum = Math.Sqrt(2);
            for (int i = 0; i < n - 1; i++)
            {
                sum += 2;
                sum = Math.Sqrt(sum);     
            }

            Console.WriteLine(sum);
        }

        public void task3(int n, double x)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Sin(Math.Pow(x, i));
            }

            Console.WriteLine(sum);
        }

        public void task4(int N)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                var rand = new Random();
                list.Add(rand.Next(0, 2));
            }

            int number = -1;
            bool started = false;
            int count = 0;
            int max_count = 0;
            int index = -1;

            for (int i = 0; i < N; i++)
            {
                if (started)
                {
                    if (list[i] == 1)
                    {
                        count++;
                    }
                    else
                    {
                        started = false;
                        if (count > max_count)
                        {
                            index = number;
                            max_count = count;
                        }
                        count = 0;
                    }
                    }
                else
                {
                    if (list[i] == 1)
                    {
                        started = true;
                        number = i;
                        count++;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(index);
                Console.WriteLine(max_count);
            }

        }
    }
}
