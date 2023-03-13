using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto_Lezion4
{
    class Studente 
    {
        private string cognome;
        private string nome;
        private DateTime data_nascita;
        private string luogo_nascita;
        private string prov_nascita;
        public Studente(string _cg, string _n, DateTime _dn, string _ln, string _pn)
        {
            cognome = _cg;
            nome = _n;
            data_nascita = _dn;
            luogo_nascita = _ln;
            prov_nascita = _pn;
        }
        public string _cognome
        {
            get { return cognome; }
            set { cognome = value; }
            
        }
        public string _nome
        {
            get { return nome; }
            set { nome = value; }

        }
        public DateTime _datan
        {
            get { return data_nascita; }
            set { data_nascita = value; }

        }
        public string _luogon
        {
            get { return luogo_nascita; }
            set { luogo_nascita = value; }

        }
        public string _provn
        {
            get { return prov_nascita; }
            set { prov_nascita = value; }

        }

        public string ToString()
        {
            string temp="";
            temp = "\nDati dello Studente:\n";
            temp = temp+"Nome:" + nome + "\n";
            temp = temp+"Cognome:" + cognome + "\n";
            temp = temp+"Data di Nascita:" + data_nascita + "\n";
            temp = temp+"Luogo di Nascita:" + luogo_nascita + "\n";
            temp = temp+"Provincia di Nascita:" + prov_nascita + "\n";
            return temp;
        }
    }
   
}
