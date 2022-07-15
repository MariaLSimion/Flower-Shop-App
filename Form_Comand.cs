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
    public partial class Form_Comand : Form
    {
        const double Taxa_Transport = 15;
        const double Taxa_Ambalaj = 2.5;

        double var_Subtotal, var_Total;

        Produs p1 = new Produs("1", "Crizantema", 44, 2.5);
        Produs p2 = new Produs("2", "Crin", 50, 5);
        Produs p3 = new Produs("3", "Trandafir", 120, 8);
        Produs p4 = new Produs("4", "Frezie", 70, 6);
        Produs p5 = new Produs("5", "Crin imperial", 45, 10.50);
        Produs p6 = new Produs("6", "Lalea", 70, 6);
        Produs p7 = new Produs("7", "Gerbera", 90, 4.5);
        Produs p8 = new Produs("8", "Zambila", 50, 7);
        Produs p9 = new Produs("9", "Iris", 100, 3.4);
        Produs p10 = new Produs("10", "Orhidee", 30, 10);

        

        

        public Form_Comand()
        {
            InitializeComponent();
            //checkbox-urile vor prelua drept text denumirea obiectelor
            checkBox1.Text = p1.Denumire;
            checkBox2.Text = p2.Denumire;
            checkBox3.Text = p3.Denumire;
            checkBox4.Text = p4.Denumire;
            checkBox5.Text = p5.Denumire;
            checkBox6.Text = p6.Denumire;
            checkBox7.Text = p7.Denumire;
            checkBox8.Text = p8.Denumire;
            checkBox9.Text = p9.Denumire;
            checkBox10.Text = p10.Denumire;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }
        //butonul anulare
        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            DialogResult iAnulare;
            iAnulare = MessageBox.Show("Confirmati anularea comenzii!", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iAnulare== DialogResult.Yes)
            {
               
                FormHome fh = new FormHome();
                fh.Show();
                
            }
        }
        private void ResetareTextBox()//functie pentru resetarea text boxurilor la 0
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
             {
                 foreach (Control control in controls)
                     if (control is TextBox)
                     {
                         DateTime idate = DateTime.Now;
                         (control as TextBox).Text = "0";
                         textBoxDataCom.Text = idate.ToString("dd/MM/yyyy");
                         textBoxOraCom.Text = idate.ToString("HH:mm:ss");
                         textBoxDataCom.Enabled = true;
                         textBoxOraCom.Enabled = true;
                         //textBoxINFO.AppendText("\t\t\t" + "Informare!" + Environment.NewLine);
                         textBoxINFO.AppendText(Environment.NewLine + "Pentru produsele din catalog pe care nu le regasiti aici este nevoie de comanda speciala, telefonica");
                     }
                     else
                     { func(control.Controls);
                         DateTime idate = DateTime.Now;
                         textBoxDataCom.Text = idate.ToString("dd/MM/yyyy");
                         textBoxOraCom.Text = idate.ToString("HH:mm:ss");
                         textBoxDataCom.Enabled = true;
                         textBoxOraCom.Enabled = true;
                        
                         
                     }
             };
            func(Controls);
        }

        private void CheckBoxResetare()//functie reseratre checkbox
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBox() //functie pentru activare textbox
        { 
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled=false;
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void Form_Comand_Load(object sender, EventArgs e)
        {
            //adaugare valori in combobox
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Card");


            //initializare textbox 
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox21.Text = "0";
            textBox28.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox27.Text = "0";
            textBoxINFO.AppendText("\t\t\t" + "Informare!" + Environment.NewLine);
            textBoxINFO.AppendText(Environment.NewLine + "Pentru produsele din catalog pe care nu le regasiti aici este nevoie de comanda speciala, telefonica.");

            //data si ora
            DateTime idate = DateTime.Now;

            textBoxDataCom.Text = idate.ToString("dd/MM/yyyy");
            textBoxOraCom.Text = idate.ToString("HH:mm:ss");
            EnableTextBox();
        }

        //butonul resetare
        private void buttonResetare_Click(object sender, EventArgs e)
        {
            ResetareTextBox();
            CheckBoxResetare();
            
        }
        //==================================================================
        //se verifica fiecare checkbox in parte daca e check-uit
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
                
            }    
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();

            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();

            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();

            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();

            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();

            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();

            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();

            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }
        //=================================================================

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Cash") //cand se seteaza cash se activeaza textbox-ul de introducere valoare 
            {
                textBox28.Enabled = true;
                textBox28.Text = "";
                textBox28.Focus();
            }
            else
            {
                textBox28.Enabled = false;
                textBox28.Text = "0";

            }
        }
        //buton total
        private void buttonTotal_Click(object sender, EventArgs e)
        {
            double[] costbuc = new double[10]; //vector de preturi
            try
            {
                costbuc[0] = Convert.ToDouble(textBox1.Text) * p1.Pret;//cantitatea * pret = cost
                costbuc[1] = Convert.ToDouble(textBox2.Text) * p2.Pret;
                costbuc[2] = Convert.ToDouble(textBox3.Text) * p3.Pret;
                costbuc[3] = Convert.ToDouble(textBox4.Text) * p4.Pret;
                costbuc[4] = Convert.ToDouble(textBox5.Text) * p5.Pret;
                costbuc[5] = Convert.ToDouble(textBox6.Text) * p6.Pret;
                costbuc[6] = Convert.ToDouble(textBox7.Text) * p7.Pret;
                costbuc[7] = Convert.ToDouble(textBox8.Text) * p8.Pret;
                costbuc[8] = Convert.ToDouble(textBox9.Text) * p9.Pret;
                costbuc[9] = Convert.ToDouble(textBox10.Text) * p10.Pret;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            double cost, valoare_introdusa ;//pt rest

            if(comboBox1.Text=="Cash")
            {
                
                try
                {
                    var_Subtotal = costbuc[0] + costbuc[1] + costbuc[2] + costbuc[3] + costbuc[4] + costbuc[5] + costbuc[6] + costbuc[7] + costbuc[8] + costbuc[9];

                    textBox24.Text = Convert.ToString(var_Subtotal);
                    textBox23.Text = Convert.ToString(Taxa_Ambalaj);
                    textBox22.Text = Convert.ToString(Taxa_Transport);
                    var_Total = (var_Subtotal + Taxa_Transport + Taxa_Ambalaj);
                    textBox27.Text = Convert.ToString(var_Total);
                    valoare_introdusa = Convert.ToDouble(textBox28.Text);
                    cost = valoare_introdusa - var_Total;
                    textBox21.Text = Convert.ToString(cost);
                    if (cost < 0)
                    {
                        MessageBox.Show("Suma introdusa este prea mica!! Introduceti o suma corecta sau puteti opta pentru plata cu cardul. ", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }

                
            }
            else
            {
                var_Subtotal = costbuc[0] + costbuc[1] + costbuc[2] + costbuc[3] + costbuc[4] + costbuc[5] + costbuc[6] + costbuc[7] + costbuc[8] + costbuc[9];

                textBox24.Text = Convert.ToString(var_Subtotal);
                textBox23.Text = Convert.ToString(Taxa_Ambalaj);
                textBox22.Text = Convert.ToString(Taxa_Transport);
                var_Total = (var_Subtotal + Taxa_Transport + Taxa_Ambalaj);
                textBox27.Text = Convert.ToString(var_Total);
            }



        }
        //buton factura
        private void buttonFactura_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageFactura;

            textBoxFactura.AppendText("\t" + "FACTURA DUMNEAVOASTRA " + Environment.NewLine);
            textBoxFactura.AppendText("\t\t\t" + "===========================================" + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "Order_Date: " + "\t"+ textBoxDataCom.Text + "\t" + "Order_Time: " + textBoxOraCom.Text + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "Produs: " + "\t" + "Cantitate: " + "  "+ "Pret unitar: " +Environment.NewLine);

            if(checkBox1.Checked==true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p1.Denumire + "\t" + textBox1.Text + "\t" + p1.Pret + Environment.NewLine);
            }

            if (checkBox2.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p2.Denumire + "\t" + textBox2.Text + "\t" + p2.Pret + Environment.NewLine);
            }

            if (checkBox3.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p3.Denumire + "\t" + textBox3.Text + "\t" + p3.Pret + Environment.NewLine);
            }

            if (checkBox4.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p4.Denumire + "\t" + textBox4.Text + "\t" + p4.Pret + Environment.NewLine);
            }

            if (checkBox5.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p5.Denumire + "\t" + textBox5.Text + "\t" + p5.Pret + Environment.NewLine);
            }

            if (checkBox6.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p6.Denumire + "\t" + textBox6.Text + "\t" + p6.Pret + Environment.NewLine);
            }

            if (checkBox7.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p7.Denumire + "\t" + textBox7.Text + "\t" + p7.Pret + Environment.NewLine);
            }

            if (checkBox8.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p8.Denumire + "\t" + textBox8.Text + "\t" + p8.Pret + Environment.NewLine);
            }

            if (checkBox9.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p9.Denumire + "\t" + textBox9.Text + "\t" + p9.Pret + Environment.NewLine);
            }

            if (checkBox10.Checked == true)
            {
                textBoxFactura.AppendText(Environment.NewLine + p10.Denumire + "\t" + textBox10.Text + "\t" + p10.Pret + Environment.NewLine);
            }

            textBoxFactura.AppendText(Environment.NewLine + "Subtotal:" + "\t" + textBox24.Text + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "Taxa transport:" + "\t" + textBox22.Text + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "Taxa Ambalaj:" + "\t" + textBox23.Text + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "TOTAL:" + "\t" + textBox27.Text + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine + "===========================================" + Environment.NewLine);
            textBoxFactura.AppendText(Environment.NewLine +"\t\t" +"Va multumim! " + Environment.NewLine);

        }

        //printare factura
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBoxFactura.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }

        private void buttonPrintare_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        
    }
}
