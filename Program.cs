using oop3.overraid;

namespace oop3
{
    internal class Program
    {
        #region ploymarphsim
        public static int Sum2nums(int x, int y)
        {
            return x + y;
        }
        public static int Sum3nums(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int Sum4nums(int x, int y, int z, int m)
        {
            return x + y + z + m;
        } 
        #endregion
        static void Main(string[] args)
        {
            //Sum2nums(1, 2);
            TypeA typeA = new TypeA(2);
            typeA.A = 3;
            typeA.myfun1();
            typeA.myfun2();
            TypeB typeB = new TypeB(1, 3);
            typeB.A = 2;
            typeB.B = 2;
            typeB.myfun1(); // i am base 
            typeB.myfun2(); // typea a = 3
             
        }
    }
}
