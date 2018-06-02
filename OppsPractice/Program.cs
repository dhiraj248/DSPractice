using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OppsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculate cal = new Calculate();
            cal.add(3,5);
        }
    }

    interface ICalculate
    {
        int add(int a, int b);
    }

    class Calculate:ICalculate
    {
        int ICalculate.add(int a, int b)
        {
            return a * b;
        }

        //public int add(int a,int b)
        //{
        //    return a + b;
        //}
               
    }
}
