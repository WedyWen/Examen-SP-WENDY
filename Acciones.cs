using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SP_WENDY
{
    internal class Acciones
    {

        public List<Videojuegos> ListaVideojuegos = new List<Videojuegos>();
        Videojuegos a = new Videojuegos();

        public void AgregarVideojuego()
        {
            Console.WriteLine("Nombre");
            a.Nombre = Console.ReadLine();

            Console.WriteLine("Categoria (Terror, Accion, Colaborativo, etc)");
            a.Categoria = Console.ReadLine();

            Console.WriteLine("Anio de lanzamiento");
            a.AnioDLanzamiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Personaje Favorito");
            a.PersonajeFav = Console.ReadLine();

            Console.WriteLine("Personaje Principal");
            a.PersonajePrincipal = Console.ReadLine();

            ListaVideojuegos.Add(new Videojuegos (a.Nombre, a.Categoria, a.AnioDLanzamiento, a.PersonajeFav, a.PersonajePrincipal));
            Console.WriteLine("Videojuego agregado correctamente");

        }

        public void MostrarVideojuegos()
        {
            foreach (var p in ListaVideojuegos)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Categoria: {p.Categoria}");
                Console.WriteLine($"Anio de lanzamiento: {p.AnioDLanzamiento}");
                Console.WriteLine($"Personaje Favorito: {p.PersonajeFav}");
                Console.WriteLine($"Perosnaje Principal: {p.PersonajePrincipal}");
            }
        }


        public int ContarVideojuegos()
        {
            return ListaVideojuegos.Count;
        }

        public void EliminarVideojuego(string nombrevideojuego)
        {
            var videojuego = ListaVideojuegos.Find(x => x.Nombre == nombrevideojuego);
            
            if (videojuego != null)
            {
                ListaVideojuegos.Remove(videojuego);
                Console.WriteLine("Videojuego ELIMINADO");
            }
            else
            {
                Console.WriteLine("No se encontro el videojuego");
            }
        }

        public void ActualizarVideojuego(string nombrevideojuego)
        {
            var videojuego = ListaVideojuegos.FirstOrDefault(x => x.Nombre==nombrevideojuego);
            if ( videojuego != null)
            {
                Console.WriteLine("Ingresa los nuevos datos");
                Console.WriteLine("Nombre");

                Console.WriteLine("Categoria");
                Console.WriteLine("Anio de lanzamiento");
                Console.WriteLine("Tu personaje favorito");
                Console.WriteLine("Personaje Principal");
            }
        }






    }
}
