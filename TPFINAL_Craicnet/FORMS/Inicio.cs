using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFINAL_Craicnet.CLASES;

namespace TPFINAL_Craicnet
{
    public partial class Inicio : Form
    {
        
        public static List<cPelicula> lista_peliculas = new List<cPelicula>();
        public static List<cPromo> lista_promociones = new List<cPromo>();
        public static DataTable peliculas = new DataTable();
        public static DataTable promociones = new DataTable();

        //Tabla Hash nueva
        HashExt Tabla_Usuarios;
        public const string Clave_verificacion = "ULTRAVIOLETA";
        public const int Min_Length_ID = 5;

        //Inicio Form
        public Inicio()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 1000;
            this.CenterToScreen();
           
            Tabla_Usuarios = new HashExt();
            cUsuario cliente = new cUsuario("41292443", " ", false);
            cUsuario admin = new cUsuario("41394723", " ", true);
            cUsuario julieta_admin = new cUsuario("412924433", " ", true);
            Tabla_Usuarios.Agregar(julieta_admin);
            Tabla_Usuarios.Agregar(cliente);
            Tabla_Usuarios.Agregar(admin);

            lista_peliculas = new Importar().ReadCSV(AppDomain.CurrentDomain.BaseDirectory + "\\Peliculas-CSV.csv");
            lista_promociones = new Importar().ReadCSV_promo(AppDomain.CurrentDomain.BaseDirectory + "\\Peliculas-Promo-CSV.csv");

            peliculas = ToDataTable<cPelicula>(lista_peliculas);
            promociones = ToDataTable<cPromo>(lista_promociones);

        }

        //Buttons 
        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Length < Min_Length_ID)
            {
                MessageBox.Show("Usuario Inválido");
                return;
            }
            cUsuario usuario_ingresando = Tabla_Usuarios.Buscar_usuario(txt_usuario.Text);
            if (usuario_ingresando!=null)
            {
                if (usuario_ingresando.Password == txt_contraseña.Text)
                {
                    if (usuario_ingresando.Admin)
                    {
                        Administrador admin = new Administrador(usuario_ingresando/*, lista_peliculas, peliculas, lista_promociones, promociones*/);
                        admin.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        Cliente cliente = new Cliente(usuario_ingresando);
                        cliente.Show(this);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuario No Existente");
                return;
            }
          
        }

        //Status Strip

            private void txt_usuario_MouseHover(object sender, EventArgs e)
            {
                toolStripStatus.Text = "Ingrese su DNI";

            Timer tiempo = new Timer();

            tiempo.Start();

            tiempo.Stop();

            int lalala = tiempo.Interval;
            }

            private void txt_usuario_MouseLeave(object sender, EventArgs e)
            {
                toolStripStatus.Text = "";
            }

            private void txt_contraseña_MouseHover(object sender, EventArgs e)
            {
                toolStripStatus.Text = "Ingrese su Contraseña";
            }

            private void txt_contraseña_MouseLeave(object sender, EventArgs e)
            {
                toolStripStatus.Text = "";
            }

            private void btn_iniciar_sesion_MouseHover(object sender, EventArgs e)
            {
                toolStripStatus.Text = "Haz click aquí para iniciar sesión";
            }

            private void btn_iniciar_sesion_MouseLeave(object sender, EventArgs e)
            {
                toolStripStatus.Text = "";
            }

            private void cbox_tipo_MouseHover(object sender, EventArgs e)
            {
                toolStripStatus.Text = "Seleccione el tipo de usuario";
            }

            private void cbox_tipo_MouseLeave(object sender, EventArgs e)
            {
                toolStripStatus.Text = "";
            }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Caricenet000.png");
        }

        private void radio_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            txt_verificacion.Enabled = false;
        }

        private void radio_Admin_CheckedChanged(object sender, EventArgs e)
        {
            txt_verificacion.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            if (txt_UsuarioNuevo.Text.Length < Min_Length_ID)
            {
                MessageBox.Show("Usuario Inválido");
                return;
            }
            if (Tabla_Usuarios.Buscar_usuario(txt_UsuarioNuevo.Text) != null)
            { MessageBox.Show("Usuario ya existente");
                return;
            }
            else
            {
                if (radio_Admin.Checked)
                {
                    if (txt_verificacion.Text == Clave_verificacion)
                    {
                        Tabla_Usuarios.Agregar(new cUsuario(txt_UsuarioNuevo.Text, txt_ContraseñaNueva.Text, radio_Admin.Checked));
                        MessageBox.Show("Nuevo usuario registrado exitosamente");
                    }
                    else
                        MessageBox.Show("Clave de Verificación Incorrecta");
                }
                else
                {
                    Tabla_Usuarios.Agregar(new cUsuario(txt_UsuarioNuevo.Text, txt_ContraseñaNueva.Text, radio_Admin.Checked));
                    MessageBox.Show("Nuevo usuario registrado exitosamente");
                }

            }
        }

        /// <summary>
        /// ToDataTable me ayuda a convertir lo que una variable list
        /// a una DataTable. Esto me ayuda para poder facilitarme hacer las 
        /// funciones de Ordenar, Agregar , etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
