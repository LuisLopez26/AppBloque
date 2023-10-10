using AppBloque.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBloque.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<Viaje> lista = new List<Viaje>();
        public List<Viaje> GenerarLista(int dimension) 
        {
            List<Viaje> lista = new List<Viaje>();
            for (int i = 0; i < dimension; i++) 
            {
                Viaje viaje = new Viaje();
                viaje.Costo = i;

                lista.Add(viaje);
            }


            return lista;
        }
        public double CalcularMedia(List<Viaje> listaViajes) 
        {
            double media = 0, suma =0;
            foreach (Viaje viaje in listaViajes) 
            {
                suma = suma + viaje.Costo;
            }
            if (listaViajes.Count > 0) 
            {
                media = suma / listaViajes.Count;
            }
            
            return media;
        }

        public double AlgoritmoMedia(int totalValores) 
        {
            double media = 0;
            lista = GenerarLista(totalValores);
            media = CalcularMedia(lista);
            return media;
        }
        public List<int> AlgoritmoCongruenciaLineal(int a, int m, int c, int x0,  int totalValores)
        {
            List<int> listaSalida  = new List<int>();
            listaSalida.Add(x0);
            //for(int i=0; i<totalValores - 1; i++) 
            //{
            //int x= (a * listaSalida[i] +c) %m;
            //listaSalida.Add(x);
            //}
            int i = 0;

            do
            {
                int x = (a * listaSalida[i] + c) % m;
                listaSalida.Add(x);
                i = i + 1;
            } while (listaSalida[0] != listaSalida[i]);

            MessageBox.Show("Se detuvo el programa por repetición de ciclo.");
            //return;

            listaSalida.RemoveAt(listaSalida.Count - 1);
            return listaSalida;
        }
    }
}


