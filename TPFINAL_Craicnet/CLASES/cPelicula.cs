using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_Craicnet
{
    /*TODO
     * Hacer una lista Alquiler: Id, id_peliculas, id_usuario, precio, pelicula, usuario.
     * 
     */
    [Serializable]

    public class cPelicula
    {
        // internal object dt;

            public cPelicula()
            {
                this.Nombre = " ";
                this.Actores = " ";
                this.Precio = 0;
                this.Director = " ";
                this.Puntaje = 0;
                this.Genero = " ";
                this.Año = " ";
                this.Sinopsis = " ";
            }

            public cPelicula(string nombre, string actores, double precio, string director, string genero, string año, string sinopsis)
            {
                this.Nombre = nombre;
                this.Actores = actores;
                this.Precio = precio;
                this.Director = director;
                this.Puntaje = 0;
                this.Genero = genero;
                this.Año = año;
                this.Sinopsis = sinopsis;
            }

            public string Nombre { get; set; }
            public string Actores { get; set; }
            public double Precio { get; set; }
            public Int32 Puntaje { get; set; }
            public string Director { get; set; }
            public string Genero { get; set; }
            public string Año { get; set; }
            public string Sinopsis { get; set; }

        internal static cPelicula FromString(string linea)
        {
            cPelicula pelicula = new cPelicula();

            string[] datos = linea.Split(';');

            pelicula.Nombre = datos[0];
            pelicula.Genero = datos[1];
            pelicula.Director = datos[2];
            pelicula.Precio = double.Parse(datos[3]);
            pelicula.Año = datos[4];
            pelicula.Actores = datos[5];
            pelicula.Puntaje = Int32.Parse(datos[6]);
            pelicula.Sinopsis = datos[7];

            datos = null;

            return pelicula;
        }
    }

}
