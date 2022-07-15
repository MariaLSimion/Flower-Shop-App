
namespace Proiect_paw_incercarea_2
{
    partial class UserControlReclamatii
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeR = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.comboBoxServiciu = new System.Windows.Forms.ComboBox();
            this.buttonTrimitereRec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numele dvs. complet:";
            // 
            // textBoxNumeR
            // 
            this.textBoxNumeR.Location = new System.Drawing.Point(222, 44);
            this.textBoxNumeR.Name = "textBoxNumeR";
            this.textBoxNumeR.Size = new System.Drawing.Size(179, 22);
            this.textBoxNumeR.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(222, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(179, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(222, 187);
            this.textBoxDescriere.Multiline = true;
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(179, 156);
            this.textBoxDescriere.TabIndex = 6;
            // 
            // comboBoxServiciu
            // 
            this.comboBoxServiciu.FormattingEnabled = true;
            this.comboBoxServiciu.Items.AddRange(new object[] {
            "Livrare",
            "Produse",
            "Serviciul clienti"});
            this.comboBoxServiciu.Location = new System.Drawing.Point(222, 140);
            this.comboBoxServiciu.Name = "comboBoxServiciu";
            this.comboBoxServiciu.Size = new System.Drawing.Size(179, 24);
            this.comboBoxServiciu.TabIndex = 7;
            // 
            // buttonTrimitereRec
            // 
            this.buttonTrimitereRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTrimitereRec.Location = new System.Drawing.Point(60, 215);
            this.buttonTrimitereRec.Name = "buttonTrimitereRec";
            this.buttonTrimitereRec.Size = new System.Drawing.Size(84, 38);
            this.buttonTrimitereRec.TabIndex = 8;
            this.buttonTrimitereRec.Text = "TRIMITETI";
            this.buttonTrimitereRec.UseVisualStyleBackColor = false;
            this.buttonTrimitereRec.Click += new System.EventHandler(this.buttonTrimitereRec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serviciul:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descriere/Motiv:";
            // 
            // UserControlReclamatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.buttonTrimitereRec);
            this.Controls.Add(this.comboBoxServiciu);
            this.Controls.Add(this.textBoxDescriere);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNumeR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlReclamatii";
            this.Size = new System.Drawing.Size(432, 369);
            this.Load += new System.EventHandler(this.UserControlReclamatii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeR;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.ComboBox comboBoxServiciu;
        private System.Windows.Forms.Button buttonTrimitereRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
