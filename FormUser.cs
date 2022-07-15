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
    public partial class FormInregistrare : Form
    {
        public FormInregistrare()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\smari\OneDrive\Desktop\Useri-Clienti.mdb");
        
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text =="" || textBoxPassword.Text=="" || textBoxConfirmPass.Text=="" || textBoxNume.Text=="" || textBoxPrenume.Text=="" || textBoxTelefon.Text=="" || textBoxAdresa.Text=="" )//ca sa ne asiguram ca nu sunt goale campurile
            {
                MessageBox.Show("Nu ati completat toate campurile! ", "Inregistrarea a esuat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == textBoxConfirmPass.Text)//pentru a verifica daca parolele se potrivesc 
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into Tabel_User values('"+textBoxUsername.Text+"','"+textBoxPassword.Text+"','"+textBoxNume.Text+"','"+textBoxPrenume.Text+"','"+textBoxTelefon.Text+"','"+textBoxAdresa.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxUsername.Text = "";//pentru a seta cele 3 campuri goale
                textBoxPassword.Text = "";
                textBoxConfirmPass.Text = "";
                textBoxNume.Text = "";
                textBoxPrenume.Text = "";
                textBoxTelefon.Text = "";
                textBoxAdresa.Text = "";
                textBoxUsername.Focus();


                MessageBox.Show("Contul dumneavoastra a fost creat cu succes! ", "Inregistrare cu succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Parolele nu se potrivesc, va rugam sa le reintroduceti!", "Inregistrare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPass.Text = "";
                textBoxPassword.Focus();

            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';//alt+7 pt a obtine simbolul
                textBoxConfirmPass.PasswordChar = '•';//am trecut simbolul si la textboxurile password si confirm pass la proprietatea PasswordChar
            }
        }

        private void buttonClearCampuri_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPass.Text = "";
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxTelefon.Text = "";
            textBoxAdresa.Text = "";
            textBoxUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxTelefon.Text.Length<10)
            {
                errorProviderTel.SetError(textBoxTelefon, "Introduceti 10 caractere!");
                e.Cancel = true;
            }
        }

        private void textBoxTelefon_Validated(object sender, EventArgs e)
        {
            errorProviderTel.SetError(textBoxTelefon, "");

        }
    }
}
