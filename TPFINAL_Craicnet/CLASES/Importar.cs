using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using TPFINAL_Craicnet.CLASES;

namespace TPFINAL_Craicnet
{
    class Importar
    {
        public List<cPelicula> ReadCSV(String filename) {

            List<cPelicula> lista_peliculas = File.ReadAllLines(filename).Skip(1).Select(v => cPelicula.FromString(v)).ToList();

            return lista_peliculas;

        }

      /*  public List<cPromo> ReadCSV_promo(String filename)
        {
            List<cPromo> lista_peliculas = File.ReadAllLines(filename).Skip(1).Select(v => cPromo.FromString(v)).ToList();

            return lista_peliculas;
        }*/
    }
}
