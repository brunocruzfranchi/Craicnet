using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFINAL_Craicnet.CLASES;

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
        //Propiedades
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
        //static int ca { get; set; }

        //Constructores
            public cPelicula()
            {
            //Random rnd = new Random();
            this.Nombre = " ";
            this.Actores = " ";
            this.Precio = 0;
            this.Director = " ";
            this.Puntaje = 0;
            this.Genero = " ";
            this.Año = " ";
            this.Sinopsis = " ";
            this.Fecha_Dev = DateTime.Now;
            //this.Alq_Mes = rnd.Next(5, 500);
            this.Alq_Mes = 0;
            this.Vistos_Mes = 0;
            this.Alq_Anio = 0;
            this.Vistos_Anio = 0;

            }
            
            public cPelicula(string nombre, string actores, double precio, string director, string genero, string año, string sinopsis, DateTime date, int alqm, int vim, int alqa, int via)
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
                this.Fecha_Dev = DateTime.Now;
                this.Alq_Mes = 0;
                this.Vistos_Mes = 0;
                this.Alq_Anio = 0;
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
            
            static cPelicula()
            {
                Ult_Act = DateTime.Now;
            }

        //Funciones

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
                pelicula.Vistos_Mes = Int32.Parse(datos[8]);
                pelicula.Alq_Mes = Int32.Parse(datos[9]);
                pelicula.Vistos_Anio = Int32.Parse(datos[10]);
                pelicula.Alq_Anio = Int32.Parse(datos[11]);

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
                foreach (cPromo promo in Inicio.lista_promociones)
                {
                    promo.Pelicula.Alq_Anio = 0;
                    promo.Pelicula.Alq_Mes = 0;
                    promo.Pelicula.Vistos_Anio = 0;
                    promo.Pelicula.Vistos_Mes = 0;
                }

            }
            else
                if (DateTime.Now.Month != Ult_Act.Month)
                {
                    foreach (cPelicula pelicula in lista)
                    {
                        pelicula.Alq_Mes = 0;
                        pelicula.Vistos_Mes = 0;
                    }
                foreach (cPromo promo in Inicio.lista_promociones)
                {
                    promo.Pelicula.Alq_Anio = 0;
                    promo.Pelicula.Alq_Mes = 0;
                    promo.Pelicula.Vistos_Anio = 0;
                    promo.Pelicula.Vistos_Mes = 0;
                }
            }

                Ult_Act = DateTime.Now;
            }

        /* public static List<cPelicula> Quicksort_AlqMes(List<cPelicula> list)
           {
               if (list.Count <= 1) return list;
               int pivotPosition = list.Count / 2;
               cPelicula pivotValue = list[pivotPosition];
               list.RemoveAt(pivotPosition);
               List<cPelicula> greater = new List<cPelicula>();
               List<cPelicula> smaller = new List<cPelicula>();
               foreach (cPelicula item in list)
               {
                   if (item.Alq_Mes > pivotValue.Alq_Mes)
                   {
                       greater.Add(item);
                   }
                   else
                   {
                       smaller.Add(item);
                   }
               }
               List<cPelicula> sorted=Quicksort_AlqMes(greater);
               sorted.Add(pivotValue);
               sorted.AddRange(Quicksort_AlqMes(smaller));
               return sorted;
           }
         public static List<cPelicula> Quicksort_AlqAño(List<cPelicula> list)
         {
             if (list.Count <= 1) return list;
             int pivotPosition = list.Count / 2;
             cPelicula pivotValue = list[pivotPosition];
             list.RemoveAt(pivotPosition);
             List<cPelicula> greater = new List<cPelicula>();
             List<cPelicula> smaller = new List<cPelicula>();
             foreach (cPelicula item in list)
             {
                 if (item.Alq_Anio > pivotValue.Alq_Anio)
                 {
                     greater.Add(item);
                 }
                 else
                 {
                     smaller.Add(item);
                 }
             }
             List<cPelicula> sorted = Quicksort_AlqAño(greater);
             sorted.Add(pivotValue);
             sorted.AddRange(Quicksort_AlqAño(smaller));
             return sorted;
         }*/

        public static List<cPelicula> QuickSort_AlqAnio(List<cPelicula> i)
        {
            if (!i.Any())
                return i;
            var p = (i.First().Alq_Anio + i.Last().Alq_Anio) / 2;//whichever pivot method you choose

            return QuickSort_AlqAnio(i.Where(x => x.Alq_Anio < p).ToList()).
                Concat(i.Where(x => x.Alq_Anio == p).Concat(QuickSort_AlqAnio(i.Where(x => x.Alq_Anio > p).ToList()))).ToList();
        }

        public static List<cPelicula> QuickSort_AlqMes(List<cPelicula> i)
        {
            if (!i.Any())
                return i;
            var p = (i.First().Alq_Mes + i.Last().Alq_Mes) / 2;//whichever pivot method you choose
            return QuickSort_AlqMes(i.Where(x => x.Alq_Mes < p).ToList()).Concat(i.Where(x => x.Alq_Mes == p).Concat(QuickSort_AlqMes(i.Where(x => x.Alq_Mes > p).ToList()))).ToList();
        }

        public static List<cPelicula> BubbleSort_VistMes(List<cPelicula> list)
        {
            cPelicula aux = new cPelicula();
            int cont_camb = 0;

            for (int i = 0; i < list.Count()-1; i++)
            {
                cont_camb = 0;
                for (int j = 0; j < list.Count() - 1; j++)
                {
                    if (list[j].Vistos_Mes < list[j + 1].Vistos_Mes)
                    {
                        aux = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = aux;
                        cont_camb++;
                    }
                }

               if (cont_camb==0) break;
            }

            return list;
        }

        public static List<cPelicula> BubbleSort_VistAño(List<cPelicula> list)
        {
            cPelicula aux = new cPelicula();
            int cont_camb = 0;

            for (int i = 0; i < list.Count() - 1; i++)
            {
                cont_camb = 0;
                for (int j = 0; j < list.Count() - 1; j++)
                {
                    if (list[j].Vistos_Anio < list[j + 1].Vistos_Anio)
                    {
                        aux = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = aux;
                        cont_camb++;
                    }
                }

                if (cont_camb == 0) break;
            }

            return list;
        }

        /*  int MyPartition(List<cPelicula> list, int left, int right)
          {
              cPelicula pivot = list[left];

              while (true)
              {
                  while (list[left] < pivot)
                      left++;

                  while (list[right] > pivot)
                      right--;

                  if (list[right] == pivot && list[left] == pivot)
                      left++;

                  if (left < right)
                  {
                      int temp = list[left];
                      list[left] = list[right];
                      list[right] = temp;
                  }
                  else
                  {
                      return right;
                  }
              }
          }

          void MyQuickSort(List<int> list, int left, int right)
          {
              if (list == null || list.Count <= 1)
                  return;

              if (left < right)
              {
                  int pivotIdx = MyPartition(list, left, right);

                  if (pivotIdx > 1)
                      MyQuickSort(list, left, pivotIdx - 1);

                  if (pivotIdx + 1 < right)
                      MyQuickSort(list, pivotIdx + 1, right);
              }
          }*/
    }
}
