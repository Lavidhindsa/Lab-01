using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
//Student name=Harmanjot Singh  Student Id: C0727172
//Student Name = Labhwinder Singh Student ID: C0728432
//CSD3354 Section 2
//Assignment 2
//March 8,2019
{

    public class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        int Method1(int intMethod1)
        {
            return intMethod1 * 4;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}