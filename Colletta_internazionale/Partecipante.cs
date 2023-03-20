using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta_internazionale
{
    internal class Partecipante : IEquatable<Partecipante>, IComparable<Partecipante>
    {      
        private string _key;
        private string _nome;       

        public string Key
        {
            get { return _key; }
            private set {
                if (value == null)
                    throw new Exception("Chiave invalida");
                else 
                    _key = value; 
            }
        }
        public string Nome
        {
            get { return _nome; }
            private set {
                if (value == null || value.Length == 0)
                    throw new Exception("Nome invalido");
                else
                    _nome = value; 
            }
        }
#pragma warning disable CS8618
        public Partecipante(string nome)
#pragma warning restore CS8618
        {
            Key = base.GetHashCode().ToString();
            Nome = nome;         
        }

        public bool Equals(Partecipante p)
        {
            if (p == null)
                return false;
            else if (this == p)
                return true;
            else return false;
        }
        public override int GetHashCode()
        {
            return (Nome, Key).GetHashCode();
        }
        public int CompareTo(Partecipante p)
        {
            if (p == null)
                return 1;
            else
                return Nome.CompareTo(p.Nome);
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
