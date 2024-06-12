    namespace Second
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Console.WriteLine("Enter two nOs : ");
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //Console.WriteLine("Sum : "+ (a + b));
                //double mu = a;
                //a = (int)mu;
                //Console.WriteLine("Double : " + mu +" Int : "+a);

                //Console.WriteLine("Enter a Number :");
                //int num=int.Parse(Console.ReadLine());
                //if (num % 2 == 0)
                //    Console.WriteLine("Num is even.");
                //else
                //    Console.WriteLine("Num is odd.");

                Console.WriteLine("Enter NUM [1-7]");
                int w=int.Parse(Console.ReadLine());
                switch (w)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid Day");
                        break;
                }
                }
        }
    }
