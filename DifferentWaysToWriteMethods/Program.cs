using System;

namespace DifferentWaysToWriteMethods
{  public abstract class Wish
    {
        abstract public void SayMorning();
    }
   public class Program:Wish
    {
        public  override void SayMorning()//abstract method
        {
            Console.WriteLine("Good Morning");
        }
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
            Console.WriteLine(r);//30
            p.Greet();//hello interns
            Wish w = new Program();
            w.SayMorning();//good morning
            
        }
    }
}
