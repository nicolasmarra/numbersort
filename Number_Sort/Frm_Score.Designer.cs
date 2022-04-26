namespace Number_Sort
{
    partial class Frm_Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Score));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_difficile = new System.Windows.Forms.Button();
            this.btn_facile = new System.Windows.Forms.Button();
            this.btn_moyen = new System.Windows.Forms.Button();
            this.dgv_modecampagne = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_contretemps = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modecampagne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contretemps)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnl_top.Controls.Add(this.btn_back);
            this.pnl_top.Controls.Add(this.lbl_info);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.btn_min);
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(546, 35);
            this.pnl_top.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(43, 29);
            this.btn_back.TabIndex = 16;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(228, 1);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(79, 31);
            this.lbl_info.TabIndex = 14;
            this.lbl_info.Text = "Score";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(507, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 31);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(469, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(35, 31);
            this.btn_min.TabIndex = 2;
            this.btn_min.Text = "__";
            this.btn_min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.btn_difficile);
            this.panel1.Controls.Add(this.btn_facile);
            this.panel1.Controls.Add(this.btn_moyen);
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 35);
            this.panel1.TabIndex = 8;
            // 
            // btn_difficile
            // 
            this.btn_difficile.BackColor = System.Drawing.Color.Honeydew;
            this.btn_difficile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_difficile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_difficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_difficile.Location = new System.Drawing.Point(241, 0);
            this.btn_difficile.Name = "btn_difficile";
            this.btn_difficile.Size = new System.Drawing.Size(64, 35);
            this.btn_difficile.TabIndex = 15;
            this.btn_difficile.Text = "Difficile";
            this.btn_difficile.UseVisualStyleBackColor = false;
            this.btn_difficile.Click += new System.EventHandler(this.btn_difficile_Click);
            // 
            // btn_facile
            // 
            this.btn_facile.BackColor = System.Drawing.Color.Honeydew;
            this.btn_facile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_facile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_facile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facile.Location = new System.Drawing.Point(21, 0);
            this.btn_facile.Name = "btn_facile";
            this.btn_facile.Size = new System.Drawing.Size(64, 35);
            this.btn_facile.TabIndex = 13;
            this.btn_facile.Text = "Facile";
            this.btn_facile.UseVisualStyleBackColor = false;
            this.btn_facile.Click += new System.EventHandler(this.btn_facile_Click);
            // 
            // btn_moyen
            // 
            this.btn_moyen.BackColor = System.Drawing.Color.Honeydew;
            this.btn_moyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_moyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_moyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moyen.Location = new System.Drawing.Point(127, 0);
            this.btn_moyen.Name = "btn_moyen";
            this.btn_moyen.Size = new System.Drawing.Size(64, 35);
            this.btn_moyen.TabIndex = 14;
            this.btn_moyen.Text = "Moyen";
            this.btn_moyen.UseVisualStyleBackColor = false;
            this.btn_moyen.Click += new System.EventHandler(this.btn_moyen_Click);
            // 
            // dgv_modecampagne
            // 
            this.dgv_modecampagne.AllowUserToAddRows = false;
            this.dgv_modecampagne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_modecampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modecampagne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column2});
            this.dgv_modecampagne.Location = new System.Drawing.Point(58, 60);
            this.dgv_modecampagne.Name = "dgv_modecampagne";
            this.dgv_modecampagne.Size = new System.Drawing.Size(444, 195);
            this.dgv_modecampagne.TabIndex = 9;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pos";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Joueur";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre de coup";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Temp(s)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // dgv_contretemps
            // 
            this.dgv_contretemps.AllowUserToAddRows = false;
            this.dgv_contretemps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_contretemps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contretemps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_contretemps.Location = new System.Drawing.Point(57, 281);
            this.dgv_contretemps.Name = "dgv_contretemps";
            this.dgv_contretemps.Size = new System.Drawing.Size(446, 195);
            this.dgv_contretemps.TabIndex = 10;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pos";
            this.Column5.Name = "Column5";
            this.Column5.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Joueur";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de coup";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Temp(s)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mode Campagne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contre le temps";
            // 
            // Frm_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(546, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_contretemps);
            this.Controls.Add(this.dgv_modecampagne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_recordes";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modecampagne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contretemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.DataGridView dgv_modecampagne;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_difficile;
        private System.Windows.Forms.Button btn_facile;
        private System.Windows.Forms.Button btn_moyen;
        private System.Windows.Forms.DataGridView dgv_contretemps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}