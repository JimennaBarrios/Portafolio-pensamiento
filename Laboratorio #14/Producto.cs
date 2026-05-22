using System;
using System.Collections.Generic;
using System.Text;

namespace L14_IJBM_1059026
{
    internal class Producto
    {
        private string nombre;
        private decimal precio;
        private int cantidad;
        public Producto(string nombre, decimal precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Producto: {nombre} | Precio: Q{precio} | Stock: {cantidad}");
        }

        public void vender(int cantidadVendida)
        {
            if (cantidadVendida <= cantidad)
            {
                cantidad -= cantidadVendida;
                Console.WriteLine($"Venta: {cantidadVendida} unidades de {nombre}.");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock.");
            }
        }

        public void reabastecer(int cantidadNueva)
        {
            cantidad += cantidadNueva;
            Console.WriteLine($"Reabastecimiento: +{cantidadNueva} unidades.");
        }
    }
}