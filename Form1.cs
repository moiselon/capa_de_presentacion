using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        editor_de_texto formularionombre;
        paints formulario;
        public Form1()
        {
            InitializeComponent();

            formularionombre = new editor_de_texto();
            formulario = new paints();
        }

        private void btneditortexto_Click(object sender, EventArgs e)
        {
            formularionombre.ShowDialog();
            
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            formulario.ShowDialog();
        }
    }
}
