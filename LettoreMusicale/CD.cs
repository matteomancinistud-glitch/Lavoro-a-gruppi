using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreMusicale
{
    class CD
    {
        private string _Titolo;
        private string _Autore;
        private List<string> _ListaBrani;
        private int _Durata;

        public CD(string titolo, string autore, List<string> listaBrani, int durata)
        {
            _Titolo = titolo;
            _Autore = autore;
            _ListaBrani = listaBrani;
            _Durata = durata;
            
        }

        public string Titolo 
        {  get { return _Titolo; }
           set { _Titolo = value;}
        }
        public string Autore
        {
            get { return _Autore; }
            set { _Autore = value; }
        }

        public int Durata 
        {
            get { return _Durata; }
            set { _Durata = value; }
        }

        public int SommaDurata(int durata) 
        {
            _Durata += durata;
            return _Durata;
        }

        public List<string> toString() 
        {
            string specificheBrano;

            specificheBrano = "Titolo brano: " + Titolo +" Autore del brano"+ Autore;

            _ListaBrani.Add(specificheBrano);
            
            return _ListaBrani;
        }


    }
}