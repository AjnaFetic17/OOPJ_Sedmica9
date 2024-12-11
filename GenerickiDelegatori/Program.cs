internal class Program
{
    public delegate T Kalkulator<T>(T x, T y);
    static int Saberi(int x, int y)
    {
        return x + y;
    }

    static double Pomnozi(double x, double y)
    {
        return x * y;
    }
    private static void Main(string[] args)
    {
        Kalkulator<int> kalkulatorSabiranje = Saberi;
        Console.WriteLine(kalkulatorSabiranje(3,6));

        Kalkulator<double> kalkulatorMnozenje = Pomnozi;
        Console.WriteLine(kalkulatorMnozenje(5,6));
    }
}