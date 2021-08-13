
namespace PROYECTO_LG3
{
    partial class FormGrado1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrado1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_grado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo_alumnotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nota_finaltxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_seccion = new System.Windows.Forms.ComboBox();
            this.nombre_profesortxt = new System.Windows.Forms.TextBox();
            this.nombre_alumnotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.datosdataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.salirbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_grado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.codigo_alumnotxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nota_finaltxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_seccion);
            this.groupBox1.Controls.Add(this.nombre_profesortxt);
            this.groupBox1.Controls.Add(this.nombre_alumnotxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE ALUMNOS";
            // 
            // cb_grado
            // 
            this.cb_grado.Enabled = false;
            this.cb_grado.FormattingEnabled = true;
            this.cb_grado.Location = new System.Drawing.Point(232, 151);
            this.cb_grado.Name = "cb_grado";
            this.cb_grado.Size = new System.Drawing.Size(121, 21);
            this.cb_grado.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grado";
            // 
            // codigo_alumnotxt
            // 
            this.codigo_alumnotxt.Enabled = false;
            this.codigo_alumnotxt.Location = new System.Drawing.Point(133, 34);
            this.codigo_alumnotxt.Name = "codigo_alumnotxt";
            this.codigo_alumnotxt.Size = new System.Drawing.Size(71, 20);
            this.codigo_alumnotxt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo de Alumno";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(232, 274);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Status";
            // 
            // nota_finaltxt
            // 
            this.nota_finaltxt.Enabled = false;
            this.nota_finaltxt.Location = new System.Drawing.Point(232, 232);
            this.nota_finaltxt.Name = "nota_finaltxt";
            this.nota_finaltxt.Size = new System.Drawing.Size(121, 20);
            this.nota_finaltxt.TabIndex = 16;
            this.nota_finaltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nota_finaltxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nota Final";
            // 
            // cb_seccion
            // 
            this.cb_seccion.Enabled = false;
            this.cb_seccion.FormattingEnabled = true;
            this.cb_seccion.Location = new System.Drawing.Point(232, 194);
            this.cb_seccion.Name = "cb_seccion";
            this.cb_seccion.Size = new System.Drawing.Size(121, 21);
            this.cb_seccion.TabIndex = 12;
            // 
            // nombre_profesortxt
            // 
            this.nombre_profesortxt.Enabled = false;
            this.nombre_profesortxt.Location = new System.Drawing.Point(133, 111);
            this.nombre_profesortxt.Name = "nombre_profesortxt";
            this.nombre_profesortxt.Size = new System.Drawing.Size(346, 20);
            this.nombre_profesortxt.TabIndex = 7;
            this.nombre_profesortxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_profesortxt_KeyPress);
            // 
            // nombre_alumnotxt
            // 
            this.nombre_alumnotxt.Enabled = false;
            this.nombre_alumnotxt.Location = new System.Drawing.Point(133, 74);
            this.nombre_alumnotxt.Name = "nombre_alumnotxt";
            this.nombre_alumnotxt.Size = new System.Drawing.Size(346, 20);
            this.nombre_alumnotxt.TabIndex = 6;
            this.nombre_alumnotxt.TextChanged += new System.EventHandler(this.nombre_alumnotxt_TextChanged);
            this.nombre_alumnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_alumnotxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Profesor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Alumno";
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(542, 189);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(93, 38);
            this.nuevobutton.TabIndex = 1;
            this.nuevobutton.Text = "NUEVO";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(541, 238);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(94, 38);
            this.modificarbutton.TabIndex = 2;
            this.modificarbutton.Text = "MODIFICAR";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Enabled = false;
            this.guardarbutton.Location = new System.Drawing.Point(654, 189);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(93, 38);
            this.guardarbutton.TabIndex = 3;
            this.guardarbutton.Text = "GUARDAR";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Enabled = false;
            this.cancelarbutton.Location = new System.Drawing.Point(541, 282);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(94, 38);
            this.cancelarbutton.TabIndex = 4;
            this.cancelarbutton.Text = "CANCELAR";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // datosdataGrid
            // 
            this.datosdataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosdataGrid.Location = new System.Drawing.Point(3, 326);
            this.datosdataGrid.Name = "datosdataGrid";
            this.datosdataGrid.Size = new System.Drawing.Size(743, 163);
            this.datosdataGrid.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(653, 238);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(94, 38);
            this.eliminarbutton.TabIndex = 7;
            this.eliminarbutton.Text = "ELIMINAR";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // salirbutton
            // 
            this.salirbutton.Location = new System.Drawing.Point(653, 282);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(93, 38);
            this.salirbutton.TabIndex = 8;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // FormGrado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 501);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datosdataGrid);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormGrado1";
            this.Text = "INFORMACION";
            this.Load += new System.EventHandler(this.FormGrado1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button modificarbutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.DataGridView datosdataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nombre_profesortxt;
        private System.Windows.Forms.TextBox nombre_alumnotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_seccion;
        private System.Windows.Forms.TextBox nota_finaltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox codigo_alumnotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_grado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button salirbutton;
    }
}