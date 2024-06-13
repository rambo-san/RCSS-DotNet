using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public class FeaturePhone : Mobile
    {
        int buttonCount;
        public FeaturePhone(string brand, string model, int buttonCount) : base(brand, model) { 
            this.buttonCount = buttonCount;
        }
        override
        public void StartDevice()
        {
            Console.WriteLine("Device turned onn");
        }
        override
        public void UseDevice(int amt)
        {
            base.Battery-=amt;
            Console.WriteLine("Device Being used");
        }
        public new void showDetails()
        {
            Console.WriteLine("Details:\nBrand : " + this.brand + "\nModel : " + this.model + "Button Count : " + this.buttonCount + "\nBattery Percentage : " + this.Battery);
        }
    }
}
