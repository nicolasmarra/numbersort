namespace Number_Sort
{
    partial class Frm_Defaite
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
            this.btn_non = new System.Windows.Forms.Button();
            this.btn_oui = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LE TEMPS S\'EST ECOULE, VOULEZ-VOUS CONTINUER A JOUER??";
            // 
            // btn_non
            // 
            this.btn_non.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_non.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_non.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_non.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_non.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_non.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_non.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_non.Location = new System.Drawing.Point(279, 80);
            this.btn_non.Name = "btn_non";
            this.btn_non.Size = new System.Drawing.Size(76, 39);
            this.btn_non.TabIndex = 10;
            this.btn_non.Text = "NON";
            this.btn_non.UseVisualStyleBackColor = false;
            this.btn_non.Click += new System.EventHandler(this.btn_non_Click);
            // 
            // btn_oui
            // 
            this.btn_oui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_oui.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_oui.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_oui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_oui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oui.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oui.Location = new System.Drawing.Point(152, 80);
            this.btn_oui.Name = "btn_oui";
            this.btn_oui.Size = new System.Drawing.Size(76, 39);
            this.btn_oui.TabIndex = 11;
            this.btn_oui.Text = "OUI";
            this.btn_oui.UseVisualStyleBackColor = false;
            this.btn_oui.Click += new System.EventHandler(this.btn_oui_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Defaite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(506, 148);
            this.Controls.Add(this.btn_non);
            this.Controls.Add(this.btn_oui);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Defaite";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Defaite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_non;
        private System.Windows.Forms.Button btn_oui;
        private System.Windows.Forms.Timer timer1;
    }
}