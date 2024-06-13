using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public class Smartphone : Mobile
    {
        string osVersion;
        public Smartphone(string brand, string model, string osVersion) : base(brand, model) { 
        this.osVersion = osVersion;
        }
        override
        public void StartDevice()
        {
            Console.WriteLine("Device turned onn");
        }
        override
        public void UseDevice(int amt)
        {
            Console.WriteLine("Device Being used");
            base.Battery -= amt;
        }
        public new void showDetails()
        {
            Console.WriteLine("Details:\nBrand : " + this.brand + "\nModel : " + this.model + "OS version : " +this.osVersion + "\nBattery Percentage : " + this.Battery);
        }
    }
}
