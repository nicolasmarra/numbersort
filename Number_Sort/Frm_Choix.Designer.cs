namespace Number_Sort
{
    partial class Frm_Choix
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
            this.btn_facile = new System.Windows.Forms.Button();
            this.btn_moyen = new System.Windows.Forms.Button();
            this.btn_difficile = new System.Windows.Forms.Button();
            this.lbl_player = new System.Windows.Forms.Label();
            this.txt_player = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_facile
            // 
            this.btn_facile.BackColor = System.Drawing.Color.Honeydew;
            this.btn_facile.Enabled = false;
            this.btn_facile.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_facile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_facile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_facile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facile.Font = new System.Drawing.Font("Jokerman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facile.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_facile.Location = new System.Drawing.Point(17, 127);
            this.btn_facile.Name = "btn_facile";
            this.btn_facile.Size = new System.Drawing.Size(120, 57);
            this.btn_facile.TabIndex = 4;
            this.btn_facile.Text = "Facile (3X3)";
            this.btn_facile.UseVisualStyleBackColor = false;
            this.btn_facile.Click += new System.EventHandler(this.btn_facile_Click);
            // 
            // btn_moyen
            // 
            this.btn_moyen.BackColor = System.Drawing.Color.Honeydew;
            this.btn_moyen.Enabled = false;
            this.btn_moyen.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_moyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_moyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_moyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moyen.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moyen.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_moyen.Location = new System.Drawing.Point(143, 127);
            this.btn_moyen.Name = "btn_moyen";
            this.btn_moyen.Size = new System.Drawing.Size(144, 57);
            this.btn_moyen.TabIndex = 5;
            this.btn_moyen.Text = "Moyen(4X4)";
            this.btn_moyen.UseVisualStyleBackColor = false;
            this.btn_moyen.Click += new System.EventHandler(this.btn_moyen_Click);
            // 
            // btn_difficile
            // 
            this.btn_difficile.BackColor = System.Drawing.Color.Honeydew;
            this.btn_difficile.Enabled = false;
            this.btn_difficile.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_difficile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_difficile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_difficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_difficile.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_difficile.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_difficile.Location = new System.Drawing.Point(290, 127);
            this.btn_difficile.Name = "btn_difficile";
            this.btn_difficile.Size = new System.Drawing.Size(136, 60);
            this.btn_difficile.TabIndex = 6;
            this.btn_difficile.Text = "Difficile(5X5)";
            this.btn_difficile.UseVisualStyleBackColor = false;
            this.btn_difficile.Click += new System.EventHandler(this.btn_difficile_Click);
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_player.Location = new System.Drawing.Point(12, 76);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(172, 28);
            this.lbl_player.TabIndex = 8;
            this.lbl_player.Text = "Nom du joueur:";
            // 
            // txt_player
            // 
            this.txt_player.BackColor = System.Drawing.Color.MintCream;
            this.txt_player.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txt_player.Location = new System.Drawing.Point(207, 73);
            this.txt_player.Name = "txt_player";
            this.txt_player.Size = new System.Drawing.Size(187, 36);
            this.txt_player.TabIndex = 9;
            this.txt_player.TextChanged += new System.EventHandler(this.txt_player_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Honeydew;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(394, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 33);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mode.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_mode.Location = new System.Drawing.Point(162, 18);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(138, 28);
            this.lbl_mode.TabIndex = 11;
            this.lbl_mode.Text = "Mode de jeu";
            // 
            // Frm_Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(440, 214);
            this.Controls.Add(this.lbl_mode);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_player);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.btn_difficile);
            this.Controls.Add(this.btn_moyen);
            this.Controls.Add(this.btn_facile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Choix";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Escolha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Choix_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_facile;
        private System.Windows.Forms.Button btn_moyen;
        private System.Windows.Forms.Button btn_difficile;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.TextBox txt_player;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_mode;
    }
}