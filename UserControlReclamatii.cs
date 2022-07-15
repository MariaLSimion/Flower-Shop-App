using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_paw_incercarea_2
{
    public partial class UserControlReclamatii : UserControl
    {
        public UserControlReclamatii()
        {
            InitializeComponent();
        }

        private void buttonTrimitereRec_Click(object sender, EventArgs e)
        {
            TextWriter fis = new System.IO.StreamWriter("C:\\Users\\smari\\onedrive\\Desktop\\Proiect paw incercarea 2\\FisierReclamatii.txt");

           
                fis.WriteLine(label1.Text + " " + textBoxNumeR.Text);
                fis.WriteLine(label2.Text + " " + textBoxEmail.Text);
                fis.WriteLine(label3.Text + " " + comboBoxServiciu.SelectedItem.ToString());
                fis.WriteLine(label4.Text + " " + textBoxDescriere.Text);
                fis.Close();
                MessageBox.Show("Reclamatia dvs a fost inregistrata!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void UserControlReclamatii_Load(object sender, EventArgs e)
        {

        }
    }
}
