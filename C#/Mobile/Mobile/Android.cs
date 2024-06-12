using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Android : MobileSim, iCamera, iLocation
    {
        string andVersion;
        public Android(string andVersion, string brand, string model):base(brand, model) { 
            this.andVersion = andVersion;
        }
        public void printDetails()
        {
            base.printDetails();
            System.Console.WriteLine("Android Version : "+andVersion);
        }
        public void takePhoto()
        {
            Console.WriteLine("Now I know how you look...");
        }
        public void getLocation()
        {
            Console.WriteLine("Location Revealed....I am comming for you");
        }
    }
}
