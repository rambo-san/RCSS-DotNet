using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public abstract class Mobile
    {
        protected int Battery;
        protected string brand, model;
        
        public Mobile(string brand,string model)
        {
            Battery = 100;
            this.brand = brand;
            this.model = model;
        }
        public void makeCall(string monum)
        {
            Console.WriteLine("Calling " + monum);
        }
        public abstract void UseDevice(int amt);
        public abstract void StartDevice();
        public void showDetails()
        {
            Console.WriteLine("Details:\nBrand : " + this.brand + "\nModel : " + this.model + "\nBattery Percentage : " + this.Battery);
        }

    }
}
