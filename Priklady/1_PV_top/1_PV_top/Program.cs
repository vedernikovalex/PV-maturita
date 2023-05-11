public class Pameti
{
    public static void Main(string[] args)
    {
        unsafe
        {
        //POINTER
            int a = 2;

            int* pointer_a;

            pointer_a = &a;
            Console.WriteLine("int value: "+a);
            Console.WriteLine("Pointer address: "+(int)pointer_a);
            Console.WriteLine("Pointer value: " + *pointer_a);
            
            a = 3;
            Console.WriteLine("int value: " + a);
            Console.WriteLine("Pointer address: " + (int)pointer_a);
            Console.WriteLine("Pointer value: " + *pointer_a);

        //REFERENCE

            int b = 4;
            // promena C si pouze skopiruje hodnotu promeny B v dany moment
            int c = b;
            Console.WriteLine(b);
            Console.WriteLine(c);

            // pri zmene hodnoty B se hodnota C nezmeni - byla to pouze kopie v nejakym momentu
            b = 5;
            Console.WriteLine(b);
            Console.WriteLine(c);

            //OPRAVDOVA REFERENCE
            ref int realC = ref b;
            b = 6;
            Console.WriteLine(b);
            Console.WriteLine(realC);
        }

    // HEAP vs STACK

        //cena se ulozi do stack - stack obsahuje "cena" + "200"
        int cena = 200;

        //auto se ulozi do heap spolu s jeho hodnotami
            // do stack se ulozi adresa ktera odkazuje na objekt v heapu
        // heap obsahuje "Auto" - "Auto.cena" + "Auto.CenaZaRok (puvodni_cena)"
        Auto auto = new Auto(cena);

        // vytvori se promena "auto2" na stack ktera bude obsahovat adresu na "AUTO" v heap (kopie "auto")
        Auto auto2 = auto;

        //ulozeni intu v HEAP
        int myInt = 40;
        object boxedInt = myInt;

        //SPRAVA PAMETI


        int z = 20;

        GC.Collect(z);
        Console.WriteLine(z);

    }
    public class Auto
    {
        public int cena;
        public Auto(int cena)
        {
            this.cena = cena;
        }

        public int CenaZaRok()
        {
            int puvodni_cena = this.cena;
            return puvodni_cena - 100;
        }
    }

    
}