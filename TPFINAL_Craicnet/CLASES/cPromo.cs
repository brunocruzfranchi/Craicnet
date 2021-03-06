﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet.CLASES
{
    public class cPromo
    {
        public float Porcentaje_Descuento { get; set; }

        public cPelicula Pelicula { get; set; }

        public DateTime Fecha_limite { get; set; }

        //----------------Propiedades--------------------//

        public string Nombre { get; set; }
        public string Actores { get; set; }
        public double Precio { get; set; }
        public double Precio_descuento { get; set; }
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

        //----------------------------------------------//

        //Constructores

        public cPromo()
        {
            Pelicula=null;
            Porcentaje_Descuento = 0.0F;
            Fecha_limite = DateTime.Today;
        }

        public cPromo(cPelicula peli, float d, DateTime date)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d;
            Fecha_limite = date;
        }

        public cPromo(cPelicula pelicula, string descuento, string fechalimite)
        {
            Pelicula = pelicula;

            this.Nombre = pelicula.Nombre;
            this.Genero = pelicula.Genero;
            this.Director = pelicula.Director;
            this.Precio = pelicula.Precio;
            this.Año = pelicula.Año;
            this.Actores = pelicula.Actores;
            this.Puntaje = pelicula.Puntaje;
            this.Sinopsis = pelicula.Sinopsis;
            this.Vistos_Mes = pelicula.Vistos_Mes;
            this.Alq_Mes = pelicula.Alq_Mes;
            this.Vistos_Anio = pelicula.Vistos_Anio;
            this.Alq_Anio = pelicula.Alq_Anio;
            this.Porcentaje_Descuento = float.Parse(descuento);
            this.Fecha_limite = DateTime.Parse(fechalimite);
            this.Precio_descuento = (double)(this.Precio - this.Porcentaje_Descuento * this.Precio);
        }

        public cPromo(cPelicula peli, int d, DateTime date)
        {
            Pelicula = peli;
            Porcentaje_Descuento = d/100;
            Fecha_limite = date;
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
            Porcentaje_Descuento = d / 100;
            Fecha_limite = DateTime.Today.AddDays(3);
        }


        //Funciones

        internal static cPromo FromString(string linea)
        {
            cPromo promo = new cPromo();

            string[] datos = linea.Split(';');

            //pelicula = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(datos[0]));

            promo.Pelicula = cPelicula.FromString(linea);
            promo.Nombre = datos[0];
            promo.Genero = datos[1];
            promo.Director = datos[2];
            promo.Precio = double.Parse(datos[3]);
            promo.Año = datos[4];
            promo.Actores = datos[5];
            promo.Puntaje = Int32.Parse(datos[6]);
            promo.Sinopsis = datos[7];
            promo.Vistos_Mes = Int32.Parse(datos[8]);
            promo.Alq_Mes = Int32.Parse(datos[9]);
            promo.Vistos_Anio = Int32.Parse(datos[10]);
            promo.Alq_Anio = Int32.Parse(datos[11]);
            promo.Porcentaje_Descuento = float.Parse(datos[12]);
            promo.Fecha_limite = DateTime.Parse(datos[13]);
            promo.Precio_descuento = (double)(promo.Precio - promo.Porcentaje_Descuento * promo.Precio);

            datos = null;

            return promo;
        }


        public float PrecioPromo()
        {
            return float.Parse((this.Precio - this.Porcentaje_Descuento * this.Precio).ToString());
            //return float.Parse((Pelicula.Precio - Porcentaje_Descuento * Pelicula.Precio).ToString());
        }

        public string PrecioPromo_String()
        {
            return (this.Precio - this.Porcentaje_Descuento * this.Precio).ToString();
        }

        public void Update_datos()
        {

            /*
             * Una vez hecho el cambio en una pelicula proveniente de la lista promocion
             * tengo que pasar los datos a mi variable Pelicula para que luego de que deje
             * de estar en promocion se pase unicamente los datos necesarios
            */

            Pelicula.Nombre = this.Nombre;
            Pelicula.Genero = this.Genero;
            Pelicula.Director = this.Director;
            Pelicula.Precio = this.Precio;
            Pelicula.Año = this.Año;
            Pelicula.Actores = this.Actores;
            Pelicula.Sinopsis = this.Sinopsis;
            Pelicula.Puntaje = this.Puntaje;
            Pelicula.Alq_Anio = this.Alq_Anio;
            Pelicula.Alq_Mes = this.Alq_Mes;
            Pelicula.Vistos_Mes = this.Vistos_Mes;
            Pelicula.Vistos_Anio = this.Vistos_Anio;

            this.Precio_descuento = (double)(this.Precio - this.Porcentaje_Descuento * this.Precio);
        }

       static public void Actualizar_promociones()
        {
            foreach(cPromo promo in Inicio.lista_promociones)
            {
                if(DateTime.Today > promo.Fecha_limite){
                    Inicio.lista_peliculas.Add(promo.Pelicula);
                    Inicio.lista_promociones.Remove(promo);                  
                }
            }
        }
    }
}
