using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_BuclesWhile.clases.Apps
{
    public class App2
    {
        public static int CantidadPiezas;
        public static int contador = 0;
        public static int PiezasAptas;
        public static int PiezasNoAptas;
        public static double LimitMin = 1.20;
        public static double LimitMax = 1.30;
        public static void Programa2()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al segundo Progama.\n");

            Console.Write("Por favor ingrese la cantidad de piezas: ");
            while (true)
            {
                try
                {
                    CantidadPiezas = Convert.ToInt32(Console.ReadLine());
                    if(CantidadPiezas > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una cantidad valida.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            while (contador < CantidadPiezas)
            {
                contador++;
                while (true)
                {
                    try
                    {
                        Console.Write($"Favor introduzca el largo de la pieza ({contador}): ");
                        double respuesta = Convert.ToDouble(Console.ReadLine());
                        if(respuesta > 0)
                        {
                            if(respuesta >= LimitMin && respuesta <= LimitMax)
                            {
                                PiezasAptas++;
                            }
                            else
                            {
                                PiezasNoAptas++;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ingrese una medida valida");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

            ComprobracionDePiezas();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public static void ComprobracionDePiezas()
        {
            Console.Clear();
            Console.WriteLine($@"La cantidad de piezas aptas son: {PiezasAptas}
La cantidad de piezas no aptas son: {PiezasNoAptas}");
        }
    }
}
