using System;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmLlamador : Form
    {
        public FrmLlamador()
        {
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }
    }
}
