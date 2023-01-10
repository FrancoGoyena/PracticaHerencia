using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.CasoPasajero
{
    public abstract class Pasajero
    {
        public Pasajero(string nombre, string apellido)
        {
            Apellido = apellido;
            Nombre = nombre;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }

    
    }
}
