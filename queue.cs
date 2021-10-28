using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class queue
    {
        private List<int> q;
        public queue()
        {
            q = new List<int>();
        }

        //Добавить элемент в очередь
        public void push_back(int value)
        {

            q.Add(value);
            Console.WriteLine("Элемент добавлен в очередь\n");
        }

        //Взять элемент из очередb
        public int pop_front()
        {
            if (!isEmpty())
            {
                int elem;

                elem = q[0];

                q.RemoveAt(0);

                return elem;
            }

            return int.MaxValue;
        }

        //Посмотреть последний элемент очереди
        public void view_front()
        {
            if (!isEmpty()) Console.WriteLine(q[0]);

            else { Console.WriteLine("Очередь пустая!\n"); }
        }

        //Проверка очереди на пустоту
        public bool isEmpty()
        {
            if (count() > 0)
            {
                return false;
            }

            return true;
        }

        //Количество элементов в очереди
        public int count()
        {
            return q.Count;
        }

        //Просмотр содержимого очереди
        public List<int> queue_storage()
        {
            return q;
        }
    }
}
