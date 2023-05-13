public class Program
{
    public static void Main(string[] args)
    {
        Zvire[] arrayZvirat = new Zvire[2];
        Pes pes = new Pes();
        Kachna kachna = new Kachna();
        arrayZvirat[0] = pes;
        arrayZvirat[1] = kachna;

        foreach (var zvire in arrayZvirat)
        {
            zvire.Action();
        }
    }
}

public class Zvire
{
    int pocetNohou;
    int vek;

    public virtual void Action()
    {
        Console.WriteLine("Generic zvire");
    }
}

public class Pes : Zvire
{
    string rasa;

    public override void Action()
    {
        Console.WriteLine("Haf");
    }

    public void Prochazka()
    {
        Console.WriteLine("Ja rad chodim");
    }

    public void Prochazka(int pocetKamaradu)
    {
        Console.WriteLine("Ja rad chodim s "+pocetKamaradu+" kamaradama ven!");
    }
}

public class Kachna : Zvire
{
    string barva;

    public override void Action()
    {
        Console.WriteLine("Kvak");
    }
}