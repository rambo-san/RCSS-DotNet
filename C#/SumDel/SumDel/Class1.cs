using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SumDel
{
    internal class Th1 
    {
        public void callMe()
        {
            Console.WriteLine("In TH1");
            Thread.Sleep(1000);
            Console.WriteLine("Exiting TH1");
        }
    } 
}
