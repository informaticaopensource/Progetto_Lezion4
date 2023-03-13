using System;

namespace Progetto_Lezion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ns = 0;
            String x, y, z,w;
            DateTime d;

            Console.WriteLine("Quant studenti ?");
            ns = Convert.ToInt32(Console.ReadLine());
            Classe cl = new Classe(ns);

            int k;
            for (k=0;k<ns;k++)
            {
                Console.WriteLine("Inserisci cognome:");
                x = Console.ReadLine();
                Console.WriteLine("Inserisci nome:");
                y = Console.ReadLine();
                Console.WriteLine("Inserisci data di nascita: ");
                d = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Inserisci Luogo di nascita:");
                z = Console.ReadLine();
                Console.WriteLine("La provincia di nascita:");
                w = Console.ReadLine();
                Studente st = new Studente(x, y, d, z, w);
                cl.Aggiungi(st);

            }
           cl.Stampa();

        }
    }
}
