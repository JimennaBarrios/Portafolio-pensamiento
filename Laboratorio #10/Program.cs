using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        Console.WriteLine("Ejercicio 1: Suma de digitos");
        Console.WriteLine("Prueba con 1234: " + SumarDigitos(1234));
        Console.WriteLine("Prueba con 905: " + SumarDigitos(905));
        Console.WriteLine();

        // Ejercicio 2
        Console.WriteLine("Ejercicio 2: Correo Institucional");
        Console.WriteLine("Prueba 1: " + GenerarCorreo("Juan", "Carlos", "Morales", "Paz"));
        Console.WriteLine("Prueba 2: " + GenerarCorreo("Angelica", "Paola", "Lopez", "Santos"));
        Console.WriteLine();

        // Ejercicio 3
        Console.WriteLine("Ejercicio 3: Conversión de Temperatura");
        double fahrenheit1 = 0;
        Console.WriteLine("Prueba con c=25: " + ConvertirTemperatura("c=25", ref fahrenheit1));
        double fahrenheit2 = 0;
        Console.WriteLine("Prueba con c=0: " + ConvertirTemperatura("c=0", ref fahrenheit2));
        Console.WriteLine();

        // Ejercicio 4
        Console.WriteLine("Ejercicio 4: Sistema de Puntos");
        int puntos = 50;
        Console.WriteLine("Puntos iniciales: " + puntos);

        AgregarPuntos(ref puntos);
        Console.WriteLine("Tras agregar (+10): " + puntos + " | Nivel: " + ObtenerNivel(puntos));

        QuitarPuntos(ref puntos);
        Console.WriteLine("Tras quitar (-7): " + puntos + " | Estado: " + EvaluarEstado(puntos));
    }
    // FUNCIONES DEL EJERCICIO 1
    static int SumarDigitos(int numero)
    {
        int suma = 0;
        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }
    // FUNCIONES DEL EJERCICIO 2
    static string GenerarCorreo(string pNombre, string sNombre, string pApellido, string sApellido)
    {
        string iniciales = pNombre.Substring(0, 1).ToLower() + sNombre.Substring(0, 1).ToLower();
        string apellidos = pApellido.ToLower() + sApellido.Substring(0, 1).ToLower();

        return iniciales + apellidos + "@correo.url.edu.gt";
    }
    // FUNCIONES DEL EJERCICIO 3
    static string ConvertirTemperatura(string gradosC, ref double gradosF)
    {
        double celsius = double.Parse(gradosC.Substring(2));
        gradosF = (celsius * 9.0 / 5.0) + 32;

        return "F=" + gradosF;
    }
    // FUNCIONES DEL EJERCICIO 4
    static int AgregarPuntos(ref int puntos)
    {
        puntos += 10;
        if (puntos > 100) puntos = 100;
        return puntos;
    }

    static int QuitarPuntos(ref int puntos)
    {
        puntos -= 7;
        if (puntos < 0) puntos = 0;
        return puntos;
    }

    static string ObtenerNivel(int puntos)
    {
        if (puntos >= 80) return "Avanzado";
        if (puntos >= 50) return "Intermedio";
        return "Básico";
    }

    static string EvaluarEstado(int puntos)
    {
        if (puntos == 100) return "Excelente";
        if (puntos >= 70) return "Aprobado";
        return "Reprobado";
    }
}