using System;
using System.Windows.Forms;
using Entidades;
namespace Vista
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;
            txtApellido.Text = persona.Apellido;
            txtNombre.Text = persona.Nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;

            try
            {
                Persona nuevaPersona = new Persona(txtNombre.Text, txtApellido.Text);
                PersonaDAO.Modificar(persona.Id, nuevaPersona);
                lstPersonas.DataSource = PersonaDAO.Leer();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona nuevaPersona = new Persona(txtNombre.Text, txtApellido.Text);
                PersonaDAO.Guardar(nuevaPersona);
                lstPersonas.DataSource = PersonaDAO.Leer();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = (Persona)lstPersonas.SelectedItem;
                PersonaDAO.Borrar(persona.Id);
                lstPersonas.DataSource = PersonaDAO.Leer();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
