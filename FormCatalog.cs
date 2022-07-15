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
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //========================
        //drag and drop
        private void FormCatalog_Load(object sender, EventArgs e)
        {
            pictureBoxZoom.AllowDrop = true;
        }

        private void pictureBoxZoom_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxZoom_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxZoom.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


        private void pictureBoxAnemona_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAnemona.DoDragDrop(pictureBoxAnemona.Image, DragDropEffects.Copy);

        }

        private void pictureBoxBujor_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBujor.DoDragDrop(pictureBoxBujor.Image, DragDropEffects.Copy);
        }

        private void pictureBoxCraita_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCraita.DoDragDrop(pictureBoxCraita.Image, DragDropEffects.Copy);
        }

        private void pictureBoxCrin_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCrin.DoDragDrop(pictureBoxCrin.Image, DragDropEffects.Copy);
        }

        private void pictureBoxCrinImp_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCrinImp.DoDragDrop(pictureBoxCrinImp.Image, DragDropEffects.Copy);
        }

        private void pictureBoxCrizantema_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCrizantema.DoDragDrop(pictureBoxCrizantema.Image, DragDropEffects.Copy);

        }

        private void pictureBoxFrezie_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxFrezie.DoDragDrop(pictureBoxFrezie.Image, DragDropEffects.Copy);

        }

        private void pictureBoxGerbera_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxGerbera.DoDragDrop(pictureBoxGerbera.Image, DragDropEffects.Copy);

        }

        private void pictureBoxHortensie_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxHortensie.DoDragDrop(pictureBoxHortensie.Image, DragDropEffects.Copy);

        }

        private void pictureBoxiris_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxiris.DoDragDrop(pictureBoxiris.Image, DragDropEffects.Copy);

        }

        private void pictureBoxLalea_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLalea.DoDragDrop(pictureBoxLalea.Image, DragDropEffects.Copy);

        }

        private void pictureBoxNarcisa_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxNarcisa.DoDragDrop(pictureBoxNarcisa.Image, DragDropEffects.Copy);

        }

        private void pictureBoxOrhidee_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxOrhidee.DoDragDrop(pictureBoxOrhidee.Image, DragDropEffects.Copy);

        }

        private void pictureBoxTRandafir_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxTRandafir.DoDragDrop(pictureBoxTRandafir.Image, DragDropEffects.Copy);

        }

        private void pictureBoxZambila_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxZambila.DoDragDrop(pictureBoxZambila.Image, DragDropEffects.Copy);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxZoom_Click(object sender, EventArgs e)
        {

        }
    }
}
