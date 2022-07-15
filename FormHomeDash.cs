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
    public partial class FormHomeDash : Form
    {
        public FormHomeDash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReclamatii fr = new FormReclamatii();
            fr.Show();
        }
    }
}
