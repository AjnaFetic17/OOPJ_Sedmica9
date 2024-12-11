internal class Program
{
    delegate void Provjera(int x);
    
    static void Parnost(int x)
    {
        Console.WriteLine((x % 2 == 0) ? $"Broj {x} je paran" : $"Broj {x} je neparan");
    }
    private static void Main(string[] args)
    {
        //Kreirati delegat koji prima jedan broj tipa int i ispisuje da li je taj broj paran ili ne. Pozvati delegat za broj 7
        Provjera provjera = Parnost;
        provjera(7);
        provjera(4);
    }
}