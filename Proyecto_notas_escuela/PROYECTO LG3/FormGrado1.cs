using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_LG3
{
    public partial class FormGrado1 : Form
    {
        public FormGrado1()
        {
            InitializeComponent();
        }

        private string operacion = string.Empty;

        private void FormGrado1_Load(object sender, EventArgs e)
        {
            secciones();
            staus();
            grado();
            ListarDatos();
        }

        //Llenar los combobox con los datos de la base
        private void secciones()
        {
            BASE_DE_DATOS bd = new BASE_DE_DATOS();
            cb_seccion.DataSource = bd.seccion();
            cb_seccion.DisplayMember = "SECCION";
            cb_seccion.ValueMember = "ID";
                
        }
        private void staus()
        {
            BASE_DE_DATOS bd2 = new BASE_DE_DATOS();
            cb_status.DataSource = bd2.status();
            cb_status .DisplayMember = "STATUS";
            cb_status.ValueMember = "ID";

        }
        private void grado()
        {
            BASE_DE_DATOS bd3 = new BASE_DE_DATOS();
            cb_grado.DataSource = bd3.grado();
            cb_grado.DisplayMember = "GRADO";
            cb_grado.ValueMember = "ID";

        }

        //Ingresar solo numeros
        private void nota_finaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Ingresar solo texto y espacio
        private void nombre_alumnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        private void nombre_profesortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        //Ingresar nuevos datos a la tabla
        private void nuevobutton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
            codigo_alumnotxt.Focus();
        }

        //Habilitar los controles
        private void HabilitarControles()
        {
            codigo_alumnotxt.Enabled = true;
            nombre_alumnotxt.Enabled = true;
            nombre_profesortxt.Enabled = true;
            cb_grado.Enabled = true;
            cb_seccion.Enabled = true;
            nota_finaltxt.Enabled = true;
            cb_status.Enabled = true;
            guardarbutton.Enabled = true;
            cancelarbutton.Enabled = true;
            nuevobutton.Enabled = false;
            modificarbutton.Enabled = false;
        }

        //Deshabilitar los controles
        private void DeshabilitarControles()
        {
            codigo_alumnotxt.Enabled = false;
            nombre_alumnotxt.Enabled = false;
            nombre_profesortxt.Enabled = false;
            cb_grado.Enabled = false;
            cb_seccion.Enabled = false;
            nota_finaltxt.Enabled = false;
            cb_status.Enabled = false;
            guardarbutton.Enabled = false;
            cancelarbutton.Enabled = false;
            nuevobutton.Enabled = true;
            modificarbutton.Enabled = true;
        }

        //Limpiar los controles
        private void LimpiarControles()
        {
            codigo_alumnotxt.Clear();
            nombre_alumnotxt.Clear();
            nombre_profesortxt.Clear();
            nota_finaltxt.Clear();
        }

        //Guarda la información en la base de datos
        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigo_alumnotxt.Text))
            {
                errorProvider1.SetError(codigo_alumnotxt, "Ingresar el codigo del alumno");
                codigo_alumnotxt.Focus();
                return;
            }
            errorProvider1.SetError(codigo_alumnotxt, "");

            if (string.IsNullOrEmpty(nombre_alumnotxt.Text))
            {
                errorProvider1.SetError(nombre_alumnotxt, "Ingresar nombre del alumno");
                nombre_alumnotxt.Focus();
                return;
            }
            errorProvider1.SetError(nombre_alumnotxt, "");

            if (string.IsNullOrEmpty(nombre_profesortxt.Text))
            {
                errorProvider1.SetError(nombre_profesortxt, "Ingresar nombre del profesor");
                nombre_profesortxt.Focus();
                return;
            }
            errorProvider1.SetError(nombre_profesortxt, "");

            if (string.IsNullOrEmpty(nota_finaltxt.Text))
            {
                errorProvider1.SetError(nota_finaltxt, "Ingresar nota del alumno");
                nota_finaltxt.Focus();
                return;
            }
            errorProvider1.SetError(nota_finaltxt, "");

            BASE_DE_DATOS bd4 = new BASE_DE_DATOS();
            if (operacion == "Nuevo")
            {
                bool inserto = bd4.InsertarDatos(codigo_alumnotxt.Text, nombre_alumnotxt.Text, nombre_profesortxt.Text, Convert.ToInt32 (cb_grado.SelectedValue), Convert.ToInt32 (cb_seccion.SelectedValue), Convert.ToInt32 (nota_finaltxt.Text), Convert.ToInt32 (cb_status.SelectedValue));
                LimpiarControles();
                ListarDatos();
                DeshabilitarControles();
            }
            else if (operacion == "Modificar")
            {
                bool modifico = bd4.EditarDatos(codigo_alumnotxt.Text, nombre_alumnotxt.Text, nombre_profesortxt.Text, Convert.ToInt32(cb_grado.SelectedValue), Convert.ToInt32(cb_seccion.SelectedValue), Convert.ToInt32(nota_finaltxt.Text), Convert.ToInt32(cb_status.SelectedValue));
                LimpiarControles();
                ListarDatos();
                DeshabilitarControles();
            }

        }

        //Aparecen las columnas de la base de datos en el datagriedview
        private void ListarDatos()
        {
            BASE_DE_DATOS bd5 = new BASE_DE_DATOS();
            datosdataGrid.DataSource = bd5.ListarDatos();
        }

        //Cancelar operacion
        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        //Modificar datos ya ingresados
        private void modificarbutton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (datosdataGrid.SelectedRows.Count >0)
            {
                codigo_alumnotxt.Text = datosdataGrid.CurrentRow.Cells["CODIGO"].Value.ToString();
                nombre_alumnotxt.Text = datosdataGrid.CurrentRow.Cells["NOMBRE"].Value.ToString();
                nombre_profesortxt.Text = datosdataGrid.CurrentRow.Cells["PROFESOR"].Value.ToString();
                cb_grado.Text = datosdataGrid.CurrentRow.Cells["GRADO"].Value.ToString();
                cb_seccion.Text = datosdataGrid.CurrentRow.Cells["SECCION"].Value.ToString();
                nota_finaltxt.Text = datosdataGrid.CurrentRow.Cells["NOTAFINAL"].Value.ToString();
                cb_status.Text = datosdataGrid.CurrentRow.Cells["STATUS"].Value.ToString();
                HabilitarControles();
                codigo_alumnotxt.Enabled = false;
                nombre_alumnotxt.Focus();
            }
            else
            {
                MessageBox.Show("Seleccionar fila a modificar");
            }

        }

        //Eliminar datos
        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (datosdataGrid.SelectedRows.Count > 0)
            {
                BASE_DE_DATOS bd6 = new BASE_DE_DATOS();
                bool eliminar = bd6.EliminarDatos(datosdataGrid.CurrentRow.Cells["CODIGO"].Value.ToString());
                ListarDatos();
            }
            else
            {
                MessageBox.Show("Seleccionar fila a eliminar");
            }
        }

        //Salir del programa
        private void salirbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void nombre_alumnotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
