
namespace Proiect_paw_incercarea_2
{
    partial class FormReclamatii
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInstructiuni = new System.Windows.Forms.TextBox();
            this.userControlReclamatii1 = new Proiect_paw_incercarea_2.UserControlReclamatii();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reclamatii:";
            // 
            // textBoxInstructiuni
            // 
            this.textBoxInstructiuni.Location = new System.Drawing.Point(465, 69);
            this.textBoxInstructiuni.Multiline = true;
            this.textBoxInstructiuni.Name = "textBoxInstructiuni";
            this.textBoxInstructiuni.ReadOnly = true;
            this.textBoxInstructiuni.Size = new System.Drawing.Size(272, 195);
            this.textBoxInstructiuni.TabIndex = 2;
            // 
            // userControlReclamatii1
            // 
            this.userControlReclamatii1.BackColor = System.Drawing.Color.RosyBrown;
            this.userControlReclamatii1.Location = new System.Drawing.Point(27, 69);
            this.userControlReclamatii1.Name = "userControlReclamatii1";
            this.userControlReclamatii1.Size = new System.Drawing.Size(432, 369);
            this.userControlReclamatii1.TabIndex = 0;
            // 
            // FormReclamatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInstructiuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlReclamatii1);
            this.Name = "FormReclamatii";
            this.Text = "FormReclamatii";
            this.Load += new System.EventHandler(this.FormReclamatii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlReclamatii userControlReclamatii1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInstructiuni;
    }
}