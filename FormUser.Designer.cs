
namespace Proiect_paw_incercarea_2
{
    partial class FormInregistrare
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonClearCampuri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProviderTel = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sa incepem!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(60, 101);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(216, 28);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(60, 158);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(216, 28);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password:";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(60, 215);
            this.textBoxConfirmPass.Multiline = true;
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '•';
            this.textBoxConfirmPass.Size = new System.Drawing.Size(216, 28);
            this.textBoxConfirmPass.TabIndex = 6;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Location = new System.Drawing.Point(96, 471);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(151, 27);
            this.checkBoxShowPass.TabIndex = 7;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonInregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInregistrare.FlatAppearance.BorderSize = 0;
            this.buttonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInregistrare.ForeColor = System.Drawing.Color.White;
            this.buttonInregistrare.Location = new System.Drawing.Point(62, 504);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(216, 35);
            this.buttonInregistrare.TabIndex = 8;
            this.buttonInregistrare.Text = "Inregistrare!";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // buttonClearCampuri
            // 
            this.buttonClearCampuri.BackColor = System.Drawing.Color.White;
            this.buttonClearCampuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearCampuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearCampuri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClearCampuri.Location = new System.Drawing.Point(60, 545);
            this.buttonClearCampuri.Name = "buttonClearCampuri";
            this.buttonClearCampuri.Size = new System.Drawing.Size(216, 35);
            this.buttonClearCampuri.TabIndex = 9;
            this.buttonClearCampuri.Text = "Clear";
            this.buttonClearCampuri.UseVisualStyleBackColor = false;
            this.buttonClearCampuri.Click += new System.EventHandler(this.buttonClearCampuri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ai deja un cont?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(58, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inapoi la pagina de logare";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNume.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(60, 276);
            this.textBoxNume.Multiline = true;
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(216, 28);
            this.textBoxNume.TabIndex = 12;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPrenume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrenume.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenume.Location = new System.Drawing.Point(60, 336);
            this.textBoxPrenume.Multiline = true;
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(216, 28);
            this.textBoxPrenume.TabIndex = 13;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdresa.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresa.Location = new System.Drawing.Point(60, 445);
            this.textBoxAdresa.Multiline = true;
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(216, 28);
            this.textBoxAdresa.TabIndex = 14;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefon.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefon.Location = new System.Drawing.Point(60, 389);
            this.textBoxTelefon.Multiline = true;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(216, 28);
            this.textBoxTelefon.TabIndex = 15;
            this.textBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefon_Validating);
            this.textBoxTelefon.Validated += new System.EventHandler(this.textBoxTelefon_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nume:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Prenume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Adresa";
            // 
            // errorProviderTel
            // 
            this.errorProviderTel.ContainerControl = this;
            // 
            // FormInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 706);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClearCampuri);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInregistrare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonClearCampuri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProviderTel;
    }
}