namespace Number_Sort
{
    partial class Frm_win
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_oui = new System.Windows.Forms.Button();
            this.btn_non = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Félicitations! Vous avez gagné";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Voulez-vous rejouer?";
            // 
            // btn_oui
            // 
            this.btn_oui.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_oui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_oui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oui.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oui.Location = new System.Drawing.Point(22, 92);
            this.btn_oui.Name = "btn_oui";
            this.btn_oui.Size = new System.Drawing.Size(82, 38);
            this.btn_oui.TabIndex = 6;
            this.btn_oui.Text = "Oui";
            this.btn_oui.UseVisualStyleBackColor = false;
            this.btn_oui.Click += new System.EventHandler(this.btn_oui_Click);
            // 
            // btn_non
            // 
            this.btn_non.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_non.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_non.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_non.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_non.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_non.Location = new System.Drawing.Point(227, 92);
            this.btn_non.Name = "btn_non";
            this.btn_non.Size = new System.Drawing.Size(82, 38);
            this.btn_non.TabIndex = 7;
            this.btn_non.Text = "Non";
            this.btn_non.UseVisualStyleBackColor = false;
            this.btn_non.Click += new System.EventHandler(this.btn_non_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(338, 150);
            this.Controls.Add(this.btn_non);
            this.Controls.Add(this.btn_oui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_win";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_win_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_oui;
        private System.Windows.Forms.Button btn_non;
        private System.Windows.Forms.Timer timer1;
    }
}