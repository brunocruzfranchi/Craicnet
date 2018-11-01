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
        static Hashtable GetHashtable_admin()
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

        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if (cbox_tipo.Text == "Administrador")
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
            }
        }
    }
}
