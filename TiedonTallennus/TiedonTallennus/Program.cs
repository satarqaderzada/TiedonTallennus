using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            Lämpötila = int.Parse(syöte);

            // tiedoston kirjoittaminen
            string tiedosto = @"C:\Temp\Lämpötila.txt";
            File.WriteAllText(tiedosto, Lämpötila.ToString());
            Console.WriteLine("uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}



