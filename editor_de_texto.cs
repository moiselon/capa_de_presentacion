using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class editor_de_texto : Form
    {
        public editor_de_texto()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")

            {
                DialogResult rs = MessageBox.Show("modificaste el archivo, desea guardalo?", "mensaje", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)

                {
                    saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Guardar Archivo de texto";
                    saveFileDialog1.Filter = "archivo de texto (.txt) | * txt";

                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.AddExtension = true;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                    {
                        string ruta = saveFileDialog1.FileName;

                        StreamWriter fs = new StreamWriter(ruta);
                        fs.Write(textBox1.Text);
                        fs.Close();
                        MessageBox.Show("Se guardo el archivo: " + saveFileDialog1.FileName);
                    }

                    else

                    {
                        MessageBox.Show("has cancelado");
                    }

                    saveFileDialog1.Dispose();
                    saveFileDialog1 = null; ;
                }
            }

            textBox1.Text = "";
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "open text file";
            oFD.Filter = "txt files | *. txt";
            oFD.InitialDirectory = @"C:\Escritorio";
            oFD.FileName = this.textBox1.Text;

            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = oFD.FileName;
                label1.Text = textBox1.Text;
            }

            System.IO.StreamReader sr = new System.IO.StreamReader(@textBox1.Text, System.Text.Encoding.Default);
            string texto;
            texto = sr.ReadToEnd();
            sr.Close();
            textBox1.Text = texto;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "GUARDAR ARCHIVO DE TEXTO";
            saveFileDialog1.Filter = "ARCHIVO DE TEXTO (.txt)|*.txt";


            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;

                StreamWriter fs = new StreamWriter(ruta);
                fs.Write(textBox1.Text);
                fs.Close();
                MessageBox.Show("se guardo el archivo" + saveFileDialog1.FileName);



            }

            else
            {
                MessageBox.Show("has cancelado");
            }

            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject idata = Clipboard.GetDataObject();
            textBox1.Text = (string)idata.GetData(DataFormats.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void wxirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
                textBox1.Text = "";
            }
        }
    }
    }
    
