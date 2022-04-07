namespace Vista
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDetalleUsuario = new System.Windows.Forms.GroupBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.ckbJavascript = new System.Windows.Forms.CheckBox();
            this.ckbCMas = new System.Windows.Forms.CheckBox();
            this.ckbCSharp = new System.Windows.Forms.CheckBox();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.gpGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbDetalleUsuario
            // 
            this.gbDetalleUsuario.Controls.Add(this.nupEdad);
            this.gbDetalleUsuario.Controls.Add(this.lblEdad);
            this.gbDetalleUsuario.Controls.Add(this.txtDireccion);
            this.gbDetalleUsuario.Controls.Add(this.lblDireccion);
            this.gbDetalleUsuario.Controls.Add(this.txtNombre);
            this.gbDetalleUsuario.Controls.Add(this.lblNombre);
            this.gbDetalleUsuario.Location = new System.Drawing.Point(24, 40);
            this.gbDetalleUsuario.Name = "gbDetalleUsuario";
            this.gbDetalleUsuario.Size = new System.Drawing.Size(249, 189);
            this.gbDetalleUsuario.TabIndex = 1;
            this.gbDetalleUsuario.TabStop = false;
            this.gbDetalleUsuario.Text = "Detalles del usuario";
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(86, 136);
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(100, 23);
            this.nupEdad.TabIndex = 6;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 138);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(86, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 96);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // gpGenero
            // 
            this.gpGenero.Controls.Add(this.rbNoBinario);
            this.gpGenero.Controls.Add(this.rbFemenino);
            this.gpGenero.Controls.Add(this.rbMasculino);
            this.gpGenero.Location = new System.Drawing.Point(321, 40);
            this.gpGenero.Name = "gpGenero";
            this.gpGenero.Size = new System.Drawing.Size(143, 142);
            this.gpGenero.TabIndex = 2;
            this.gpGenero.TabStop = false;
            this.gpGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(19, 89);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            this.rbNoBinario.CheckedChanged += new System.EventHandler(this.rbNoBinario_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(19, 64);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(19, 39);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.ckbJavascript);
            this.gbCursos.Controls.Add(this.ckbCMas);
            this.gbCursos.Controls.Add(this.ckbCSharp);
            this.gbCursos.Location = new System.Drawing.Point(321, 188);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(143, 109);
            this.gbCursos.TabIndex = 3;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // ckbJavascript
            // 
            this.ckbJavascript.AutoSize = true;
            this.ckbJavascript.Location = new System.Drawing.Point(14, 82);
            this.ckbJavascript.Name = "ckbJavascript";
            this.ckbJavascript.Size = new System.Drawing.Size(78, 19);
            this.ckbJavascript.TabIndex = 6;
            this.ckbJavascript.Text = "JavaScript";
            this.ckbJavascript.UseVisualStyleBackColor = true;
            this.ckbJavascript.CheckedChanged += new System.EventHandler(this.ckbJavascript_CheckedChanged);
            // 
            // ckbCMas
            // 
            this.ckbCMas.AutoSize = true;
            this.ckbCMas.Location = new System.Drawing.Point(14, 57);
            this.ckbCMas.Name = "ckbCMas";
            this.ckbCMas.Size = new System.Drawing.Size(50, 19);
            this.ckbCMas.TabIndex = 5;
            this.ckbCMas.Text = "C++";
            this.ckbCMas.UseVisualStyleBackColor = true;
            this.ckbCMas.CheckedChanged += new System.EventHandler(this.ckbCMas_CheckedChanged);
            // 
            // ckbCSharp
            // 
            this.ckbCSharp.AutoSize = true;
            this.ckbCSharp.Location = new System.Drawing.Point(14, 32);
            this.ckbCSharp.Name = "ckbCSharp";
            this.ckbCSharp.Size = new System.Drawing.Size(41, 19);
            this.ckbCSharp.TabIndex = 4;
            this.ckbCSharp.Text = "C#";
            this.ckbCSharp.UseVisualStyleBackColor = true;
            this.ckbCSharp.CheckedChanged += new System.EventHandler(this.ckbCSharp_CheckedChanged);
            // 
            // lbPais
            // 
            this.lbPais.FormattingEnabled = true;
            this.lbPais.ItemHeight = 15;
            this.lbPais.Location = new System.Drawing.Point(24, 270);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(239, 94);
            this.lbPais.TabIndex = 4;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(25, 246);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(355, 336);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 28);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 412);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gpGenero);
            this.Controls.Add(this.gbDetalleUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gbDetalleUsuario.ResumeLayout(false);
            this.gbDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.gpGenero.ResumeLayout(false);
            this.gpGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbDetalleUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.GroupBox gpGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox ckbJavascript;
        private System.Windows.Forms.CheckBox ckbCMas;
        private System.Windows.Forms.CheckBox ckbCSharp;
        private System.Windows.Forms.ListBox lbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
