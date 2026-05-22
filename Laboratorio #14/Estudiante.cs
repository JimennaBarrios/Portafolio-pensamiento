using System;
using System.Collections.Generic;
using System.Text;

namespace L14_IJBM_1059026
{
    internal class Estudiante
    {
        private string nombre;
        private int edad;
        private string grado;
        private decimal[] notas;
        public Estudiante(string nombre, int edad, string grado, decimal[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }
        public decimal calcularPromedio()
        {
            decimal suma = 0;
            foreach (decimal n in notas) { suma += n; }
            return notas.Length > 0 ? suma / notas.Length : 0;
        }

        public bool aprobar()
        {
            return calcularPromedio() >= 61;
        }

        public void mostrarInformacion()
        {
            string estado = aprobar() ? "APROBADO" : "REPROBADO";
            Console.WriteLine($"Estudiante: {nombre} | Promedio: {calcularPromedio():F2} | Estado: {estado}");
        }

        public void agregarNota(decimal nuevaNota)
        {
            Array.Resize(ref notas, notas.Length + 1);
            notas[notas.Length - 1] = nuevaNota;
        }
    }
}