using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cPeliculas
    {
        public cPeliculas()
        {
            this.Pelicula = " ";
            this.Principal = " ";
            this.Director = " ";
            this.Genero = " ";
            this.Año = " ";
            this.Resena = " ";
        }

        public string Pelicula { get; set; }
        public string Principal { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Año { get; set; }
        public string Resena { get; set; }
    }
}
