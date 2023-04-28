using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Authentication.ExtendedProtection;

namespace Priklady
{
    class Program
    {
        static void Main(string[] args)
        {
            /// OUT OF RANGE EXCEPTION
            string[] zaci;
            zaci = new string[] { "Pavel", "Martin", "Ondra" };

            try
            {
                Console.WriteLine(zaci[3]);
                // vyhodilo by to chybu protoze zak v indexu 3 neexistuije
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Takovy zak neexistuje");
            }


            /// FILE NOT FOUND EXCEPTION
            string soubor = "soubor.txt";
            try
            {
                string obsahSouboru = File.ReadAllText(soubor);
                // vyhodi chybu protoze soubor neexistuje
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Soubor neexistuje!");
            }


            /// DIVIDE BY ZERO EXCEPTION
            int Division(int a, int b)
            {
                return a / b;
            }

            try
            {
                Console.WriteLine(Division(4, 0));
                // vyhodi chybu - nelze delit nulou
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Deleni nulou!");
            }


            /// VYVEDENI VYJIMKY NA VYSSI UROVEN
            /// 
            void Programek()
            {
                try
                {
                    UhadniSlovo("pavel");
                }
                catch(InvalidDataException e)
                {
                    Console.WriteLine("WRONG");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            void UhadniSlovo(string slovo)
            {
                if (slovo == "pavel")
                {
                    throw new InvalidDataException();
                }
                else
                {
                    Console.WriteLine($"{slovo}");
                }
            }

            Programek();


            /// ASERCE
            /// 

            int a = 0;
            a = a + 0;

            Debug.Assert(a > 0, "A musi byt vetsi jak 0");
            Console.WriteLine("A: "+a);
        }
    }
}