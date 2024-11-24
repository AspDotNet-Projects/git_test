using System;

namespace Git_Remote
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Boxing
            int num = 1369;
            Object obj = num;  


            ///Unboxing
            ///
            Object objj = 123;
            int numm = (int) objj;
            Console.WriteLine("num:"+numm);
            Console.WriteLine("obg:"+objj);
            Console.ReadLine();
        }
    }
}
