using System;

class Program
{
    static void Main()
    {
        // Desafío # 1: Estructuras Selectivas (Else if) 
        int numero;
        Console.WriteLine("Ingrese un número:");
        numero = int.Parse(Console.ReadLine());
        if (numero == 0)
        {
            Console.WriteLine("El número es cero.");
        }
        else if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else
        {
            Console.WriteLine("El número es negativo.");
        }

        // DESAFÍO 2: Año Bisiesto
        int anio;
        Console.Write("Escribe un año y te diremos si es bisiesto: ");
        anio = int.Parse(Console.ReadLine());

        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine("Si, el año " + anio + " es bisiesto.");
        }
        else
        {
            Console.WriteLine("No, el año " + anio + " no es bisiesto.");
        }
        // DESAFÍO 3: Boleto de Ornato
        double ingresoMensual;
        bool multa;
        double totalAPagar = 0;

        Console.WriteLine("Conoce tu Boleto de Ornato");

        Console.Write("Ingrese su ingreso mensual: ");
        ingresoMensual = double.Parse(Console.ReadLine());

        Console.Write("¿El pago tiene multa? (escriba 'true' para sí, o 'false' para no): ");
        multa = bool.Parse(Console.ReadLine());

        if (ingresoMensual >= 500.01 && ingresoMensual <= 1000.00)
        {
            totalAPagar = 10.00;
        }
        else if (ingresoMensual >= 1000.01 && ingresoMensual <= 3000.00)
        {
            totalAPagar = 15.00;
        }
        else if (ingresoMensual >= 3000.01 && ingresoMensual <= 6000.00)
        {
            totalAPagar = 50.00;
        }
        else if (ingresoMensual >= 6000.01 && ingresoMensual <= 9000.00)
        {
            totalAPagar = 75.00;
        }
        else if (ingresoMensual >= 9000.01 && ingresoMensual <= 12000.00)
        {
            totalAPagar = 100.00;
        }
        else if (ingresoMensual >= 12000.01)
        {
            totalAPagar = 150.00;
        }
        else
        {
            Console.WriteLine("Su ingreso no aplica para el pago de este arbitrio.");
        }

        if (multa == true)
        {
            totalAPagar = totalAPagar * 2;
        }

        if (totalAPagar > 0)
        {
            Console.WriteLine("\nLa cantidad que contribuirá al ornato de la ciudad es de: Q" + totalAPagar);
        }
        //Desafío #4: Estructuras selectivas & Operadores aritméticos
        int horas;
        int totalParqueo;
        int montoIngresado;
        int cambio;
        Console.WriteLine("Máquina de Pago de Parqueo");
        Console.Write("Ingrese la cantidad de horas que uso el estacionamiento: ");
        horas = int.Parse(Console.ReadLine());
        totalParqueo = horas * 10;
        Console.WriteLine("Total a pagar: Q" + totalParqueo);
        Console.Write("Ingrese el monto con el que realizará el pago (solo números enteros): Q");
        montoIngresado = int.Parse(Console.ReadLine());
        if (montoIngresado < totalParqueo)
        {
            Console.WriteLine("Error, los fondos no son suficientes.");
        }
        else if (montoIngresado == totalParqueo)
        {
            Console.WriteLine("No se requiere cambio, ¡Feliz día!");
        }
        else
        {
            cambio = montoIngresado - totalParqueo;
            Console.WriteLine("Cambio -> Q" + cambio);
            int billetes100 = cambio / 100;
            cambio = cambio % 100;
            int billetes50 = cambio / 50;
            cambio = cambio % 50;
            int billetes20 = cambio / 20;
            cambio = cambio % 20;
            int billetes10 = cambio / 10;
            cambio = cambio % 10;
            int billetes5 = cambio / 5;
            cambio = cambio % 5;
            int billetes1 = cambio / 1;
            Console.WriteLine("Billetes de Q100: " + billetes100);
            Console.WriteLine("Billetes de Q50: " + billetes50);
            Console.WriteLine("Billetes de Q20: " + billetes20);
            Console.WriteLine("Billetes de Q10: " + billetes10);
            Console.WriteLine("Billetes de Q5: " + billetes5);
            Console.WriteLine("Billetes de Q1: " + billetes1);
        }
    }
    
}