using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace TPFINAL_Craicnet
{
    class Importar
    {
        /*OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void importarExcel(DataGridView dgv,String nombreHoja)
        {
            String ruta = "C:\\Users\\alumnos.ALUMNOS\\Downloads\\Craicnet-Craicnet\\Craicnet-Craicnet\\Peliculas.xlsx";
            try
            {              
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                    MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                    dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

        public List<cPelicula> ReadCSV(String filename) {

            List<cPelicula> lista_peliculas = File.ReadAllLines(filename).Skip(1).Select(v => cPelicula.FromString(v)).ToList();

            return lista_peliculas;

        }

    }
}
