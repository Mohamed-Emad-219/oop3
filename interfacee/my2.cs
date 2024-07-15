using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.interfacee
{
    internal class my2:IMY1
    {
        private int salary;

        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
