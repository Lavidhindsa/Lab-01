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
    public class DelegateExercises
    {
        public object MyDelegate { get; private set; }

        void Method3()
        {
            Console.WriteLine(MyDelegate.ToString());
        }
    }
}