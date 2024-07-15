using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.overraid
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a,int _b) : base(_a)
        {
            B = _b;
        }
        public new void myfun1()
        {
            Console.WriteLine("I am child");
        }
        public override void myfun2()
        {
            Console.WriteLine($"typeb :B  {B}");

        }
    }
}
