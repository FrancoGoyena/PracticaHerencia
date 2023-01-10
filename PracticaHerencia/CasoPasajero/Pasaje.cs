using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.CasoPasajero
{
    public class Pasaje
    {
        public Pasaje(int precio, string destino)
        {
            Precio = precio;
            Destino= destino;
        }
        public int Precio { get; set; }
        public string Destino { get; set; }


    }
}
