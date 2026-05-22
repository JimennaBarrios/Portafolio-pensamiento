using System;
class Program
{
    static void Main()
    {
        string opcion = "";

        while (opcion != "5")
        {
            Console.Clear();

            Console.WriteLine("====== LABORATORIO 11 ======");
            Console.WriteLine("1. Palíndromos");
            Console.WriteLine("2. Traductor");
            Console.WriteLine("3. Notas");
            Console.WriteLine("4. Planilla");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Ejercicio1();
            }
            else if (opcion == "2")
            {
                Ejercicio2();
            }
            else if (opcion == "3")
            {
                Ejercicio3();
            }
            else if (opcion == "4")
            {
                Ejercicio4();
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                Console.WriteLine("Presiona Enter para intentar de nuevo...");
                Console.ReadLine();
            }
        }
    }

    static void Ejercicio1()
    {
        Console.Clear();
        Console.WriteLine("-- Ejercicio 1: Palíndromos --\n");

        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        bool esPalindromo = true;
        int letraFinal = palabra.Length - 1;

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] != palabra[letraFinal])
            {
                esPalindromo = false;
            }
            letraFinal--;
        }

        if (esPalindromo == true)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.WriteLine("\nPresiona Enter para regresar al menú principal...");
        Console.ReadLine();
    }

    static void Ejercicio2()
    {
        Console.Clear();
        Console.WriteLine("-- Ejercicio 2: Traductor --\n");

        string[] espanol = { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] ingles = { "red", "blue", "yellow", "white", "green" };
        string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

        string op = "";
        while (op != "2")
        {
            Console.Clear();
            Console.WriteLine("1. Practicar lección\n2. Regresar al menú principal");
            Console.Write("Opción: ");
            op = Console.ReadLine();

            if (op == "1")
            {
                Console.Write("\nIngrese una palabra en español: ");
                string palabra = Console.ReadLine().ToLower();

                int posicion = -1;

                for (int i = 0; i < 5; i++)
                {
                    if (espanol[i] == palabra)
                    {
                        posicion = i;
                    }
                }

                if (posicion != -1)
                {
                    string esp = espanol[posicion].Substring(0, 1).ToUpper() + espanol[posicion].Substring(1);
                    string ing = ingles[posicion].Substring(0, 1).ToUpper() + ingles[posicion].Substring(1);
                    string ita = italiano[posicion].Substring(0, 1).ToUpper() + italiano[posicion].Substring(1);

                    Console.WriteLine("\nTraducción: " + esp + ", " + ing + ", " + ita);
                }
                else
                {
                    Console.WriteLine("\nLa palabra no corresponde a la lección actual");
                }

                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
            }
        }
    }

    static void Ejercicio3()
    {
        Console.Clear();
        Console.WriteLine("-- Ejercicio 3: Notas --\n");

        int[] notas = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            notas[i] = rnd.Next(50, 101);
        }

        string op = "";
        while (op != "3")
        {
            Console.Clear();
            Console.WriteLine("1. Reporte de rendimiento\n2. Estadísticas\n3. Regresar al menú principal");
            Console.Write("Opción: ");
            op = Console.ReadLine();

            if (op == "1")
            {
                Console.WriteLine("\nReporte de Notas:");
                for (int i = 0; i < 10; i++)
                {
                    if (notas[i] >= 50 && notas[i] <= 64)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (notas[i] >= 65 && notas[i] <= 79)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (notas[i] >= 80 && notas[i] <= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write(notas[i] + " ");
                }
                Console.ResetColor();
                Console.WriteLine("\n\nPresiona Enter para continuar...");
                Console.ReadLine();

            }
            else if (op == "2")
            {
                int max = notas[0];
                int min = notas[0];
                double suma = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (notas[i] > max)
                    {
                        max = notas[i];
                    }
                    if (notas[i] < min)
                    {
                        min = notas[i];
                    }
                    suma = suma + notas[i];
                }

                double promedio = suma / 10;
                Console.WriteLine("\nEstadísticas:");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Calificación más alta: " + max);
                Console.WriteLine("Calificación más baja: " + min);

                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
            }
        }
    }

    static void Ejercicio4()
    {
        Console.Clear();
        Console.WriteLine("-- Ejercicio 4: Planilla --\n");

        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] salario_x_hora = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
        double[] horas_laboradas = new double[6];

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Ingrese las horas laboradas por " + nombres[i] + ": ");
            horas_laboradas[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine("--- Reporte de Pagos Semanales ---\n");

        for (int i = 0; i < 6; i++)
        {
            double pagoTotal = 0;

            if (horas_laboradas[i] > 40)
            {
                double horasExtra = horas_laboradas[i] - 40;
                pagoTotal = (40 * salario_x_hora[i]) + (horasExtra * salario_x_hora[i] * 1.5);
            }
            else
            {
                pagoTotal = horas_laboradas[i] * salario_x_hora[i];
            }

            Console.WriteLine(nombres[i] + ": Q" + pagoTotal);
        }

        Console.WriteLine("\nPresiona Enter para regresar al menú principal...");
        Console.ReadLine();
    }
}