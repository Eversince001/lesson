using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class deque
    {
        private List<int> d;
        public deque()
        {
            d = new List<int>();
        }

        //Добавить элемент в конец дека
        public void push_back(int value)
        {
            d.Add(value);
            Console.WriteLine("Элемент добавлен в конец дека\n");
        }

        //Добавить элемент в начало дека
        public void push_front(int value)
        {
            d.Insert(0, value);
            Console.WriteLine("Элемент добавлен в начало дека\n");
        }

        //Взять элемент из дека
        public int pop_front()
        {
            if (!isEmpty())
            {
                int elem;

                elem = d[0];

                d.RemoveAt(0);

                return elem;
            }

            return int.MaxValue;
        }

        //Взять элемент из конца дека
        public int pop_back()
        {
            if (!isEmpty())
            {
                int elem;

                elem = d[d.Count - 1];

                d.RemoveAt(d.Count - 1);

                return elem;
            }

            return int.MaxValue;
        }

        //Посмотреть первый элемент дека
        public void view_front()
        {
            if (!isEmpty()) Console.WriteLine(d[0]);

            else { Console.WriteLine("Дек пустая!\n"); }
        }

        //Посмотреть последний элемент дека
        public void view_back()
        {
            if (!isEmpty()) Console.WriteLine(d[d.Count - 1]);

            else { Console.WriteLine("Дек пустой!\n"); }
        }

        //Проверка дек на пустоту
        public bool isEmpty()
        {
            if (count() > 0)
            {
                return false;
            }

            return true;
        }

        //Количество элементов в деке
        public int count()
        {
            return d.Count;
        }

        public deque Copy()
        {
            deque d = new deque();

            List<int> list = deque_storage();
            for (int i = 0; i < count(); i++)
                d.d.Add(list[i]);

            return d;
        }

        //Просмотр содержимого дека
        public List<int> deque_storage()
        {
            return d;
        }
    }
}
