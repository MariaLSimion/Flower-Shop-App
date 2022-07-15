using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Proiect_paw_incercarea_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Produs p1 = new Produs("1", "Crizantema", 44, 2.5);
            Produs p2 = new Produs("2", "Crin", 50, 5);
            Produs p3 = new Produs("3", "Trandafir", 120, 8);
            Produs p4 = new Produs("4", "Frezie", 70, 6);
            Produs p5 = new Produs("5", "Crin imperial", 45, 10.50);
            Produs p6 = new Produs("6", "Lalea", 70, 6);
            Produs p7 = new Produs("7", "Gerbera", 90, 4.5);
            Produs p8 = new Produs("8", "Zambila", 50, 7);



            //adaugare produse in listview
            ListViewItem lv1 = new ListViewItem(p1.Cod_produs);
            lv1.SubItems.Add(p1.Denumire);
            lv1.SubItems.Add(p1.Nr_buc_stoc.ToString());
            lv1.SubItems.Add(p1.Pret.ToString());
            lv1.Tag = p1;
            listViewProdus.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(p2.Cod_produs);
            lv2.SubItems.Add(p2.Denumire);
            lv2.SubItems.Add(p2.Nr_buc_stoc.ToString());
            lv2.SubItems.Add(p2.Pret.ToString());
            lv2.Tag = p2;
            listViewProdus.Items.Add(lv2);

            ListViewItem lv3 = new ListViewItem(p3.Cod_produs);
            lv3.SubItems.Add(p3.Denumire);
            lv3.SubItems.Add(p3.Nr_buc_stoc.ToString());
            lv3.SubItems.Add(p3.Pret.ToString());
            lv3.Tag = p3;
            listViewProdus.Items.Add(lv3);

            ListViewItem lv4 = new ListViewItem(p4.Cod_produs);
            lv4.SubItems.Add(p4.Denumire);
            lv4.SubItems.Add(p4.Nr_buc_stoc.ToString());
            lv4.SubItems.Add(p4.Pret.ToString());
            lv4.Tag = p4;
            listViewProdus.Items.Add(lv4);

            ListViewItem lv5 = new ListViewItem(p5.Cod_produs);
            lv5.SubItems.Add(p5.Denumire);
            lv5.SubItems.Add(p5.Nr_buc_stoc.ToString());
            lv5.SubItems.Add(p5.Pret.ToString());
            lv5.Tag = p5;
            listViewProdus.Items.Add(lv5);

            ListViewItem lv6= new ListViewItem(p6.Cod_produs);
            lv6.SubItems.Add(p6.Denumire);
            lv6.SubItems.Add(p6.Nr_buc_stoc.ToString());
            lv6.SubItems.Add(p6.Pret.ToString());
            lv6.Tag = p6;
            listViewProdus.Items.Add(lv6);

            ListViewItem lv7 = new ListViewItem(p7.Cod_produs);
            lv7.SubItems.Add(p7.Denumire);
            lv7.SubItems.Add(p7.Nr_buc_stoc.ToString());
            lv7.SubItems.Add(p7.Pret.ToString());
            lv7.Tag = p7;
            listViewProdus.Items.Add(lv7);

            ListViewItem lv8 = new ListViewItem(p8.Cod_produs);
            lv8.SubItems.Add(p8.Denumire);
            lv8.SubItems.Add(p8.Nr_buc_stoc.ToString());
            lv8.SubItems.Add(p8.Pret.ToString());
            lv8.Tag = p8;
            listViewProdus.Items.Add(lv8);
        }
        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listViewProdus.Items)
            {
                Produs p = (Produs)lvi.Tag;
                lvi.Text = p.Cod_produs;
                lvi.SubItems[1].Text = p.Denumire;
                lvi.SubItems[2].Text = p.Nr_buc_stoc.ToString();
                lvi.SubItems[3].Text = p.Pret.ToString();
            }
        }

        private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
            listViewProdus.Items.Add(lvi);
            lvi.Selected = true;
            Produs p = new Produs();
            lvi.Tag = p;
            FormProdus fp = new FormProdus();



            fp.produs = p;
            fp.parinte = this;
            fp.ShowDialog();

            if (fp.DialogResult != DialogResult.OK)
                lvi.Remove();

        }

        private void actualizeazaInfoProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdus fp = new FormProdus();
            fp.parinte = this;
            listViewProdus.SelectedIndexChanged += new EventHandler(fp.ActualizeazaControale);
            fp.ActualizeazaControale(this.listViewProdus, e);
            fp.ShowDialog();
        }

        private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProdus.SelectedItems.Count > 0)
            {
                Produs p = (Produs)listViewProdus.SelectedItems[0].Tag;

                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea produsului " + p.Denumire + " ?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (rezultat == DialogResult.Yes) listViewProdus.SelectedItems[0].Remove();
            }
        }

        //==========================================================================================
        //salvare + restaurare din fisiere
        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare produse (*.produse)|*.produse";// se face o filtrare dupa ce se aflta in dreapta |
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Produs> lista = listViewProdus.Items.Cast<ListViewItem>()
                    .Select(item => (Produs)item.Tag)
                    .ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }

        private void binarToolStripMenuItem1_Click(object sender, EventArgs e)//restaurare
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare produse (*.produse)|*.produse";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Produs> lista = (List<Produs>)deserializator.Deserialize(fb);
                listViewProdus.Items.Clear();

                foreach (Produs p in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                    lvi.Tag = p;
                    listViewProdus.Items.Add(lvi);
                }
               UpdateItems();
                fb.Close();
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProdus.SelectedItems.Count > 0)
            {
                TextWriter txt = new System.IO.StreamWriter("C:\\Users\\smari\\onedrive\\Desktop\\Proiect paw incercarea 2\\Fisier.txt");
                foreach (ListViewItem item in listViewProdus.Items)
                    txt.WriteLine("{0} {1} {2}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
                txt.Close();
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)//salvare
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();//scrie singur marcajul de start document
            writer.WriteStartElement("Lista-medici");

            List<Produs> lista = listViewProdus.Items.Cast<ListViewItem>()
                   .Select(item => (Produs)item.Tag)
                   .ToList();
            foreach (Produs p in lista)
            {
                writer.WriteStartElement("Floare");
                writer.WriteElementString("Cod", p.Cod_produs);
                writer.WriteElementString("Denumire", p.Denumire);
                writer.WriteElementString("Numar bucati pe stoc", p.Nr_buc_stoc.ToString());
                writer.WriteElementString("Pret pe bucata", p.Pret.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            string xmlstring = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("C:\\Users\\smari\\onedrive\\Desktop\\Proiect paw incercarea 2\\Fisier.xml");
            sw.WriteLine(xmlstring);
            sw.Close();
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\smari\\onedrive\\Desktop\\Proiect paw incercarea 2\\Fisier.xml");
            string str = sr.ReadToEnd();
            List<Produs> lista = new List<Produs>();
            XmlReader reader = XmlReader.Create(new StringReader(str));
            while (reader.Read())
            {
                if (reader.Name == "Produs" && reader.NodeType == XmlNodeType.Element)
                {
                    Produs clocal;

                    while (reader.Read() && reader.Name != "Cod") { };
                    reader.Read();
                    string cod_produs = reader.Value;

                    while (reader.Read() && reader.Name != "Denumire") { };
                    reader.Read();
                    string denumire = reader.Value;

                    while (reader.Read() && reader.Name != "Numar bucati pe stoc") { };
                    reader.Read();
                    string nr_buc_stoc = reader.Value;

                    while (reader.Read() && reader.Name != "Pret pe bucata") { };
                    reader.Read();
                    string pret = reader.Value;


                    clocal = new Produs(cod_produs, denumire, Convert.ToInt32(nr_buc_stoc), Convert.ToDouble( pret));
                    lista.Add(clocal);
                }
            }

            listViewProdus.Items.Clear();

            foreach (Produs p in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                lvi.Tag = p;
                listViewProdus.Items.Add(lvi);
            }
            UpdateItems();
            sr.Close();
        }
    }
}
