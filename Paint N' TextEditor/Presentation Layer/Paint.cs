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
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void goBack(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Dispose();            
        }

        private void Paint_Load(object sender, EventArgs e)
        {

        }
    }
}
