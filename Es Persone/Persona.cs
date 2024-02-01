using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Persone
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public Persona() { }
        public Persona(string nome, int eta)
        {
            this.Nome = nome;
            this.Eta = eta;
        }

        public static Persona Parse(string str)
        {
            string[] caratteristiche = str.Split(',');
            string nome = caratteristiche[0];
            int eta = int.Parse(caratteristiche[1]);

            return new Persona(nome, eta);
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", Nome, Eta);
        }
    }
}
