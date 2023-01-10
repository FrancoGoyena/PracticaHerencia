using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.CasoPasajero
{
    public class Pasajero_extranjero:Pasajero
    {
        public Pasajero_extranjero(string nombre, string apellido, string pasaporte) : base(nombre,apellido)
        {
            Pasaporte = Pasaporte;
        }
        public string Pasaporte { get; set; }
    }
}
