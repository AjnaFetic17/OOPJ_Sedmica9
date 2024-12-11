internal class Program
{
    public delegate T[] UvDelegat<T>(T[] x);
    public delegate dynamic[] UvDelegat2<T>(T[] x);

    static T[] Uvecaj<T>(T[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            dynamic temp = x[i];
            x[i] = temp + 1;
        }

        return x;
    }

    static dynamic[] Nacin2<T>(T[] x)
    {
        dynamic[] niz = new dynamic[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            dynamic temp = x[i];
            niz[i] = temp + 1;
        }

        return niz;
    }
    private static void Main(string[] args)
    {
        //Kreiraj genericki delegator koji prima niz tip T i vraca novi niz sa svakim elementom uvecanim za 1
        //testirati delegator sa nizom tipa int
        //dynamic[] niz = new dynamic[duzinaNiza]
        UvDelegat<int> delegat = Uvecaj;

        int[] x = { 1, 2, 3 };
        int[] y = delegat(x);

        for (int i = 0; i < y.Length; i++)
        {
            Console.WriteLine(y[i]);
        }

        UvDelegat2<int> delegat2 = Nacin2;
        var y2 = delegat2(x);
        for (int i = 0; i < y2.Length; i++)
        {
            Console.WriteLine(y2[i]);
        }
    }
}