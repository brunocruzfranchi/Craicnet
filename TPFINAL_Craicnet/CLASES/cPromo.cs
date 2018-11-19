using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet.CLASES
{
    public class cPromo
    {
        public cPelicula Pelicula;
        public float Porcentaje_Descuento;
        public DateTime Fecha_limite;

        public cPromo()
        {
            Pelicula=null;
            Porcentaje_Descuento = 0.0F;
            Fecha_limite = DateTime.Today;
            
        }

        public cPromo(cPelicula peli,float d, DateTime date)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d;
            Fecha_limite = date;
        }
        public cPromo(cPelicula peli, int d, DateTime date)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d/100;
            Fecha_limite = date;
        }

        internal static object FromString(string linea)
        {
            cPelicula pelicula = new cPelicula();
            cPromo promo = new cPromo();
        
            string[] datos = linea.Split(';');

            pelicula = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(datos[0]));

            promo.Porcentaje_Descuento = float.Parse(datos[1]);
            promo.Fecha_limite = DateTime.Parse(datos[2]);

            datos = null;

            return pelicula;
        }

        public cPromo(cPelicula peli, float d)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d;
            Fecha_limite = DateTime.Today.AddDays(3);
        }
        public cPromo(cPelicula peli, int d)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d/100;
            Fecha_limite = DateTime.Today.AddDays(3);
        }

        //public cPromo(string nombre, int d, string date)
        //{   
        //}

        public float PrecioPromo()
        {
            return float.Parse((Pelicula.Precio - Porcentaje_Descuento * Pelicula.Precio).ToString());
        }

        public string PrecioPromo_String()
        {
            return (Pelicula.Precio - Porcentaje_Descuento * Pelicula.Precio).ToString();
        }
    }
}
