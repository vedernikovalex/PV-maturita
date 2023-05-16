using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Osoba pavel = new Osoba("Pavel", 12);
        Zvire pes = new Zvire("Martin", "Mops");

        Console.WriteLine(pavel);
        Console.WriteLine(pes);

        Rasy mops = Rasy.Mops;
        Console.WriteLine(mops);
        Console.WriteLine((int)mops);
    }

    public static string VypisTridy<T>(T trida)
    {
        return trida.ToString();
    }

}

public class Osoba
{
    public string jmeno;
    public int vek;

    public Osoba(string jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
    }

    public override string? ToString()
    {
        return this.jmeno + " " + this.vek;
    }
}

public class Zvire
{
    public string jmeno;
    public string rasa;

    public Zvire(string jmeno, string rasa)
    {
        this.jmeno = jmeno;
        this.rasa = rasa;
    }

    public override string? ToString()
    {
        return this.jmeno + " " + this.rasa;
    }
}

public enum Rasy
{
    Mops = 10,
    Ovcak = 20,
    Opicak
}