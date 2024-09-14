using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_BuclesWhile.clases.Apps
{
    public class App2
    {
        // Variables para el control de piezas y sus medidas
        private int CantidadPiezas;        // Total de piezas a evaluar
        private int contador = 0;          // Contador de iteraciones
        private int PiezasAptas;           // Contador de piezas que cumplen con las especificaciones
        private int PiezasNoAptas;         // Contador de piezas que no cumplen con las especificaciones
        private double LimitMin = 1.20;    // Límite mínimo de medida de la pieza
        private double LimitMax = 1.30;    // Límite máximo de medida de la pieza

        // Método principal del programa
        public void Programa2()
        {
            // Limpiamos la consola y mostramos un mensaje de bienvenida
            Console.Clear();
            Console.WriteLine("Bienvenido al segundo Programa.\n");

            // Solicitamos la cantidad de piezas al usuario
            Console.Write("Por favor ingrese la cantidad de piezas: ");
            while (true)
            {
                try
                {
                    // Convertimos la entrada del usuario a entero
                    CantidadPiezas = Convert.ToInt32(Console.ReadLine());

                    // Validamos que la cantidad de piezas sea mayor a 0
                    if (CantidadPiezas > 0)
                    {
                        break; // Si es válido, salimos del bucle
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una cantidad válida.");
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción, mostramos el mensaje de error
                    Console.WriteLine(ex.Message);
                }
            }

            // Bucle para evaluar todas las piezas
            while (contador < CantidadPiezas)
            {
                contador++; // Incrementamos el contador de piezas procesadas

                while (true)
                {
                    try
                    {
                        // Solicitamos al usuario la longitud de la pieza
                        Console.Write($"Favor introduzca el largo de la pieza ({contador}): ");
                        double respuesta = Convert.ToDouble(Console.ReadLine());

                        // Validamos que la medida ingresada sea mayor a 0
                        if (respuesta > 0)
                        {
                            // Verificamos si la pieza cumple con los límites de tamaño
                            if (respuesta >= LimitMin && respuesta <= LimitMax)
                            {
                                // Si la pieza está dentro de los límites, incrementamos las piezas aptas
                                PiezasAptas++;
                            }
                            else
                            {
                                // Si no, incrementamos las piezas no aptas
                                PiezasNoAptas++;
                            }
                            break; // Salimos del bucle si se ingresó una medida válida
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una medida válida");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre una excepción, mostramos el mensaje de error
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            // Llamamos al método que muestra el resultado
            ComprobracionDePiezas();

            // Cambiamos el color del texto y mostramos un mensaje para volver al menú
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menú presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Volvemos al menú principal
            Menu menu = new Menu();
            menu.MenuProgram();
        }

        // Método para mostrar el resultado de la verificación de piezas
        public void ComprobracionDePiezas()
        {
            Console.Clear();

            // Mostramos cuántas piezas son aptas y cuántas no
            Console.WriteLine($@"La cantidad de piezas aptas son: {PiezasAptas}
La cantidad de piezas no aptas son: {PiezasNoAptas}");
        }
    }
}
