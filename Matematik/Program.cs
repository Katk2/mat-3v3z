using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej verden");


            Eksponentiel_udvikling f = new Eksponentiel_udvikling(4, 2, 2);
            Console.WriteLine("Fordoblingstid " + " " + f.BestemFordoblingstid());
            Console.ReadLine();

            Console.WriteLine("Halveringstid" + " " + f.BestemHalveringstid());
            Console.ReadLine();


            Console.WriteLine("Funktionsværdi " + f.Funktionsværdi(5));
            Console.ReadLine();

            Console.WriteLine(f.ForskriftUdFraToPunkter());
            Console.ReadLine();
        }
    }
}
