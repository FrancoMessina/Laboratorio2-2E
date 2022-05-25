using System;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmLlamador : Form
    {
        private readonly Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            cmbFranja.Enabled = false;
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
         
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterico_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            }
            else
                cmbFranja.Enabled = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            //El TextBox situado por debajo del botón btnLimpiar será el txtNroOrigen.
            //La duración será un número aleatorio entre 1 y 50.
            //El costo, en caso de necesitarlo, será un número aleatorio entre 0,5 y 5,6.
            //El combo cmbFranja, situado al final del formulario, será el encargado de colocar una
            //franja horaria a las llamadas provinciales. Cargar desde el Enumerado utilizando el siguiente código:
            Random rnd = new Random();
            float duracion;
            if(!string.IsNullOrEmpty(txtNroDestino.Text) && !string.IsNullOrEmpty(txtNroOrigen.Text))
            {
                duracion = rnd.Next(1, 50);

            }
        }
    }
}
