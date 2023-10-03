using AppBloque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBloque.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public double CalcularMedia(List<Viaje> listaViajes)
        {
            double media = 0, suma = 0;
            foreach(Viaje viaje in listaViajes) 
            {
                suma = suma + viaje.Costo;
            }
            if (listaViajes.Count > 0) 
            {
                media = suma / listaViajes.Count;
            }

            return media;

        }
    }
}
