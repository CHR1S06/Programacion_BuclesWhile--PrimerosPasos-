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
        public static int RespuestaMenu;
        public static void MenuProgram()
        {
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programacion Bucles While

1- (App 1) SumaYPromedioDeDiez.
2- (App 2) ContadorDePiezasAptas.
3- Salir del programa");

            Console.Write("\nDigite su respuesta aqui: ");

            while (true)
            {
                try
                {
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    if (RespuestaMenu >= 1 && RespuestaMenu <= 3)
                    {
                        switch (RespuestaMenu)
                        {
                            case 1:
                                App1.Programa1();
                                break;

                            case 2:
                                App2.Programa2();
                                break;

                            case 3:
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}