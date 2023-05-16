using System;

class Program
{
    public static void Main(string[] args)
    {
        Pes pes = new Pes();
        Slepice slepice = new Slepice();

        Zvire[] zvirata = new Zvire[2];

        zvirata[0] = pes;
        zvirata[1] = slepice;

        foreach (var zviratko in zvirata)
        {
            zviratko.Action();
        }

        pes.PocetJidel(2);
        pes.PocetJidel(4, "svickova");
    }
}

public class Zvire
{
    public int pocet_nohou;
    public virtual void Action()
    {
        Console.WriteLine("Generic Zvire");
    }
}

public class Slepice : Zvire
{
    public int pocet_kridel;
    public override void Action()
    {
        Console.WriteLine("Kvak");
    }
}

public class Pes : Zvire
{
    public string plemeno;
    public override void Action()
    {
        Console.WriteLine("Haf");
    }

    public void PocetJidel(int pocet)
    {
        Console.WriteLine("Jim denne jidel: " + pocet);
    }
    public void PocetJidel(int pocet, string jidlo)
    {
        Console.WriteLine("Jim denne " + jidlo + " " + pocet + " krat");
    }

}
