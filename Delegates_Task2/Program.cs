using System;

namespace HW_Delegates
{
    internal delegate int MyDelegate(MyDelegate2[] delegates);

    internal delegate int MyDelegate2();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate2 method1 = MyMethods.Method1;
            MyDelegate2 method2 = MyMethods.Method2;
            MyDelegate2 method3 = MyMethods.Method3;
            MyDelegate2[] delegates = new MyDelegate2[3];
            delegates[0] = method1;
            delegates[1] = method2;
            delegates[2] = method3;
            MyDelegate del = delegate(MyDelegate2[] dels)
            {
                int sum = 0;
                for (int i = 0; i < dels.Length; i++)
                {
                    sum += dels[i]();
                    MyDelegate2 d = dels[i];
                }
                return sum / delegates.Length;
            };

            int result = del(delegates);
            Console.WriteLine("Arifmetic average:" + result);
            Console.ReadKey();
        }
    }

    static class MyMethods
    {
        public static int Method1()
        {
            int val;
            Random rand = new Random();
            val = rand.Next(10) + 1;
            Console.WriteLine(val);
            return val;
        }

        public static int Method2()
        {
            int val;
            Random rand = new Random();
            val = rand.Next(20) + 1;
            Console.WriteLine(val);
            return val;
        }

        public static int Method3()
        {
            int val;
            Random rand = new Random();
            val = rand.Next(30) + 1;
            Console.WriteLine(val);
            return val;
        }
    }
}
