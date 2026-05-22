using System;

namespace DebuggingLab15
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital = 1000;
            double tasa = 0.05;
            double intereses = 0;
            double abonos = 0;

            for (int mes = 1; mes <= 12 && capital > 0; mes++)
            {
                intereses = capital * tasa;
                double cuota = 100;
                abonos = 100 + (mes * 10);
                capital = capital + intereses - abonos;
                Console.WriteLine("Mes" + mes + " - Capital restante: " + capital);
            }
            Console.ReadKey();
        }
    }
}