using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice
{
    class Stack
    {

        public int top { get; set; }
        public int max { get; set; }
        public int size { get; set; }
        int[] stackarr = null;

        public Stack(int s)
        {
            size = s;
            top = -1;
            max = size - 1;
            stackarr = new int[size];
        }

        public void Push(int data)
        {
            top++;
            if (top > max)
            {
                Console.WriteLine("Stack is overflow!");
            }
            else
            {
                stackarr[top] = data;
            }
        }

        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is underflow!");

            }
            else
            {
                Console.WriteLine($"The element is poped {stackarr[top]}");
                stackarr[top] = 0;
                top--;
            }
        }

    }
}
