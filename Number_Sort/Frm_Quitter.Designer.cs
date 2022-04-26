namespace Number_Sort
{
    partial class Frm_Quitter
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
            this.btn_non = new System.Windows.Forms.Button();
            this.btn_oui = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_non
            // 
            this.btn_non.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_non.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_non.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_non.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_non.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_non.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_non.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_non.Location = new System.Drawing.Point(254, 53);
            this.btn_non.Name = "btn_non";
            this.btn_non.Size = new System.Drawing.Size(76, 39);
            this.btn_non.TabIndex = 8;
            this.btn_non.Text = "Non";
            this.btn_non.UseVisualStyleBackColor = false;
            this.btn_non.Click += new System.EventHandler(this.btn_non_Click);
            // 
            // btn_oui
            // 
            this.btn_oui.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_oui.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_oui.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_oui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_oui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oui.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oui.Location = new System.Drawing.Point(127, 53);
            this.btn_oui.Name = "btn_oui";
            this.btn_oui.Size = new System.Drawing.Size(76, 39);
            this.btn_oui.TabIndex = 9;
            this.btn_oui.Text = "Oui";
            this.btn_oui.UseVisualStyleBackColor = false;
            this.btn_oui.Click += new System.EventHandler(this.btn_oui_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(52, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(359, 31);
            this.lbl_info.TabIndex = 13;
            this.lbl_info.Text = "Voulez-vous vraiment quitter?";
            // 
            // Frm_Quitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(460, 116);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_non);
            this.Controls.Add(this.btn_oui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Quitter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Quitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_non;
        private System.Windows.Forms.Button btn_oui;
        private System.Windows.Forms.Label lbl_info;
    }
}