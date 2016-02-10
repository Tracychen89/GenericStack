using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> myStack = new GenericStack<int>();
            for(int i = 0; i < 50; i++)
            {
                myStack.Push(i);
            }
            myStack.Display();
        }
    }
    class GenericStack<T>
    {
        public int Capacity;
        private int top = -1;
        public T[] Items;

        public GenericStack()
        {
            Items = new T[Capacity];
        }

        public GenericStack(int capacity)
        {
            Capacity = capacity;
            Items = new T[Capacity];
        }

        public void Push(T item)
        {
            if (top == (Capacity - 1))
            {
                IncreaseCapacity();
            }
            Items[++top] = item;
        }

        public T Pop()
        {
            if(top == -1)
            {
               throw new InvalidOperationException("Stack is empty!");
            }
            else
            {
                return Items[top--];
            }

        }

        protected void IncreaseCapacity()
        {
            this.Capacity++;
            this.Capacity *= 2;
            T[] tempItems = new T[Capacity];
            for (int i = 0; i <= top; i++)
            {
                tempItems[i] = Items[i];
            }
            this.Items = tempItems;
        }
        public T Peek()
        {
            if(top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                return Items[top];
            }
        }
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine(Items[i]);
            }
        }
    

    }
}
