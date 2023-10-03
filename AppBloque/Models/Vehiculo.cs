using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBloque.Models
{
    public class Vehiculo
    {
        // Atributos

        // Id del vehiculo
        public int Id { get; set; }
        public double Capacidad { get; set; }
        public long LatitudOrigenCondicionalInicial { get; set; }
        public long LongitudOrigenCondicionalInicial { get; set; }
        public DateTime FechaDisponible { get; set; }

        public List<Asignacion> ListaAsigaciones { get; set; }


        public Vehiculo() { }

        public Vehiculo(int id, double capacidad, long latitudOrigenCondicionalInicial, long longitudOrigenCondicionalInicial, DateTime fechaDisponible)
        {
            Id = id;
            Capacidad = capacidad;
            LatitudOrigenCondicionalInicial = latitudOrigenCondicionalInicial;
            LongitudOrigenCondicionalInicial = longitudOrigenCondicionalInicial;
            FechaDisponible = fechaDisponible;
        }
    }
}
