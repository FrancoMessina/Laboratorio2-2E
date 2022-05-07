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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = "";
            if (cmbMateria.SelectedItem != null)
                materia = (string)cmbMateria.SelectedItem;

            if(!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                frmSaludo saludo = new frmSaludo(nombre, apellido, materia);
                saludo.ShowDialog();
            }
            else if(string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(apellido))
                MessageBox.Show($"Se deben completar los siguientes campos: \n" +
                    $"{txtNombre.Tag}\n" +
                    $"{txtApellido.Tag}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if(string.IsNullOrWhiteSpace(nombre))
                MessageBox.Show($"Se deben completar los siguientes campos: \n" +
                    $"{txtNombre.Tag}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"Se deben completar los siguientes campos: \n" +
                    $"{txtApellido.Tag}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            //this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;
        }
    }
}