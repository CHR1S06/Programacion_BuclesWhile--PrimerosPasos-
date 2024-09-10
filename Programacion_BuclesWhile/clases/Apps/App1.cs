using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_BuclesWhile.clases.Apps
{
    public class App1
    {
        public static int Max = 10;
        public static int contador = 0;
        public static int suma;
        public static void Programa1()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al primer Progama.\n");
            while (contador < Max)
            {
                contador++;
                while(true)
                {
                    try
                    {
                        Console.Write($"Favor introduzca el {contador} numero: ");
                        int respuesta = Convert.ToInt32(Console.ReadLine());
                        suma += respuesta;
                        break;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
            }

            ComprobracionSumaYProm();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public static void ComprobracionSumaYProm()
        {
            Console.Clear();
            double Promedio = suma / 10;
            Console.WriteLine($@"La suma de esos 10 numeros es: {suma}
El promedio es: {Promedio:F1}");
        }
    }
}
