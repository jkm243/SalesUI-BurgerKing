using System;
using System.Windows.Forms;

namespace SalesUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            home_UC1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burgerking.ru/");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burgerking.ru/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/jacques_katsuva/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/BurgerKingRussia");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/burgerkingrus");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            home_UC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            eat_In_UC2.BringToFront();
            SidePanel.Top = button2.Top;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button5.Top;
            SidePanel.Height = button5.Height;
            maps2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button6.Top;
            SidePanel.Height = button6.Height;
            pay1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button7.Top;
            SidePanel.Height = button7.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            label18.Text = thisDay.ToString("D");
        }
    }
}
