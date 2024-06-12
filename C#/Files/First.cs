namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two nOs : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum : "+ (a + b));
            double mu = a;
            a = (int)mu;
            Console.WriteLine("Double : " + mu +" Int : "+a);
            
            }
    }
}
