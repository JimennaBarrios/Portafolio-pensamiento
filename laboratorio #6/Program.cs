using System;

class Program
{
    static void Main()
    {
        //Problema 3
        Console.WriteLine("Ingresa tu puntuación de empleado (0.0, 0.4, o 0.6):");

        double puntuacion = double.Parse(Console.ReadLine());

        double bonoBase = 2400.0;
        string nivel = "";
        bool Valido = true;

        if (puntuacion == 0.0)
        {
            nivel = "Inaceptable";
        }
        else if (puntuacion == 0.4)
        {
            nivel = "Aceptable";
        }
        else if (puntuacion >= 0.6)
        {
            nivel = "Meritorio";
        }
        else
        {
            Valido = false;
        }

        if (Valido)
        {
            double totalRecibir = bonoBase * puntuacion;
            Console.WriteLine($"Nivel de rendimiento: {nivel}");
            Console.WriteLine($"Usted recibira un bono de: {totalRecibir} euros");
        }
        else
        {
            Console.WriteLine("Error: La puntuación ingresada no es válida, ingrese un número valido.");
        }

        //Problema 4
        Console.WriteLine("Conversiones de grados");
        Console.WriteLine("Puedes elegir cualquiera de las siguientes conversiones de grados:");
        Console.WriteLine("1. De Celsius a Fahrenheit");
        Console.WriteLine("2. De Fahrenheit a Celsius");
        Console.WriteLine("3. De Celsius a Kelvin");
        Console.Write("\nElige una opción (1-3): ");

        string opcion = Console.ReadLine();

        Console.Write("Ingresa el valor de la temperatura: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());
        double resultado = 0;

        switch (opcion)
        {
            case "1": // Celsius a Fahrenheit
                resultado = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"{temperatura}°C equivale a {resultado}°F");
                break;

            case "2": // Fahrenheit a Celsius
                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura}°F equivale a {resultado}°C");
                break;

            case "3": // Celsius a Kelvin
                resultado = temperatura + 273.15;
                Console.WriteLine($"{temperatura}°C equivale a {resultado}K");
                break;

            default:
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                break;
        }

    }
}