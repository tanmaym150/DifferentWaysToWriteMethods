using System;

namespace DifferentWaysToWriteMethods
{
    class Program
    {
        
        static int Sum(int x,int y)//static method with parameter
        {
            int a = x;
            int b = y;

            int result = a + b;
            return result;
        }
        public void Greet()//instance method
        {
            Console.WriteLine("Hello interns..");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int r = Program.Sum(10,20);
            Console.WriteLine(r);
            p.Greet();
            
        }
    }
}
