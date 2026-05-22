using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("MENU DE EJERCICIOS");
        Console.WriteLine("1. Estadisticas de 20 numeros");
        Console.WriteLine("2. Numeros del 1 al 100");
        Console.WriteLine("3. Tienda (10 clientes)");
        Console.WriteLine("4. Menu de opciones con N");
        Console.WriteLine("5. Triangulo de asteriscos");
        Console.Write("Seleccione una opcion: ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            // Ejercicio 1
            double mayor = -1000000;
            double menor = 1000000;
            double suma = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese numero " + i + ": ");
                double num = double.Parse(Console.ReadLine());

                if (num > mayor) { mayor = num; }
                if (num < menor) { menor = num; }
                suma = suma + num; 
            }
            Console.WriteLine("Numero mayor: " + mayor);
            Console.WriteLine("Numero menor: " + menor);
            Console.WriteLine("Promedio: " + (suma / 20));
        }
        else if (opcion == "2")
        {
         // Ejercicio 2
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i + " - ParSiete"); 
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Par"); 
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine(i + " - Siete"); 
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else if (opcion == "3")
        {
            // Ejercicio 3
            double ventasTotales = 0;
            int totalConDescuento = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Monto del cliente " + i + ": ");
                double monto = double.Parse(Console.ReadLine());
                double desc = 0;

                if (monto > 700)
                {
                    desc = monto * 0.12;
                    totalConDescuento = totalConDescuento + 1;
                }
                else if (monto > 300)
                {
                    desc = monto * 0.05;
                    totalConDescuento = totalConDescuento + 1;
                }

                double pagoFinal = monto - desc;
                ventasTotales = ventasTotales + pagoFinal; 
                Console.WriteLine("Total pagado por el cliente: " + pagoFinal); 
            }
            Console.WriteLine("Clientes con descuento: " + totalConDescuento); 
            Console.WriteLine("Ventas totales del dia: " + ventasTotales);
        }
        else if (opcion == "4")
        {
          // Ejercicio 4
            Console.Write("Ingrese un numero entero: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1. De N hasta 1");
            Console.WriteLine("2. Multiplos de 3");
            Console.WriteLine("3. Multiplos de 5");
            string sel = Console.ReadLine();

            if (sel == "1")
            {
                for (int i = n; i >= 1; i--) { Console.Write(i + " "); }
            }
            else if (sel == "2")
            {
                for (int i = 1; i <= n; i++) { if (i % 3 == 0) { Console.Write(i + " "); } }
            }
            else if (sel == "3")
            {
                for (int i = 1; i <= n; i++) { if (i % 5 == 0) { Console.Write(i + " "); } }
            }
        }
        else if (opcion == "5")
        {
         // Ejercicio 5:
            Console.Write("Ingrese numero de filas: ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}