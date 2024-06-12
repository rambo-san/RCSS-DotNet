namespace Mobile
{
    namespace Mobile
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string monum;
                Android m1 = new Android("14.05","Samsung", "S24");
                Console.WriteLine("Enter the mobile number to call : ");
                monum = Console.ReadLine();
                m1.makeCall(monum);
                m1.chargeBattery(75);
                m1.useBattery(20);
                m1.printDetails();
                m1.takePhoto();
                m1.getLocation();
            }
        }
    }

}
