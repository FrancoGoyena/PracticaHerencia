using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.CasoPasajero
{
    public class Pasajero_Nacional : Pasajero
    {
        public Pasajero_Nacional(string nombre, string apellido, string dni) : base(nombre,apellido)
        {
            DNI = dni;
        }
        public string DNI { get; set; }
    }
}
