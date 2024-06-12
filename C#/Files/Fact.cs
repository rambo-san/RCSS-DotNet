namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num : ");
            int fact=1;
            int a = int.Parse(Console.ReadLine());
            if(a==0)
                Console.WriteLine(1);
            else{
                while(a!=0)
                        fact*=a--;
            
            }
            Console.WriteLine("Fact is" + fact);
            
        }
    }
}
