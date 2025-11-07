using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreMusicale
{
    /*
        * Alunno 1: sviluppare un classe brano i cui oggetti rappresentano 
        * i brani di un determinato autore. Ogni oggetto brano deve avere almeno le seguenti caratteristiche: titolo,
        * autore, durata. La classe deve avere i seguenti metodi: costruttore che ha come parametri titolo, autore e durata;
        * getTitolo, getAutore e getDurata che restituiscono i valori degli attributi relativi; setTitolo, setAutore e setDurata 
        * che modificano degli attributi relativi; toString che restituisce una stringa con tutti i dati dell'oggetto se cui è invocato; 
        * shortSong che accetta una durata e restituisce 
        * true se il brano in questione ha una durata inferiore a tale durate, false viceversa.
    */
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durata;

        public Brano(string title, string author, int duratasec)
        {
            _titolo = title;
            _autore = author;
            _durata = duratasec;
        }
        public string getTitolo()
        {
            return _titolo;
        }
        public string getAutore()
        {
            return _autore;
        }
        public int getDurata()
        {
            return _durata;
        }

        public void setTitolo(string title)
        {
            _titolo = title;
        }
        public void setAutore(string author)
        {
            _autore = author;
        }
        public void setDurata(int duratasec)
        {
            _durata = duratasec;
        }
        public string toString()
        {
            return "Titolo brano: " + _titolo + "; Autore brano: " + _autore + "; Durata in secondi: " + _durata.ToString();
        }
        public bool shortSong(int shortdurata)
        {
            if (_durata < shortdurata)
            {
                return true;
            }
            else return false;
        }
    }
}
