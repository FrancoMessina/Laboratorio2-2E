using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmSaludo : Form
    {
        public frmSaludo()
        {
            InitializeComponent();
        }
        public frmSaludo(string nombre, string apellido):this()
        {
            this.lblSaludo.Text = $"Soy {nombre} {apellido} ";
        }
        public frmSaludo(string nombre, string apellido, string materia) : this(nombre,apellido)
        {
            this.lblSaludo.Text += $"y mi materia favorita es {materia}.";
        }
    }
}
