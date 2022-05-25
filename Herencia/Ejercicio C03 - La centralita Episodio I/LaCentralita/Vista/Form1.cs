using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Vista
{
    public partial class frmMenu : Form
    {
        public static Centralita centralita;
        public frmMenu()
        {
            centralita = new Centralita("Centralita");
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }
    }
}
