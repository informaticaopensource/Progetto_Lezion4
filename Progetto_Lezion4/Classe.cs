using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Progetto_Lezion4
{
    class Classe
    {
        private List<Studente> Lista;
        private int nstudenti;
        public Classe(int x)
        {
            nstudenti = x;
            Lista = new List<Studente>();
        }

        public void Aggiungi(Studente st)
        {
            Lista.Add(st);
        }
        public void Rimuovi(int k)
        {
            Lista.RemoveAt(k);
        }
        public void Stampa()
        {
            foreach (Studente st in  Lista)
               {
                Console.WriteLine(st.ToString());

            }
        }
    }
}
