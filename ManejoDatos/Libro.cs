using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatos
{
    class Libro
    {

        public int Codigo { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public string Pais { get; set; }
        public int Año { get; set; }
        public bool Vigente { get; set; }

        public string NombreAutor
        {
            get
            {
                string nom = "";

                if (this.Autor != null)
                {
                    nom = this.Autor.NombreCompleto + "(" + this.Autor.Nacionalidad + ")";
                }

                return nom;
            }
        }

    }
}
