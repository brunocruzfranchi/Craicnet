using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace TPFINAL_Craicnet
{
    class Importar
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void importarExcel(DataGridView dgv,String nombreHoja)
        {
            String ruta = "C:\\Users\\bruno\\Documents\\Visual Studio 2017\\Projects\\TPFINAL_Craicnet\\Peliculas.xlsx";
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
        }
    }
}
