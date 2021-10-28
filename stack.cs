using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class stack
    {
        private List<int> st;
        private int N; 
        public stack()
        {
            st = new List<int>();
            N = 10;
        }

        //Добавить элемент в стек
        public void push_back(int value)
        {
            if (st.Count < N)
            {
                st.Add(value);
                Console.WriteLine("Элемент добавлен в стек\n");   
            }
            else
            {
                Console.WriteLine("Размер стека достиг предела(10 элементов)\n");
            }
        }

        //Взять элемент из стека
        public int pop_back()
        {
            if (!isEmpty())
            {
                int elem;

                elem = st[st.Count - 1];

                st.RemoveAt(st.Count - 1);

                return elem;
            }

            return int.MaxValue;
        }

        //Посмотреть последний элемент стека
        public void view_back()
        {
            if (!isEmpty()) Console.WriteLine(st[st.Count - 1]);

            else { Console.WriteLine("Стек пустой!\n"); }
        }

        //Проверка стека на пустоту
        public bool isEmpty()
        {
            if (count() > 0)
            {
                return false;
            }

            return true;
        }

        //Количество элементов в стеке
        public int count()
        {
            return st.Count;
        }

        public stack Copy()
        {
            stack s = new stack();
            List<int> list = stack_storage();
            for (int i = 0; i < count(); i++)
                s.st.Add(list[i]);

            return s;
        }

        //Просмотр содержимого стека
        public List<int> stack_storage()
        {
            return st;
        }

    }
}
