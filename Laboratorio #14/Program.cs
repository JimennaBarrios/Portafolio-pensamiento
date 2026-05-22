using System;

namespace L14_IJBM_1059026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("LABORATORIO #14");
            Console.ResetColor();
            Console.WriteLine("\n--- CUENTAS BANCARIAS ---");
            CuentaBancaria c1 = new CuentaBancaria("Jimenna Barrios", "1059026", 1000);
            c1.mostrarInformacion();
            c1.depositar(500);
            c1.retirar(200);
            c1.mostrarInformacion();
            Console.WriteLine("\n--- PRODUCTOS ---");
            Producto p1 = new Producto("Laptop", 7000, 10);
            p1.mostrarInformacion();
            p1.vender(3);
            p1.reabastecer(5);
            p1.mostrarInformacion();
            Console.WriteLine("\n--- ESTUDIANTES ---");
            decimal[] notasIniciales = { 70, 85, 90 };
            Estudiante e1 = new Estudiante("Jimenna Barrios", 18, "Ingeniería", notasIniciales);
            e1.mostrarInformacion();
            e1.agregarNota(95);
            e1.mostrarInformacion();
            Console.ReadKey();
        }
    }
}