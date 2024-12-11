internal class Program
{
    delegate int VeciBroj(int a, int b);

    static int Veci(int a, int b)
    {
        if (a > b) {
            return a;
        }
        else
        {
            return b;
        }
            //return a>b ? a :b; 
    }

    private static void Main(string[] args)
    {
        //Kreirati delegat koji prima 2 broja tipa int i vraca veceg od njih
        //pozvati delegat sa brojevima 8 i 3
        VeciBroj veci = Veci;
        Console.WriteLine(veci(8,3));
    }
}