using Programacion_BuclesWhile.clases.Apps;
using Programacion_BuclesWhile.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

namespace Programacion_BuclesWhile
{
    public class Menu
    {
        // Variable para almacenar la respuesta del usuario en el menú
        private int RespuestaMenu;

        // Método principal para mostrar el menú y ejecutar las opciones seleccionadas
        public void MenuProgram()
        {
            // Limpiamos la consola y mostramos un mensaje de bienvenida y las opciones del menú
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programación Bucles While

1- (App 1) Suma y Promedio de Diez Números.
2- (App 2) Contador de Piezas Aptas.
3- Salir del programa");

            // Solicitamos al usuario que ingrese su opción
            Console.Write("\nDigite su respuesta aquí: ");

            // Bucle que controla la selección válida del menú
            while (true)
            {
                try
                {
                    // Convertimos la entrada del usuario a entero
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verificamos si la respuesta está dentro del rango de opciones del menú
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 3)
                    {
                        // Ejecutamos la acción correspondiente a la opción seleccionada
                        switch (RespuestaMenu)
                        {
                            // Opción 1: Ejecuta la aplicación App1 (Suma y Promedio de Diez Números)
                            case 1:
                                App1 app1 = new App1();
                                app1.Programa1(); // Llamada al método principal de App1
                                break;

                            // Opción 2: Ejecuta la aplicación App2 (Contador de Piezas Aptas)
                            case 2:
                                App2 app2 = new App2();
                                app2.Programa2(); // Llamada al método principal de App2
                                break;

                            // Opción 3: Salir del programa
                            case 3:
                                return; // Finaliza el programa
                        }

                        // Rompe el bucle si se seleccionó una opción válida y se ejecutó la acción
                        break;
                    }
                    else
                    {
                        // Mensaje si el usuario ingresó un número fuera del rango
                        Console.WriteLine("Por favor limítese a digitar uno de los números mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción (como ingreso inválido), mostramos el mensaje de error
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
