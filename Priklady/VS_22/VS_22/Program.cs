public class Prgram
{
    static int cislo = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine("PUVDNI: " + cislo);
        Thread t1 = new Thread(()=>
        {
            int temp = cislo;
            temp++;
            Thread.Sleep(1000);
            cislo = temp;
            Console.WriteLine("Pricetlo, cislo ted: " + cislo);
        });
        Thread t2 = new Thread(() =>
        {
            int temp = cislo;
            temp--;
            Thread.Sleep(1000);
            cislo = temp;
            Console.WriteLine("Odecetlo, cislo ted: " + cislo);
        });

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("AHA: " + cislo);

    }

}
