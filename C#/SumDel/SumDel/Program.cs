using System;
namespace SumDel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Th1 t = new Th1();
            ThreadStart ts = new ThreadStart(t.callMe);
            Console.WriteLine("In main , cr child");
            Thread cT = new Thread(ts);
            cT.Start();
            Console.ReadKey();
        }
    }
}