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
            Fecha_Dev = DateTime.MinValue;
            this.Alq_Mes = 0;
            this.Vistos_Mes = 0;
            this.Alq_Anio = 0;
            this.Vistos_Anio = 0;
            
            }

            public cPelicula(string nombre, string actores, double precio, string director, string genero, string año, string sinopsis,DateTime date, int alqm, int vim, int alqa, int via)
            {
                this.Nombre = nombre;
                this.Actores = actores;
                this.Precio = precio;
                this.Director = director;
                this.Puntaje = 0;
                this.Genero = genero;
                this.Año = año;
                this.Sinopsis = sinopsis;
                this.Fecha_Dev = date;
                this.Alq_Mes = alqm;
                this.Vistos_Mes = vim;
                this.Alq_Anio = alqa;
                this.Vistos_Anio = via;
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
            this.Fecha_Dev = DateTime.MinValue;
            this.Alq_Mes = 0;
            this.Vistos_Mes = 0;
            this.Alq_Anio =0;
            this.Vistos_Anio = 0;
        }

        public cPelicula(string nombre, string actores, double precio, string director, string genero, string año, string sinopsis,int alqm, int vim, int alqa, int via)
        {
            this.Nombre = nombre;
            this.Actores = actores;
            this.Precio = precio;
            this.Director = director;
            this.Puntaje = 0;
            this.Genero = genero;
            this.Año = año;
            this.Sinopsis = sinopsis;
            this.Fecha_Dev = DateTime.MinValue;
            this.Alq_Mes = alqm;
            this.Vistos_Mes = vim;
            this.Alq_Anio = alqa;
            this.Vistos_Anio = via;
        }

        public string Nombre { get; set; }
            public string Actores { get; set; }
            public double Precio { get; set; }
            public Int32 Puntaje { get; set; }
            public string Director { get; set; }
            public string Genero { get; set; }
            public string Año { get; set; }
            public string Sinopsis { get; set; }
            public DateTime Fecha_Dev { get; set; }
            public int Alq_Mes { get; set; }
            public int Vistos_Mes { get; set; }
            public int Alq_Anio { get; set; }
            public int Vistos_Anio { get; set; }
            public static DateTime Ult_Act { get; set; }

        static cPelicula()
        {
            Ult_Act = DateTime.Now;
        }

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
               // pelicula.Fecha_Dev=DateTime.Parse(datos[8]);

                datos = null;

                return pelicula;
            }

        public bool Pelicula_Vencida()
        {
            return (DateTime.Compare(Fecha_Dev, DateTime.Today) < 0);
        }
       static public void Actualizar(List<cPelicula> lista)
        {
            if (DateTime.Now.Year != Ult_Act.Year)
            {
                foreach (cPelicula pelicula in lista)
                {
                    pelicula.Alq_Anio = 0;
                    pelicula.Alq_Mes = 0;
                    pelicula.Vistos_Anio = 0;
                    pelicula.Vistos_Mes = 0;
                }

            }
            else
                if (DateTime.Now.Month != Ult_Act.Year)
            {
                foreach (cPelicula pelicula in lista)
                {
                    pelicula.Alq_Mes = 0;

                    pelicula.Vistos_Mes = 0;
                }
            }

            Ult_Act = DateTime.Now;
        }
    }
}


