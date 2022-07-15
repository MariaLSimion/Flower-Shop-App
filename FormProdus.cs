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
    public partial class FormProdus : Form
    {
        public Produs produs;
        public Form1 parinte;
        public FormProdus()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\smari\OneDrive\Desktop\Useri-Clienti.mdb");

        public void ActualizeazaControale(object sender, EventArgs e)
        {
            ListView lista1 = (ListView)sender;

            if (lista1.SelectedItems.Count > 0)
                produs = (Produs)lista1.SelectedItems[0].Tag;

            if (produs != null)
            {
                textBoxCodP.Text = produs.Cod_produs;
                textBoxDenumireP.Text = produs.Denumire;
                textBoxBucatiP.Text = produs.Nr_buc_stoc.ToString();
                textBoxPretP.Text = produs.Pret.ToString();
            }
        }

        private void buttonAdaugaP_Click(object sender, EventArgs e)
        {
            produs.Cod_produs = textBoxCodP.Text;
            produs.Denumire = textBoxDenumireP.Text;
            produs.Nr_buc_stoc = Convert.ToInt32(textBoxBucatiP.Text);
            try
            {
                produs.Pret = Convert.ToDouble(textBoxPretP.Text);
            }

            catch(Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
            this.parinte.UpdateItems();


            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Tabel_Produse values('" + textBoxCodP.Text + "','" + textBoxDenumireP.Text + "','" + textBoxBucatiP.Text + "','" + textBoxPretP.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Produsul a fost inregistrat cu succes in baza de date!", "Inregistrare cu succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void textBoxCodP_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxCodP.Text))
            {
                e.Cancel = true;
                textBoxCodP.Focus();
                errorProviderCod.SetError(textBoxCodP, "Va rog sa introduceti un cod!");
                labelerrCod.Text = "Va rog sa introduceti un cod!";
            }
           
        }

        private void textBoxCodP_Validated(object sender, EventArgs e)
        {
            errorProviderCod.SetError(textBoxCodP, "");
        }

        private void textBoxDenumireP_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxDenumireP.Text.Length<2)
            {
                errorProviderDenumire.SetError(textBoxDenumireP, "Denumirea nu este Valida!");
                e.Cancel = true;
            }
        }

        private void textBoxDenumireP_Validated(object sender, EventArgs e)
        {
            errorProviderDenumire.SetError(textBoxDenumireP, "");
        }

        private void textBoxBucatiP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=!char.IsDigit(e.KeyChar))
            {
                errorProviderNumarBuc.SetError(labelerrNrB, "Va rog introduceti o valoare numerica!");
                labelerrNrB.Text = "Va rog introduceti o valoare numerica!";
               
            }
            else
            {
                errorProviderNumarBuc.SetError(labelerrNrB, "");
                labelerrNrB.Text = "";
            }
        }

        private void textBoxBucatiP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBucatiP.Text))
            {
                e.Cancel = true;
                textBoxBucatiP.Focus();
                errorProviderNumarBuc.SetError(textBoxBucatiP, "Va rog sa introduceti un nr de bucati!");
                
            }
        }

        private void textBoxBucatiP_Validated(object sender, EventArgs e)
        {
            errorProviderNumarBuc.SetError(textBoxBucatiP, "");
        }

        private void textBoxPretP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPretP.Text))
            {
                e.Cancel = true;
                textBoxPretP.Focus();
                errorProviderPretBuc.SetError(textBoxPretP, "Va rog sa introduceti un pret!");
                labelerrPret.Text = "Va rog sa introduceti un pret!";
            }


        }

        private void textBoxPretP_Validated(object sender, EventArgs e)
        {
            errorProviderPretBuc.SetError(textBoxPretP, "");
        }

        private void textBoxCodP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
                textBoxCodP.Focus();
        }

        private void textBoxDenumireP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
                textBoxDenumireP.Focus();
        }

        private void textBoxBucatiP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
                textBoxBucatiP.Focus();
        }

        private void textBoxPretP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
                textBoxPretP.Focus();
        }
    }
}
