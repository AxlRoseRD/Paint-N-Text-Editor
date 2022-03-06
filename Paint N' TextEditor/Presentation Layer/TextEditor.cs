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

namespace Presentation_Layer
{
    public partial class TextEditor : Form
    {

        //instance
        string title = "Text Editor";
        string path = @"C:\users\~\Documents\New File.txt";

        public TextEditor()
        {
            InitializeComponent();
            filePath.Text = path;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath.Text))
            {
                saveFileDialog1.FileName = "New File.txt";
                var save = saveFileDialog1.ShowDialog();
                if (save == DialogResult.OK)
                {
                    using (var save_File = new System.IO.StreamWriter(saveFileDialog1.FileName))
                    {
                        save_File.WriteLine(TextBox1.Text);
                        save_File.Close();
                    }
                }
                filePath.Text = saveFileDialog1.FileName;
                path = filePath.Text;
                statusNotify.Text = "Guardado";
            }
            else
            {
                File.WriteAllText(path, TextBox1.Text);
                statusNotify.Text = "Actualizado";
               
            }            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string t;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            t = file.ReadToEnd();
            TextBox1.Text = t.ToString();

            filePath.Text = openFileDialog1.FileName;
            path = filePath.Text;

            file.Close();
            statusNotify.Text = "";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "New File.txt";
            var save = saveFileDialog1.ShowDialog();
            if (save == DialogResult.OK)
            {
                using (var save_File = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    save_File.WriteLine(TextBox1.Text);
                }
            }
            filePath.Text = saveFileDialog1.FileName;
            path = filePath.Text;
            statusNotify.Text = "Guardado";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = @"C:\users\~\Documents\New File.txt";
            filePath.Text = path;
            statusNotify.Text = "";
            TextBox1.Clear();                
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //cargar la ventana colordialog en esta variable:
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {                
                TextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Copy();
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Cut();
        }

        private void opcionAtras_Click(object sender, EventArgs e)
        {
            TextBox1.Undo();
        }

        private void opcionAdelante_Click(object sender, EventArgs e)
        {
            TextBox1.Redo();
        }

        private void opcionSeleccionarTodo_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void opcionEliminarTodo_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK) 
            {
                TextBox1.Font = fontDialog1.Font;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
