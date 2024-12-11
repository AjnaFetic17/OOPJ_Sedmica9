internal class Program
{
    public class Kalkulator
    {
        public static TResult Izracunaj<T1, T2, TResult>(T1 broj1, T2 broj2, Func<T1,T2,TResult> operacija)
        {
            return operacija(broj1, broj2);
        }
    }
    static int Saberi(int x, int y)
    {
        return x + y;
    }

    static double Pomnozi(double x, int y)
    {
        return x * y;
    }
    static void IspisiPoruku(Action<string> ispis) {
        ispis("Hello");
    }

    private static void Main(string[] args)
    {
        int rezultatSabiranja = Kalkulator.Izracunaj(5,3,Saberi);
        double rezultatMnozenja = Kalkulator.Izracunaj(6.25,5, Pomnozi);
        Console.WriteLine(rezultatSabiranja);
        Console.WriteLine(rezultatMnozenja);
        Action<string> ispis = Console.WriteLine;
        IspisiPoruku(ispis);
    }
}