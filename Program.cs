using System;
using System.Collections.Generic;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    //int a = 3, b = 5, c = 2;
                    //int max, min, avarage = 0;



                    //if (a > b)
                    //{
                    //    max = a;
                    //    min = b;

                    //    if (c > a)
                    //    {
                    //        max = c;
                    //    }
                    //    else
                    //    {
                    //        if (b > c)
                    //        {
                    //            min = c;
                    //            avarage = b;
                    //        }
                    //        else
                    //        {
                    //            avarage = c;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    max = b;
                    //    min = a;

                    //    if (c > b)
                    //    {
                    //        max = c;
                    //        avarage = b;
                    //    }
                    //    else
                    //    {
                    //        if (c > a)
                    //        {
                    //            avarage = c;
                    //        }
                    //        else
                    //        {
                    //            avarage = a;
                    //            min = c;
                    //        }
                    //    }
                    //}

                    //int Max = Math.Abs(max - min);
                    //int Min;

                    //if (Math.Abs(min - avarage) > Math.Abs(max - avarage))
                    //{
                    //    Min = Math.Abs(max - avarage);
                    //}
                    //else
                    //{
                    //    Min = Math.Abs(min - avarage);
                    //}


                    //Console.WriteLine(Max);
                    //Console.WriteLine(Min);
                }
                {
                    //int a = 3, b = 4, c = 5, d = 6;

                    //if ((a + b + c) > d && (a + b + d) > c && (a + c + d) > b && (b + c + d) > a)
                    //{
                    //    Console.WriteLine("True");

                    //}
                    //else
                    //{
                    //    Console.WriteLine("False");
                    //}
                }
                {
                    //double a = 3, b = 4, c = 10;

                    //roots rt = new roots();

                    //List<double> RT = new List<double>();

                    //RT = rt.root(a, b, c);
                }
                {
                    //double a = 0.5, b = 2;

                    //if (a < 0 && b < 0)
                    //{
                    //    a = Math.Abs(a);
                    //    b = Math.Abs(b);
                    //}
                    //else
                    //{
                    //    if (a < 0 && b >= 0)
                    //    {
                    //        a++;
                    //        b++;
                    //        Console.WriteLine(a);
                    //        Console.WriteLine(b);
                    //        Console.Read();
                    //        return;
                    //    }
                    //    else
                    //    {
                    //        if (a >= 0 && b < 0)
                    //        {
                    //            a++;
                    //            b++;
                    //            Console.WriteLine(a);
                    //            Console.WriteLine(b);
                    //            Console.Read();
                    //            return;
                    //        }

                    //    }

                    //    if (a >= 0.5 && b >= 0.5 && a <= 2 && b <= 2)
                    //    {
                    //        a /= 2;
                    //        b /= 2;
                    //    }
                    //}

                    //Console.WriteLine(a);
                    //Console.WriteLine(b);

                    //Console.Read();
                }

            }
            var rand = new Random();
            deque d = new deque();
            stack s = new stack();
            for (int i = 1; i < 11; i++)
            {
                d.push_back(rand.Next(1, 10));
            }
            for (int i = 1; i < 11; i++)
            {
                s.push_back(rand.Next(1, 10));
            }

            int count = 0;

            List<int> list_d = d.deque_storage();
            List<int> list_s = s.stack_storage();

            deque d1 = d.Copy();
            stack s1 = s.Copy();

            for (int i = 0; i < s1.count(); i++)
            {
                Console.Write(list_s[i].ToString() + " ");
            }
            Console.Write('\n');

            for (int i = 0; i < d1.count(); i++)
            {
                Console.Write(list_d[i].ToString() + " ");
            }
            Console.Write('\n');

            for (int i = 0; i < d1.count(); i++)
            {
                var deq = d1.pop_back();
                for (int j = 0; j < s1.count(); j++)
                {
                    var st = s1.pop_back();
                    j--;
                  
                    if (st == deq)
                    {
                        count++;
                    }
                }
                s1 = s.Copy();
            }

            Console.WriteLine(count);

            Console.Read();

        }
    }
}
