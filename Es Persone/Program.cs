using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Persone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Persone = new List<Persona>();

            Console.WriteLine("Inserisci il numero delle persone che vuoi aggiungere alla lista: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci caratteristiche persona: ");
                Persona p = Persona.Parse(Console.ReadLine());
                Persone.Add(p);
            }

            foreach(var Persona in Persone)
            {
                if (Persona.Eta >= 18)
                    Console.WriteLine(Persona.ToString());
            }

            Console.ReadLine();
        }
    }
}
