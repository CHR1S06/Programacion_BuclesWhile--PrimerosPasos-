using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_BuclesWhile.clases.Apps
{
    public class App1
    {
        // Variables para controlar el número máximo de entradas, el contador de iteraciones y la suma acumulada.
        private int Max = 10;
        private int contador = 0;
        private int suma;

        // Método principal del programa.
        public void Programa1()
        {
            // Limpiamos la consola y mostramos un mensaje de bienvenida.
            Console.Clear();
            Console.WriteLine("Bienvenido al primer Programa.\n");

            // Iniciamos un ciclo while para pedir 10 números al usuario.
            while (contador < Max)
            {
                // Incrementamos el contador.
                contador++;

                // Otro ciclo while para manejar la captura de errores en la entrada.
                while (true)
                {
                    try
                    {
                        // Solicitamos al usuario que ingrese un número.
                        Console.Write($"Favor introduzca el {contador} numero: ");
                        int respuesta = Convert.ToInt32(Console.ReadLine());

                        // Sumamos el número ingresado al total acumulado.
                        suma += respuesta;

                        // Salimos del ciclo una vez se captura correctamente el número.
                        break;
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error en la entrada (como ingresar un valor no numérico), mostramos el mensaje de error.
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            // Llamamos al método que calcula y muestra la suma y el promedio.
            ComprobracionSumaYProm();

            // Cambiamos el color del texto a azul oscuro y mostramos un mensaje para que el usuario presione una tecla.
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menú, presione cualquier tecla");
            Console.ResetColor();

            // Esperamos a que el usuario presione una tecla.
            Console.ReadKey();

            // Creamos una nueva instancia del menú y volvemos al menú principal.
            Menu menu = new Menu();
            menu.MenuProgram();
        }

        // Método para calcular y mostrar la suma y el promedio de los números ingresados.
        public void ComprobracionSumaYProm()
        {
            // Limpiamos la consola.
            Console.Clear();

            // Calculamos el promedio dividiendo la suma total entre 10.
            double Promedio = suma / 10.0;

            // Mostramos la suma y el promedio con un formato de una decimal para el promedio.
            Console.WriteLine($@"La suma de esos 10 números es: {suma}
El promedio es: {Promedio:F1}");
        }
    }
}

