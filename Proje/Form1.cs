using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mailTextbox_Click(object sender, EventArgs e)
        {
            sifreTextbox.Text = "";
        }

        private void bunifuMaterialTextbox4_Click(object sender, EventArgs e)
        {
            mailTextbox.Text = "";
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
