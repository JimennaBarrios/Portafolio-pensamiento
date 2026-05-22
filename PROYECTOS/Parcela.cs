using System;
using System.Collections.Generic;
using System.Text;

namespace Granja_imj
{
    public class Parcela
    {
        public bool Ocupada;
        public Semilla CultivoActual;
        public int MesesRestantes;

        public Parcela()
        {
            Ocupada = false;
            CultivoActual = null;
            MesesRestantes = 0;
        }

        public void Sembrar(Semilla semilla)
        {
            Ocupada = true;
            CultivoActual = semilla;
            MesesRestantes = semilla.TiempoMeses;
        }

        public double AvanzarMes()
        {
            if (Ocupada)
            {
                MesesRestantes--;
                if (MesesRestantes <= 0)
                {
                    double ganancia = CultivoActual.IngresoCosecha;
                    Ocupada = false;
                    CultivoActual = null;
                    return ganancia;
                }
            }
            return 0.0;
        }
    }
}