using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatos
{
    public class Autor
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Nacionalidad { get; set; }
        public bool Vigente { get; set; }

        public string NombreCompleto {
            get {
                return this.Nombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno;
            }
        }
    }
}
