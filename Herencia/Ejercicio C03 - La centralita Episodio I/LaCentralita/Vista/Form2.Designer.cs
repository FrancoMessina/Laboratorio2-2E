namespace Vista
{
    partial class FrmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.gpbPanel = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnAsterico = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gpbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Multiline = true;
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.PlaceholderText = "NroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(290, 38);
            this.txtNroDestino.TabIndex = 0;
            // 
            // gpbPanel
            // 
            this.gpbPanel.Controls.Add(this.btnNumeral);
            this.gpbPanel.Controls.Add(this.btnCero);
            this.gpbPanel.Controls.Add(this.btnAsterico);
            this.gpbPanel.Controls.Add(this.btnNueve);
            this.gpbPanel.Controls.Add(this.btnOcho);
            this.gpbPanel.Controls.Add(this.btnSiete);
            this.gpbPanel.Controls.Add(this.btnSeis);
            this.gpbPanel.Controls.Add(this.btnCinco);
            this.gpbPanel.Controls.Add(this.btnCuatro);
            this.gpbPanel.Controls.Add(this.btnTres);
            this.gpbPanel.Controls.Add(this.btnDos);
            this.gpbPanel.Controls.Add(this.btnUno);
            this.gpbPanel.Location = new System.Drawing.Point(12, 65);
            this.gpbPanel.Name = "gpbPanel";
            this.gpbPanel.Size = new System.Drawing.Size(177, 231);
            this.gpbPanel.TabIndex = 1;
            this.gpbPanel.TabStop = false;
            this.gpbPanel.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(121, 189);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(39, 36);
            this.btnNumeral.TabIndex = 13;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(64, 189);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(39, 36);
            this.btnCero.TabIndex = 12;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnAsterico
            // 
            this.btnAsterico.Location = new System.Drawing.Point(6, 189);
            this.btnAsterico.Name = "btnAsterico";
            this.btnAsterico.Size = new System.Drawing.Size(39, 36);
            this.btnAsterico.TabIndex = 11;
            this.btnAsterico.Text = "*";
            this.btnAsterico.UseVisualStyleBackColor = true;
            this.btnAsterico.Click += new System.EventHandler(this.btnAsterico_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(121, 136);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(39, 36);
            this.btnNueve.TabIndex = 10;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(64, 136);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(39, 36);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(6, 136);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(39, 36);
            this.btnSiete.TabIndex = 8;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(121, 83);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(39, 36);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(64, 83);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(39, 36);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(6, 83);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(39, 36);
            this.btnCuatro.TabIndex = 5;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(121, 33);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(39, 36);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(64, 33);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(39, 36);
            this.btnDos.TabIndex = 3;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(6, 33);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(39, 36);
            this.btnUno.TabIndex = 2;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(223, 104);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(151, 30);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(223, 154);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Location = new System.Drawing.Point(223, 207);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(151, 23);
            this.txtNroOrigen.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Limpiar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cmbFranja
            // 
            this.cmbFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(18, 321);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(356, 23);
            this.cmbFranja.TabIndex = 6;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 356);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.gpbPanel);
            this.Controls.Add(this.txtNroDestino);
            this.Name = "FrmLlamador";
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gpbPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox gpbPanel;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnAsterico;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}