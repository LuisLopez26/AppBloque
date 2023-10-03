using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBloque.Models
{
    public class Asignacion
    {
        public string IdOrigen { get; set; }
        public string IdDestino { get; set; }
        public long LatitudOrigen { get; set; }
        public long LongitudOrigen { get; set; }
        public long LatitudDestino { get; set; }
        public long LongitudDestino { get; set; }
        public double CantidadCubierta { get; set; }
        public Asignacion() { }
        public Asignacion(string idOrigen, string idDestino, long latitudOrigen, long longitudOrigen, long latitudDestino, long longitudDestino, double cantidadCubierta)
        {
            IdOrigen = idOrigen;
            IdDestino = idDestino;
            LatitudOrigen = latitudOrigen;
            LongitudOrigen = longitudOrigen;
            LatitudDestino = latitudDestino;
            LongitudDestino = longitudDestino;
            CantidadCubierta = cantidadCubierta;
        }
    }
}
