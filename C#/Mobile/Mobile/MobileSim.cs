using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class MobileSim
    {
        int Battery;
        string brand, model;
        public MobileSim(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            this.Battery = 0;
        }
        public void makeCall(string monum)
        {
            Console.WriteLine("Calling " + monum);
        }
        public void chargeBattery(int percent)
        {
            if (this.Battery + percent <= 100 && this.Battery + percent >= 0)
            {
                this.Battery += percent;
                Console.WriteLine("Battery used upto : " + this.Battery + "%");
            }
            else if (this.Battery + percent > 100)
            {
                this.Battery = 100;
                Console.WriteLine("Battery Fully charged, excess not used.");
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
        public void useBattery(int percent)
        {
            if (this.Battery - percent <= 100 && this.Battery - percent >= 0)
            {
                this.Battery -= percent;
                Console.WriteLine("Battery used, Current charge : " + this.Battery + "%");
            }
            else if (this.Battery - percent < 0)
            {
                this.Battery = 0;
                Console.WriteLine("this.Battery Fully discharged");
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
        public void printDetails()
        {
            Console.WriteLine("Details:\nBrand : " + this.brand + "\nModel : " + this.model + "\nBattery Percentage : " + this.Battery);
        }

    }
}
