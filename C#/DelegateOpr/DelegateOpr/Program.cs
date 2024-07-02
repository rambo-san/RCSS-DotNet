namespace DelegateOpr
{
    delegate int ArithOpr(int x, int y);
    delegate void Dis();
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithOpr op1 = new ArithOpr(DelegateOP.add);
            ArithOpr op2 = new ArithOpr(DelegateOP.sub);
            Dis op3 = new Dis(Multicast.disp);
            Dis op4 = new Dis(Multicast.disp1);
            Dis op5=op3+op4;
            Dis op6=op4+op5;

            int r1 = op1(1, 2);
            int r2 = op2(1, 2);
            Console.WriteLine("R1: "+r1);
            Console.WriteLine("R2: "+r2);
            op5();
            op6();

            Books b= new Books();
            b.printDet();
            b.printDet1();
            b.printDet3();
        }
    }
}
