namespace AbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone sm = new Smartphone("Samsung", "S24","Android 14.02");
            FeaturePhone fm = new FeaturePhone("Samsung", "S24",25);
            sm.StartDevice();
            sm.UseDevice(25);
            sm.showDetails();
            fm.StartDevice();
            fm.UseDevice(56);
            fm.showDetails();
        }
    }
}
