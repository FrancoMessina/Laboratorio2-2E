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
    public partial class frmRegistro : Form
    {
        public string genero = "";
        public string[] cursos = new string[3];
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            List<string> listaPaises = new List<string>();
            CargarListaPaises(listaPaises);
            CargarListBoxPaises(listaPaises);

        }
        private List<string> CargarListaPaises(List<string> listaPaises)
        {
            listaPaises.Add("Argentina");
            listaPaises.Add("Chile");
            listaPaises.Add("Uruguay");    
            return listaPaises;
        }
        private bool CargarListBoxPaises(List<string> listaPaises)
        {
            if(listaPaises != null)
            {
                lbPais.DataSource = listaPaises;
                return true;
            }
            return false;                
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(genero) && !string.IsNullOrEmpty(lbPais.SelectedItem.ToString()) && ValidarCursos())
            {
                Ingresante ingresante = new Ingresante(txtNombre.Text, txtDireccion.Text, genero, lbPais.SelectedItem.ToString(),cursos , nupEdad.Value);
                MessageBox.Show(ingresante.Mostrar());
            }
            else
            {
                MessageBox.Show("Error revisa que los campos esten completos");
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = rbMasculino.Text;
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = rbFemenino.Text;
        }

        private void rbNoBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = rbNoBinario.Text;
        }

        private void ckbCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCSharp.Checked)
                cursos[0] = ckbCSharp.Text;
            else
                cursos[0] = "";
        }

        private void ckbCMas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCMas.Checked)
                cursos[1] = ckbCMas.Text;
            else
                cursos[1] = "";
        }

        private void ckbJavascript_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbJavascript.Checked)
                cursos[2] = ckbJavascript.Text;
            else
                cursos[2] = "";
        }
        private bool ValidarCursos() //Existen Cursos?
        {
            foreach (string curso in cursos)
            {
                if (curso != "" && curso is not null)
                    return true;
            }
            return false;
        }
    }
}
