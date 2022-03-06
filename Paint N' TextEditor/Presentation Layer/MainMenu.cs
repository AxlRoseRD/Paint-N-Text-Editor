using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoPanel info = new InfoPanel();
            info.Show();
        }

        private void textEditorWindow(object sender, EventArgs e)
        {
            TextEditor te = new TextEditor();
            te.Show();

            this.Hide();
        }

        private void paintWindow(object sender, EventArgs e)
        {
            Paint pa = new Paint();
            pa.Show();

            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            TextEditor te = new TextEditor();           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
