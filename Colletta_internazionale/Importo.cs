using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta_internazionale
{
    internal class Importo
    {
        private double _valore;
        private string _valuta;

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
                if (value == null || value.Length == 0)
                    throw new Exception("Valuta invalida");
                else _valuta = value;
            }
        }
#pragma warning disable CS8618
        public Importo(double importo, string valuta)
#pragma warning restore CS8618
        {
            Valore = importo;
            Valuta = valuta;
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
    }
}
