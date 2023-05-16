using System;
namespace Hovinko
{
    class Program
    {
        public delegate int Calculation(int a, int b);


        public static void Main(string[] args)
        {


            Program.spratek(Program.Add);
        }

        public static int Add(int a)
        {
            return a; 
        }

        public static void spratek(Calculation callback)
        {

            callback(5, 6);
        }

    }

 
}
