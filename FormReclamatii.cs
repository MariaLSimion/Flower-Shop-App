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
    public partial class FormReclamatii : Form
    {
        public FormReclamatii()
        {
            InitializeComponent();
        }

        private void FormReclamatii_Load(object sender, EventArgs e)
        {

            textBoxInstructiuni.AppendText("\t" + "INFORMARE " + Environment.NewLine);
            textBoxInstructiuni.AppendText(Environment.NewLine + "================================" + Environment.NewLine);
            textBoxInstructiuni.AppendText(Environment.NewLine + "Ne pare rau ca ati avut o experienta neplacuta! Va rugam sa introduceti aici datele dumneavoastra pentru a va putea contacta si sa descrieti cat mai detaliat situatia. Multumim!");
        }
    }
}
