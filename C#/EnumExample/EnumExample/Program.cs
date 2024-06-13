namespace EnumExample
{
    internal class Program
    {
        public enum Days
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        }
        static void Main(string[] args)
        {
            Days d= Days.Sunday;
            switch (d)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    break;
            }
        }
    }
}
