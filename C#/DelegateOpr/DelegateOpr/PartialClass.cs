using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOpr
{
    public partial class Books
    {
        public string Author_name;
        public string Author_email;
        public void printDet()
        {
            Console.WriteLine("HA HAI HOI HOOI");
        }
    }
    public partial class Books
    {
        public void printDet1()
        {
            Console.WriteLine("HA1 HAI1 HO1I HOOI1");
        }
    }
    public partial class Books
    {
        public void printDet3()
        {
            Console.WriteLine("Main");
        }
    }
}
