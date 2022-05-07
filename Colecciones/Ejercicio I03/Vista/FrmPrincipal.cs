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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();
            List<string> list = rtbMensaje.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            int contador = 0;
            int maximo;
            StringBuilder mensaje = new StringBuilder();
            foreach (string palabra in list)
            {
                if (palabras.ContainsKey(palabra))
                {
                    palabras[palabra] = palabras[palabra] + 1;

                }
                else
                {
                    palabras.Add(palabra, 1);
                }
            }

            do 
            {
                maximo = palabras.Values.Max();
                
                foreach (KeyValuePair<string, int> palabra in palabras)
                {
                    
                    if (palabra.Value == maximo)
                    {
                        contador++;
                        palabras.Remove(palabra.Key);
                        mensaje.AppendLine($"Palabra es : {palabra.Key} y cantidad de veces en el texto {maximo}");
                    }
                }
            } while (contador != 3 );
            MessageBox.Show(mensaje.ToString());
        }
    }
}
