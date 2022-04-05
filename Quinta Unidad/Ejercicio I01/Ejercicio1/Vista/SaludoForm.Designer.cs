namespace Vista
{
    partial class frmSaludo
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
            this.lblMensajeBienvenidad = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeBienvenidad
            // 
            this.lblMensajeBienvenidad.AutoSize = true;
            this.lblMensajeBienvenidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeBienvenidad.Location = new System.Drawing.Point(17, 63);
            this.lblMensajeBienvenidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeBienvenidad.Name = "lblMensajeBienvenidad";
            this.lblMensajeBienvenidad.Size = new System.Drawing.Size(280, 32);
            this.lblMensajeBienvenidad.TabIndex = 0;
            this.lblMensajeBienvenidad.Text = "¡Hola, Windows Forms!";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(17, 137);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 32);
            this.lblSaludo.TabIndex = 1;
            // 
            // frmSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 328);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblMensajeBienvenidad);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSaludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeBienvenidad;
        private System.Windows.Forms.Label lblSaludo;
    }
}