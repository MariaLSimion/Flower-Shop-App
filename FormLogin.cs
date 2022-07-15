using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_paw_incercarea_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\smari\OneDrive\Desktop\Useri-Clienti.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = " SELECT * FROM Tabel_User WHERE username= '" + textBoxUsername.Text + "'and password= '" + textBoxPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            if(dr.Read() == true)//sa verificam daca userul si parola se potrivesc
            {
                new FormHome().Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("User sau parola invalida! Va rog sa incercati din nou", "Logare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                
            }
            con.Close();
        }

        private void buttonClearCampuri_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormInregistrare().Show();
            this.Hide();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';

            }
            else
            {
                textBoxPassword.PasswordChar = '•';
            }
        }
    }
}
