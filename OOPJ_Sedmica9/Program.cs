internal class Program
{
    delegate double Kalkulator(double x, double y);

    delegate void Multicast_Del(int x, int y);

    static double Saberi(double x, double y)
    {
        return x + y;
    }

    static double Pomnozi(double x, double y)
    {
        return x * y;
    }

    static void Metoda1(int x, int y)
    {
        Console.WriteLine("Metoda 1");
        Console.WriteLine("Suma je {0}", x+y);
    }

    static void Metoda2(int x, int y)
    {
        Console.WriteLine("Metoda 2");
        Console.WriteLine("Proizvod je {0}", x * y);
    }

    private static void Main(string[] args)
    {
        Kalkulator kalkulatorSabetri = Saberi;
        Kalkulator kalkulatorPomnozi = new(Pomnozi);

        double rezutatSaberi = kalkulatorSabetri(2, 3);
        double rezultatPomnozi = kalkulatorPomnozi(2, 9);

        Console.WriteLine(rezutatSaberi);
        Console.WriteLine(rezultatPomnozi);

        Multicast_Del dMulti = Metoda1;
        dMulti += Metoda2;
        dMulti.Invoke(2,3);
        dMulti -= Metoda1;
        dMulti -= Metoda2;
    }
}