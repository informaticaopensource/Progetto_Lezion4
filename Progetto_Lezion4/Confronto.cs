using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Progetto_Lezion4
{
    public class Confronto : IComparer
    {
        public int Compare(Object x, Object y)
            {
            Studente s1;
            Studente s2;
            s1 = (Studente)x;
            s2 = (Studente)y;
            string t1 = s1._cognome;
            string t2 = s2._cognome;
            if (String.Compare(t1, t2)==-1)
                return -1;
            if (String.Compare(t1,t2)==1)
                return 1;
            else
                return 0;
            }

    }
}
