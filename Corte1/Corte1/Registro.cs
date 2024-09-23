using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    internal class Registro
    {
        private List<Persona> personas;
        private const int MaxPersonas = 31;

        public Registro()
        {
            personas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            if (personas.Count < MaxPersonas)
                personas.Add(persona);
            else
                Console.WriteLine("No se puede agregar mas personas, el registro esta lleno.");
        }

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

    }
}
