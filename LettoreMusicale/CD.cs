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

        public CD(string titolo, string autore, List<string> listaBrani)
        {
            _Titolo = titolo;
            _Autore = autore;
            _ListaBrani = listaBrani;
        }

        public string GetTitolo()
        {
            return _Titolo;
        }

        public string GetAutore()
        {
            return _Autore;
        }

        public void SetTitolo(string titolo) 
        {
            _Titolo = titolo;
        }

        public void SetAutore(string autore) 
        {
            _Autore = autore;
        }

        public override string ToString() 
        {
            
        }
    }
}