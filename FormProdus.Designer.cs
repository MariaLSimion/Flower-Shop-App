
namespace Proiect_paw_incercarea_2
{
    partial class FormProdus
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodP = new System.Windows.Forms.TextBox();
            this.textBoxDenumireP = new System.Windows.Forms.TextBox();
            this.textBoxBucatiP = new System.Windows.Forms.TextBox();
            this.textBoxPretP = new System.Windows.Forms.TextBox();
            this.buttonAdaugaP = new System.Windows.Forms.Button();
            this.errorProviderCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumarBuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPretBuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelerrCod = new System.Windows.Forms.Label();
            this.labelerrDen = new System.Windows.Forms.Label();
            this.labelerrNrB = new System.Windows.Forms.Label();
            this.labelerrPret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumarBuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPretBuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cod produs: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Denumire produs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Numar bucati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Pret/bucata:";
            // 
            // textBoxCodP
            // 
            this.textBoxCodP.Location = new System.Drawing.Point(260, 69);
            this.textBoxCodP.Name = "textBoxCodP";
            this.textBoxCodP.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodP.TabIndex = 1;
            this.textBoxCodP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodP_KeyDown);
            this.textBoxCodP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodP_Validating);
            this.textBoxCodP.Validated += new System.EventHandler(this.textBoxCodP_Validated);
            // 
            // textBoxDenumireP
            // 
            this.textBoxDenumireP.Location = new System.Drawing.Point(260, 130);
            this.textBoxDenumireP.Name = "textBoxDenumireP";
            this.textBoxDenumireP.Size = new System.Drawing.Size(100, 22);
            this.textBoxDenumireP.TabIndex = 3;
            this.textBoxDenumireP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDenumireP_KeyDown);
            this.textBoxDenumireP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDenumireP_Validating);
            this.textBoxDenumireP.Validated += new System.EventHandler(this.textBoxDenumireP_Validated);
            // 
            // textBoxBucatiP
            // 
            this.textBoxBucatiP.Location = new System.Drawing.Point(260, 182);
            this.textBoxBucatiP.Name = "textBoxBucatiP";
            this.textBoxBucatiP.Size = new System.Drawing.Size(100, 22);
            this.textBoxBucatiP.TabIndex = 5;
            this.textBoxBucatiP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBucatiP_KeyDown);
            this.textBoxBucatiP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBucatiP_KeyPress);
            this.textBoxBucatiP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBucatiP_Validating);
            this.textBoxBucatiP.Validated += new System.EventHandler(this.textBoxBucatiP_Validated);
            // 
            // textBoxPretP
            // 
            this.textBoxPretP.Location = new System.Drawing.Point(260, 236);
            this.textBoxPretP.Name = "textBoxPretP";
            this.textBoxPretP.Size = new System.Drawing.Size(100, 22);
            this.textBoxPretP.TabIndex = 7;
            this.textBoxPretP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPretP_KeyDown);
            this.textBoxPretP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPretP_Validating);
            this.textBoxPretP.Validated += new System.EventHandler(this.textBoxPretP_Validated);
            // 
            // buttonAdaugaP
            // 
            this.buttonAdaugaP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdaugaP.FlatAppearance.BorderSize = 3;
            this.buttonAdaugaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdaugaP.Location = new System.Drawing.Point(213, 301);
            this.buttonAdaugaP.Name = "buttonAdaugaP";
            this.buttonAdaugaP.Size = new System.Drawing.Size(166, 66);
            this.buttonAdaugaP.TabIndex = 8;
            this.buttonAdaugaP.Text = "Adauga Produs";
            this.buttonAdaugaP.UseVisualStyleBackColor = true;
            this.buttonAdaugaP.Click += new System.EventHandler(this.buttonAdaugaP_Click);
            // 
            // errorProviderCod
            // 
            this.errorProviderCod.ContainerControl = this;
            // 
            // errorProviderDenumire
            // 
            this.errorProviderDenumire.ContainerControl = this;
            // 
            // errorProviderNumarBuc
            // 
            this.errorProviderNumarBuc.ContainerControl = this;
            // 
            // errorProviderPretBuc
            // 
            this.errorProviderPretBuc.ContainerControl = this;
            // 
            // labelerrCod
            // 
            this.labelerrCod.AutoSize = true;
            this.labelerrCod.Location = new System.Drawing.Point(279, 94);
            this.labelerrCod.Name = "labelerrCod";
            this.labelerrCod.Size = new System.Drawing.Size(12, 17);
            this.labelerrCod.TabIndex = 9;
            this.labelerrCod.Text = " ";
            // 
            // labelerrDen
            // 
            this.labelerrDen.AutoSize = true;
            this.labelerrDen.Location = new System.Drawing.Point(279, 162);
            this.labelerrDen.Name = "labelerrDen";
            this.labelerrDen.Size = new System.Drawing.Size(12, 17);
            this.labelerrDen.TabIndex = 10;
            this.labelerrDen.Text = " ";
            // 
            // labelerrNrB
            // 
            this.labelerrNrB.AutoSize = true;
            this.labelerrNrB.Location = new System.Drawing.Point(279, 216);
            this.labelerrNrB.Name = "labelerrNrB";
            this.labelerrNrB.Size = new System.Drawing.Size(12, 17);
            this.labelerrNrB.TabIndex = 11;
            this.labelerrNrB.Text = " ";
            // 
            // labelerrPret
            // 
            this.labelerrPret.AutoSize = true;
            this.labelerrPret.Location = new System.Drawing.Point(279, 261);
            this.labelerrPret.Name = "labelerrPret";
            this.labelerrPret.Size = new System.Drawing.Size(12, 17);
            this.labelerrPret.TabIndex = 12;
            this.labelerrPret.Text = " ";
            // 
            // FormProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.labelerrPret);
            this.Controls.Add(this.labelerrNrB);
            this.Controls.Add(this.labelerrDen);
            this.Controls.Add(this.labelerrCod);
            this.Controls.Add(this.buttonAdaugaP);
            this.Controls.Add(this.textBoxPretP);
            this.Controls.Add(this.textBoxBucatiP);
            this.Controls.Add(this.textBoxDenumireP);
            this.Controls.Add(this.textBoxCodP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProdus";
            this.Text = "Adauga Produs";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumarBuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPretBuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodP;
        private System.Windows.Forms.TextBox textBoxDenumireP;
        private System.Windows.Forms.TextBox textBoxBucatiP;
        private System.Windows.Forms.TextBox textBoxPretP;
        private System.Windows.Forms.Button buttonAdaugaP;
        private System.Windows.Forms.ErrorProvider errorProviderCod;
        private System.Windows.Forms.ErrorProvider errorProviderDenumire;
        private System.Windows.Forms.ErrorProvider errorProviderNumarBuc;
        private System.Windows.Forms.ErrorProvider errorProviderPretBuc;
        private System.Windows.Forms.Label labelerrPret;
        private System.Windows.Forms.Label labelerrNrB;
        private System.Windows.Forms.Label labelerrDen;
        private System.Windows.Forms.Label labelerrCod;
    }
}