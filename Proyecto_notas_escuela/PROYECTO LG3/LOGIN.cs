using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace PROYECTO_LG3
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        //Validaciones
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(usuariotxt.Text == "")
            {
                errorProvider1.SetError(usuariotxt, "Ingrese su Usuario (INFOU)");
                usuariotxt.Focus();
                return;
            }
            errorProvider1.SetError(usuariotxt, "");

            if (contraseñatxt.Text == "")
            {
                errorProvider1.SetError(contraseñatxt, "Ingrese su Contraseña");
                contraseñatxt.Focus();
                return;
            }
            errorProvider1.SetError(contraseñatxt, "");

            //entrando a la base de datos
            //USUARIO INFOU CONTRA:12345
            BASE_DE_DATOS conexion = new BASE_DE_DATOS();

            if (conexion.validarusuario(usuariotxt.Text,contraseñatxt.Text))
            {
                FormularioPrincipal Formulario = new FormularioPrincipal();
                this.Hide();
                Formulario.Show();

            }
            else
            {
                MessageBox.Show(" USUARIO O CONTRASEÑA INCORRECTOS");
            }
        }

        //Cerrar el programa
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Mostrar contraseña
        private void cb_mostrar_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrar_contraseña.Checked == true)
            {
                contraseñatxt.PasswordChar = Convert.ToChar("\0");
            }
            else
            {
                contraseñatxt.PasswordChar = Convert.ToChar("*");
            }
        }
    }
}
