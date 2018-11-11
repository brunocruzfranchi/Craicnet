using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_Craicnet
{
    public partial class Inicio : Form
    {
        //Tabla Hash previa
        /* static Hashtable GetHashtable_admin()
         {
             // Create and return new Hashtable.
             Hashtable admin = new Hashtable();
             admin.Add("admin1", "1234");
             admin.Add("admin", "12346");
             admin.Add("ad_bruno", " ");
             return admin;
         }

         static Hashtable GetHashtable_cliente()
         {
             // Create and return new Hashtable.
             Hashtable cliente = new Hashtable();

             cliente.Add("cliente", "1234");
             cliente.Add("cliente1", "12346");
             cliente.Add("cl_juli", " ");
             return cliente;
         }
         */
        //Tabla Hash nueva
        HashExt Tabla_Usuarios;
        public const string Clave_verificacion = "ULTRAVIOLETA";

        //Inicio Form
        public Inicio()
        {
            InitializeComponent();
            Tabla_Usuarios = new HashExt();
            cUsuario cliente = new cUsuario("41292443", " ", false);
            cUsuario admin = new cUsuario("41394723", " ", true);
            Tabla_Usuarios.Agregar(cliente);
            Tabla_Usuarios.Agregar(admin);
        }

        // TODO: VER ALGUNA FORMA DE PODER MANDAR EL USUARIO CUANDO ESTE LISTA LA TABLA HASH PARA PODER USARLO DE ALGUNA FORMA 
        //       COMO POR EJEMPLO, PONER EN LISTA CUALES SON LAS PELICULAS QUE TIENE ALQUILADA.    

        //Buttons 
        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if (txt_UsuarioNuevo.Text.Length < 4)
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
                        Administrador admin = new Administrador();
                        admin.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        Cliente cliente = new Cliente();
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
          
                

           /* if (cbox_tipo.Text == "Administrador")
            {
                Hashtable users_admin = GetHashtable_admin();
                if (users_admin.ContainsKey(txt_usuario.Text))
                {
                    if ((string)users_admin[txt_usuario.Text] == txt_contraseña.Text)
                    {
                        Administrador admin = new Administrador();
                        admin.Show(this);
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Contraseña incorrecta");
                }
                else
                    MessageBox.Show("Usuario Incorrecto");
            }
            else {

                if (cbox_tipo.Text == "Cliente")
                {
                    Hashtable users_cliente = GetHashtable_cliente();
                    if (users_cliente.ContainsKey(txt_usuario.Text))
                    {

                        if ((string)users_cliente[txt_usuario.Text] == txt_contraseña.Text)
                        {
                            Cliente cliente = new Cliente();
                            cliente.Show(this);
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Contraseña incorrecta");
                    }
                    else
                        MessageBox.Show("Usuario Incorrecto");
                }
                else
                {
                    MessageBox.Show("No ha seleccionado tipo de usuario {admin,cleinte}");
                }

                 /* 
                    cUsuario esteUsuario = new cUsuario();
                    cCliente esto = esteUsuario as cCliente;
                    if (esto != null)
                    {
                    }     
                 */
            //}



        }

        //Status Strip

            private void txt_usuario_MouseHover(object sender, EventArgs e)
            {
                toolStripStatus.Text = "Ingrese su DNI";
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

            if (txt_UsuarioNuevo.Text.Length < 4)
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

        

    }
}
