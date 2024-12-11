internal class Program
{
    delegate T Kvadrat<T>(T x);

    static T Kvadriraj<T>(T x)
    {
        dynamic dx = x;
        return dx * dx;
    }
    private static void Main(string[] args)
    {
        //Kreirati genericki delegator koji prima jedan broj tipa T i vraca njegov kvadrat
        //testirati delegator sa tipom int
        Kvadrat<int> kvadrat = Kvadriraj;
        Console.WriteLine(kvadrat.Invoke(5));
    }
}