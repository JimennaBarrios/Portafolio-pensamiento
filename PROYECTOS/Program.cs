using System;
using System.Collections.Generic;
using System.Text;

namespace Granja_imj
{
    class Program
    {
        static double dineroCaja;
        static int numeroEmpleados;
        static double sueldoMensual;
        static int mesesRestantes;
        static Parcela[,] matrizParcelas;
        static List<Semilla> inventarioSemillas = new List<Semilla>();

        static double capitalInicial;
        static double ingresosTotales = 0;
        static double materiaPrimaTotal = 0;
        static int mesesSimuladosTotales;

        static Semilla[] catalogo = new Semilla[]
        {
            new Semilla("Trigo", 100.00, 130.00, 1),
            new Semilla("Repollo", 180.00, 280.00, 2),
            new Semilla("Tomate", 250.00, 450.00, 3),
            new Semilla("Calabaza", 360.00, 220.00, 4),
            new Semilla("Espárrago", 500.00, 1000.00, 6),
            new Semilla("Aguacate", 100.00, 400.00, 1),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE GRANJA ===\n");

            Console.Write("Ingrese cantidad de dinero inicial (Q): ");
            dineroCaja = Convert.ToDouble(Console.ReadLine());
            capitalInicial = dineroCaja;

            Console.Write("Ingrese número de empleados: ");
            numeroEmpleados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese sueldo mensual por empleado (Q): ");
            sueldoMensual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese meses por simular: ");
            mesesRestantes = Convert.ToInt32(Console.ReadLine());
            mesesSimuladosTotales = mesesRestantes;

            Console.Write("Ingrese cantidad de filas para las parcelas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cantidad de columnas para las parcelas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            matrizParcelas = new Parcela[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizParcelas[i, j] = new Parcela();
                }
            }
            Console.Clear();

            while (mesesRestantes > 0 && dineroCaja > 0)
            {
                Console.Clear();
                Console.WriteLine($"--- MESES RESTANTES: {mesesRestantes} | CAJA: Q{dineroCaja} ---");
                Console.WriteLine("1. Comprar Semillas");
                Console.WriteLine("2. Sembrar");
                Console.WriteLine("3. Consultar parcelas");
                Console.WriteLine("4. Avanzar de mes");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Clear();
                    Comprar();
                    PausarYRegresar();
                }
                else if (opcion == "2")
                {
                    Console.Clear();
                    Sembrar();
                    PausarYRegresar();
                }
                else if (opcion == "3")
                {
                    Console.Clear();
                    Consultar();
                    PausarYRegresar();
                }
                else if (opcion == "4")
                {
                    Console.Clear();
                    Avanzar();
                    PausarYRegresar();
                }
                else if (opcion == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                    PausarYRegresar();
                }
            }
            Console.Clear();
            GenerarReporteFinal();
        }
        static void PausarYRegresar()
        {
            Console.WriteLine("\n[Presione ENTER para regresar al menú...]");
            Console.ReadLine();
        }

        static void Comprar()
        {
            Console.WriteLine("=== COMPRAR SEMILLAS ===\n");
            double costosProyectados = numeroEmpleados * sueldoMensual;
            double utilidad = dineroCaja - costosProyectados;

            if (utilidad < 0)
            {
                Console.WriteLine("No se permite comprar más semillas. La utilidad proyectada es negativa.");
                return;
            }

            Console.WriteLine("--- CATÁLOGO ---");
            for (int i = 0; i < catalogo.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {catalogo[i].Nombre} (Costo: Q{catalogo[i].Costo} | Da: Q{catalogo[i].IngresoCosecha} | Tiempo: {catalogo[i].TiempoMeses} meses)");
            }

            Console.Write("\nSeleccione el número de planta a comprar: ");
            int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

            if (seleccion >= 0 && seleccion < catalogo.Length)
            {
                Semilla plantaElegida = catalogo[seleccion];
                if (dineroCaja >= plantaElegida.Costo)
                {
                    dineroCaja = dineroCaja - plantaElegida.Costo;
                    materiaPrimaTotal = materiaPrimaTotal + plantaElegida.Costo;
                    inventarioSemillas.Add(plantaElegida);
                    Console.WriteLine($"\n¡Éxito! Compraste semilla de {plantaElegida.Nombre}.");
                }
                else
                {
                    Console.WriteLine("\nNo hay suficiente dinero en caja.");
                }
            }
            else
            {
                Console.WriteLine("\nSelección inválida.");
            }
        }

        static void Sembrar()
        {
            Console.WriteLine("=== SEMBRAR PARCELA ===\n");
            if (inventarioSemillas.Count == 0)
            {
                Console.WriteLine("No tiene semillas en el inventario. Compre primero.");
                return;
            }

            Console.Write("Ingrese fila del terreno: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese columna del terreno: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (f >= 0 && f < matrizParcelas.GetLength(0) && c >= 0 && c < matrizParcelas.GetLength(1))
            {
                if (matrizParcelas[f, c].Ocupada == false)
                {
                    Console.WriteLine("\nSemillas en tu inventario:");
                    for (int i = 0; i < inventarioSemillas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {inventarioSemillas[i].Nombre}");
                    }
                    Console.Write("\nSeleccione qué semilla usar: ");
                    int sel = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (sel >= 0 && sel < inventarioSemillas.Count)
                    {
                        matrizParcelas[f, c].Sembrar(inventarioSemillas[sel]);
                        inventarioSemillas.RemoveAt(sel);
                        Console.WriteLine("\n¡Sembrado con éxito!");
                    }
                    else
                    {
                        Console.WriteLine("\nSelección inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("\nLa parcela elegida ya está ocupada.");
                }
            }
            else
            {
                Console.WriteLine("\nLas coordenadas exceden los límites de la granja.");
            }
        }

        static void Consultar()
        {
            Console.WriteLine("=== CONSULTAR ESTADO ===\n");
            Console.Write("Ingrese fila a consultar: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese columna a consultar: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (f >= 0 && f < matrizParcelas.GetLength(0) && c >= 0 && c < matrizParcelas.GetLength(1))
            {
                Console.WriteLine($"\n-> Posición consultada: Fila {f}, Columna {c}");

                if (matrizParcelas[f, c].Ocupada == true)
                {
                    Console.WriteLine("Estado: Ocupada");
                    Console.WriteLine($"Tipo de siembra: {matrizParcelas[f, c].CultivoActual.Nombre}");
                    Console.WriteLine($"Meses de crecimiento total: {matrizParcelas[f, c].CultivoActual.TiempoMeses}");
                    Console.WriteLine($"Meses faltantes para cosecha: {matrizParcelas[f, c].MesesRestantes}");
                    Console.WriteLine($"Ingresos esperados al cosechar: Q{matrizParcelas[f, c].CultivoActual.IngresoCosecha}");
                }
                else
                {
                    Console.WriteLine("Estado: Libre");
                    Console.WriteLine("Ingresos esperados: Q0.00");
                }
            }
            else
            {
                Console.WriteLine("\nCoordenadas fuera de rango.");
            }
        }

        static void Avanzar()
        {
            Console.WriteLine("=== RESULTADOS DEL MES ===\n");
            double salariosMes = numeroEmpleados * sueldoMensual;
            dineroCaja = dineroCaja - salariosMes;
            Console.WriteLine($"[NÓMINA] Salarios pagados este mes: -Q{salariosMes}\n");

            for (int i = 0; i < matrizParcelas.GetLength(0); i++)
            {
                for (int j = 0; j < matrizParcelas.GetLength(1); j++)
                {
                    if (matrizParcelas[i, j].Ocupada == true)
                    {
                        double resultadoCosecha = matrizParcelas[i, j].AvanzarMes();

                        if (resultadoCosecha > 0)
                        {
                            dineroCaja = dineroCaja + resultadoCosecha;
                            ingresosTotales = ingresosTotales + resultadoCosecha;
                            Console.WriteLine($"Parcela ({i},{j}): ¡Lista para cosechar! Ingreso sumado: +Q{resultadoCosecha}");
                        }
                        else
                        {
                            Console.WriteLine($"Parcela ({i},{j}): Planta creciendo. Meses restantes: {matrizParcelas[i, j].MesesRestantes}");
                        }
                    }
                }
            }

            mesesRestantes--;
            Console.WriteLine($"\nDinero restante en caja: Q{dineroCaja}");
        }

        static void GenerarReporteFinal()
        {
            int mesesSimulados = mesesSimuladosTotales - mesesRestantes;
            double manoObraTotal = numeroEmpleados * sueldoMensual * mesesSimulados;

            double inventarioProceso = 0;
            for (int i = 0; i < matrizParcelas.GetLength(0); i++)
            {
                for (int j = 0; j < matrizParcelas.GetLength(1); j++)
                {
                    if (matrizParcelas[i, j].Ocupada == true)
                    {
                        inventarioProceso = inventarioProceso + matrizParcelas[i, j].CultivoActual.IngresoCosecha;
                    }
                }
            }

            double utilidadesFinales = capitalInicial + ingresosTotales + inventarioProceso - manoObraTotal - materiaPrimaTotal;

            Console.WriteLine("======================================");
            Console.WriteLine("       REPORTE FINANCIERO FINAL       ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Capital inicial: Q{capitalInicial}");
            Console.WriteLine($"Ingresos por cosechas: Q{ingresosTotales}");
            Console.WriteLine($"Inventario en proceso: Q{inventarioProceso}");
            Console.WriteLine($"Mano de obra (Salarios): Q{manoObraTotal}");
            Console.WriteLine($"Materia Prima (Semillas): Q{materiaPrimaTotal}");
            Console.WriteLine($"Utilidades al finalizar la simulación: Q{utilidadesFinales}");
            Console.WriteLine("======================================");

            Console.WriteLine("\n[Presione ENTER para salir del sistema...]");
            Console.ReadLine();
        }
    }
}