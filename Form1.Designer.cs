
namespace Proiect_paw_incercarea_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewProdus = new System.Windows.Forms.ListView();
            this.columnHeaderCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumarBuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaProdusInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizeazaInfoProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaProduseDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProdus
            // 
            this.listViewProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listViewProdus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCod,
            this.columnHeaderDenumire,
            this.columnHeaderNumarBuc,
            this.columnHeaderPret});
            this.listViewProdus.FullRowSelect = true;
            this.listViewProdus.GridLines = true;
            this.listViewProdus.HideSelection = false;
            this.listViewProdus.Location = new System.Drawing.Point(25, 82);
            this.listViewProdus.Name = "listViewProdus";
            this.listViewProdus.Size = new System.Drawing.Size(399, 330);
            this.listViewProdus.TabIndex = 0;
            this.listViewProdus.UseCompatibleStateImageBehavior = false;
            this.listViewProdus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCod
            // 
            this.columnHeaderCod.Text = "Cod ";
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 80;
            // 
            // columnHeaderNumarBuc
            // 
            this.columnHeaderNumarBuc.Text = "Numar bucati";
            this.columnHeaderNumarBuc.Width = 100;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret/buc";
            this.columnHeaderPret.Width = 90;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem,
            this.stergeProdusToolStripMenuItem,
            this.salveazaProdusInFisierToolStripMenuItem,
            this.actualizeazaInfoProdusToolStripMenuItem,
            this.restaureazaProduseDinFisierToolStripMenuItem});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.adaugaProdusToolStripMenuItem.Text = "Adauga Produs";
            this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click);
            // 
            // stergeProdusToolStripMenuItem
            // 
            this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.stergeProdusToolStripMenuItem.Text = "Sterge Produs";
            this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.stergeProdusToolStripMenuItem_Click);
            // 
            // salveazaProdusInFisierToolStripMenuItem
            // 
            this.salveazaProdusInFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.salveazaProdusInFisierToolStripMenuItem.Name = "salveazaProdusInFisierToolStripMenuItem";
            this.salveazaProdusInFisierToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.salveazaProdusInFisierToolStripMenuItem.Text = "Salveaza produs in fisier";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.binarToolStripMenuItem.Text = "Binar";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // actualizeazaInfoProdusToolStripMenuItem
            // 
            this.actualizeazaInfoProdusToolStripMenuItem.Name = "actualizeazaInfoProdusToolStripMenuItem";
            this.actualizeazaInfoProdusToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.actualizeazaInfoProdusToolStripMenuItem.Text = "Actualizeaza info produs";
            this.actualizeazaInfoProdusToolStripMenuItem.Click += new System.EventHandler(this.actualizeazaInfoProdusToolStripMenuItem_Click);
            // 
            // restaureazaProduseDinFisierToolStripMenuItem
            // 
            this.restaureazaProduseDinFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem1,
            this.binarToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.restaureazaProduseDinFisierToolStripMenuItem.Name = "restaureazaProduseDinFisierToolStripMenuItem";
            this.restaureazaProduseDinFisierToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.restaureazaProduseDinFisierToolStripMenuItem.Text = "Restaureaza produse din fisier";
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.textToolStripMenuItem1.Text = "Text";
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.binarToolStripMenuItem1.Text = "Binar";
            this.binarToolStripMenuItem1.Click += new System.EventHandler(this.binarToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.listViewProdus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProdus;
        private System.Windows.Forms.ColumnHeader columnHeaderCod;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.ColumnHeader columnHeaderNumarBuc;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaProdusInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizeazaInfoProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaProduseDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
    }
}

