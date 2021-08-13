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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
       
        }

        
        FormGrado1 formGrado1;

        private void pRIMERGRADOToolStripMenuItem_Click(object sender, EventArgs e)
        {

                if (formGrado1 == null)
                {
                    formGrado1 = new FormGrado1();
                    formGrado1.MdiParent = this;
                formGrado1.FormClosed += FormGrado1_FormClosed;
                    formGrado1.Show();
                }
                else
                {
                    formGrado1.Activate();
                }
   
           
        }

        private void FormGrado1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formGrado1 = null;
        }
    }

}
