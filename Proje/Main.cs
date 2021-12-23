using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Proje
{
    public partial class Main : Form
    {

         [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

         private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
         );
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pictureBox9.Load("https://i0.wp.com/digital-photography-school.com/wp-content/uploads/2011/11/square-format-01.jpg?resize=600%2C600&ssl=1");
        }

        

 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Enter(object sender, EventArgs e)
        {
            if(aramacubugu.Text !="")
            {
                aramacubugu.Text = "";
            }
        }

        private void Leave(object sender, EventArgs e)
        {
            aramacubugu.Text = "Al-sat'da ara...";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonlogin.Height;
            pnlNav.Top = buttonlogin.Top;
            buttonlogin.BackColor = Color.FromArgb(46, 51, 73);
           

        }
        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(33, 40, 66);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(33, 40, 66);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(33, 40, 66);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(33, 40, 66);
        }

        private void buttonlogin_Leave(object sender, EventArgs e)
        {
            buttonlogin.BackColor = Color.FromArgb(33, 40, 66);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
