using System;
using System.Collections.Generic;
using System.Text;

namespace Granja_imj
{
    public class Semilla
    {
        public string Nombre;
        public double Costo;
        public double IngresoCosecha;
        public int TiempoMeses;

        public Semilla(string nombre, double costo, double ingresoCosecha, int tiempoMeses)
        {
            Nombre = nombre;
            Costo = costo;
            IngresoCosecha = ingresoCosecha;
            TiempoMeses = tiempoMeses;
        }
    }
}