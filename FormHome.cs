using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_paw_incercarea_2
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            panelNavigator.Height = buttonHome.Height;
            panelNavigator.Top = buttonHome.Top;
            panelNavigator.Left = buttonHome.Left;
            buttonHome.BackColor = Color.FromArgb(46, 62, 73);

            this.panelFormLoader.Controls.Clear();
            FormHomeDash fhd = new FormHomeDash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fhd.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(fhd);
            fhd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelNavigator.Height = buttonHome.Height;
            panelNavigator.Top = buttonHome.Top;
            panelNavigator.Left = buttonHome.Left;
            buttonHome.BackColor = Color.FromArgb(46, 62, 73);

            this.panelFormLoader.Controls.Clear();
            FormHomeDash fhd = new FormHomeDash() {Dock= DockStyle.Fill, TopLevel=false, TopMost=true };
            fhd.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(fhd);
            fhd.Show();

        }  

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            panelNavigator.Height = buttonCatalog.Height;
            panelNavigator.Top = buttonCatalog.Top;
            panelNavigator.Left = buttonCatalog.Left;
            buttonCatalog.BackColor = Color.FromArgb(46, 62, 73);

            FormCatalog fc = new FormCatalog();
            fc.Show();

        }

        private void buttonComandaNoua_Click(object sender, EventArgs e)
        {
            panelNavigator.Height = buttonComandaNoua.Height;
            panelNavigator.Top = buttonComandaNoua.Top;
            panelNavigator.Left = buttonComandaNoua.Left;
            buttonComandaNoua.BackColor = Color.FromArgb(46, 62, 73);

            Form_Comand fcom = new Form_Comand();
            fcom.Show();
        }

        private void buttonStoc_Click(object sender, EventArgs e)
        {
            panelNavigator.Height = buttonStoc.Height;
            panelNavigator.Top = buttonStoc.Top;
            panelNavigator.Left = buttonStoc.Left;
            buttonStoc.BackColor = Color.FromArgb(46, 62, 73);

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonHome_Leave(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(255,192,192);
        }

        private void buttonCatalog_Leave(object sender, EventArgs e)
        {
            buttonCatalog.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void buttonComandaNoua_Leave(object sender, EventArgs e)
        {
            buttonComandaNoua.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void buttonStoc_Leave(object sender, EventArgs e)
        {
            buttonStoc.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
