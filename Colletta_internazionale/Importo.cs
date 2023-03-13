using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta_internazionale
{
    internal class Importo : IEquatable<Importo>, IComparable<Importo>
    {
        private double _valore;
        private string _valuta;

        private string[] Valute_usabili = new string[5] { "$", "£", "€", "RUB", "¥" };

        public double Valore
        {
            get { return _valore; }
            private set
            {
                if (value < 0)
                    throw new Exception("Valore invalido");
                else
                    _valore = value;
            }
        }
        public string Valuta
        {
            get { return _valuta; }
            private set 
            {
                if (value == null || value.Length == 0 )
                    throw new Exception("Valuta invalida");
                if(CheckValuta(value))
                    _valuta = value;
                else
                    throw new Exception("Valuta invalida");
            }
        }
#pragma warning disable CS8618
        public Importo(double importo, string valuta)
#pragma warning restore CS8618
        {
            Valore = importo;
            Valuta = valuta;
        }
        private bool CheckValuta(string str)
        {
            int c = Valute_usabili.Length;
            for(int a = 0; a < c; c++)
            {
                if(Valute_usabili[a] == str)
                    return true;
                else { }
            }
            return false;
        }

        public bool Equals(Importo i)
        {
            if (i == null)
                return false;
            else if (this == i)
                return true;
            else if (Valore == i.Valore)
                return true;
            else 
                return false;
        }
        public override int GetHashCode()
        {
            return (Valuta, Valore).GetHashCode();
        }
        public int CompareTo(Importo p)
        {
            if (p == null)
                return 1;
            else
                if (Valuta == p.Valuta)
                return Valore.CompareTo(p.Valore);
            else return 1;
        }
    }
}
