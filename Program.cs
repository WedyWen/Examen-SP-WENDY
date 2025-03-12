using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SP_WENDY
{
    internal class Program
    {
        public enum Menu
        {
            AgregarVJ = 1, MostrarVJ, ContarVJ, EliminarVJ, ActualizarVJ, Salir
        }

        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {
                switch (menu())
                {
                    case Menu.AgregarVJ:
                        acciones.AgregarVideojuego();
                        break;
                    case Menu.MostrarVJ:
                        acciones.MostrarVideojuegos();
                        break;
                    case Menu.ContarVJ:
                        Console.WriteLine(acciones.ContarVideojuegos());
                        break;
                    case Menu.EliminarVJ:
                        Console.WriteLine("Que videojuego quieres borrar");
                        string nombre = Console.ReadLine();
                        acciones.EliminarVideojuego(nombre);
                        break;
                    case Menu.ActualizarVJ:
                        Console.WriteLine("Que videojuegas deseas actualizar");
                        string nombre1 = Console.ReadLine();
                        acciones.ActualizarVideojuego(nombre1);
                        break;
                    case Menu.Salir:
                        Environment.Exit(1);
                        break;

                }
            }
            
        }

        static Menu menu()
        {
            Console.WriteLine("1) Agregar videojuego");
            Console.WriteLine("2) Mostrar videojuegos");
            Console.WriteLine("3) Contar videojuegos");
            Console.WriteLine("4) Eliminar videojuego");
            Console.WriteLine("5) Actualizar videojuego");
            Console.WriteLine("6) Salir");
            Menu opc = (Menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        //Program terminado
    }
}
