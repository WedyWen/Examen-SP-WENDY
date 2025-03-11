using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SP_WENDY
{
    internal class Videojuegos
    {
        public Videojuegos(string nombre, string categoria, int anioDLanzamiento, string personajeFav, string personajePrincipal)
        {
            Nombre = nombre;
            Categoria = categoria;
            AnioDLanzamiento = anioDLanzamiento;
            PersonajeFav = personajeFav;
            PersonajePrincipal = personajePrincipal;
        }

        public string  Nombre { get; set; }
        public string Categoria { get; set; }
        public int AnioDLanzamiento { get; set; }
        public string PersonajeFav { get; set; }
        public string PersonajePrincipal { get; set; }

        public Videojuegos () 
        { }

    }
}
