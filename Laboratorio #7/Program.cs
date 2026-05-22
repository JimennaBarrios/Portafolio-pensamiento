using System;

class Program
{
    static void Main()
    {
        //0. Datos personales
        string nombre = "Ingrid Jimenna Barrios Molina";
        int carnet = 1059026;
        int indice = 1;

        //1. Ejerecicio de while
        Console.WriteLine("Nombre: " + nombre + " Carnet: " + carnet.ToString());
        Console.WriteLine("---------------------------------------------------");

        while (indice <= 20)
        {
            if (indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(indice);
            Console.ForegroundColor = ConsoleColor.White;
            indice = indice + 1;
        }
        //2. Ejercicio de do-while

        Console.Write("\nIngresa un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());
        int i = 1;

        Console.WriteLine("Los divisores de " + numero + " son:");

        do
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= numero);

        Console.Write("\n¿Cuántos números de la serie quieres ver?: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        //3. Ejercicio de for
        Console.WriteLine("Serie de Fibonacci (primeros " + n + " elementos):");

        for (int j = 0; j < n; j++)
        {
            Console.Write(a + " ");
            int siguiente = a + b;
            a = b;
            b = siguiente;
        }
        Console.ReadLine();
        Console.WriteLine();

        //4. Ciclos anidados-libre
        
        for (int tabla = 1; tabla <= 12; tabla++)
        {
            Console.WriteLine("\nTabla del " + tabla);
            for (int mult = 1; mult <= 10; mult++)
            {
                Console.WriteLine(tabla + " x " + mult + " = " + (tabla * mult));
            }
        }

    }
}