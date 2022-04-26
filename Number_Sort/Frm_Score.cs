using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Number_Sort
{
    public partial class Frm_Score : Form
    {

        OleDbConnection connexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= "+Application.StartupPath+@"\db_numbersort.mdb");
        OleDbDataAdapter adaptateur = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();
        int i;
        public Frm_Score()
        {
            InitializeComponent();
        }

        private void chargerfacile()
        {
            btn_facile.Visible = false;
            btn_moyen.Visible = true;
            btn_difficile.Visible = true;
            adaptateur.SelectCommand = new OleDbCommand ("select * from tb_facilecampagne order by Temp ",connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_modecampagne.Rows.Clear();
            dgv_modecampagne.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {

                dgv_modecampagne[0, i].Value = i + 1;
                dgv_modecampagne[1, i].Value = dt.Rows[i]["Nom"];
                dgv_modecampagne[2, i].Value = dt.Rows[i]["Coup"];
                dgv_modecampagne[3, i].Value = dt.Rows[i]["Temp"];
                
            }

            adaptateur.SelectCommand = new OleDbCommand("select * from tb_faciletemp order by Temp ", connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_contretemps.Rows.Clear();
            dgv_contretemps.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                dgv_contretemps[0, i].Value = i + 1;
                dgv_contretemps[1, i].Value = dt.Rows[i]["Nom"];
                dgv_contretemps[2, i].Value = dt.Rows[i]["Coup"];
                dgv_contretemps[3, i].Value = dt.Rows[i]["Temp"];

            }            

        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptb_back_Click(object sender, EventArgs e)
        {
            Frm_Menu p = new Frm_Menu();
            p.Show();
            this.Hide();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_Menu p = new Frm_Menu();
            p.Show();
            this.Hide();

        }

        private void Frm_Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_facile_Click(object sender, EventArgs e)
        {
            chargerfacile();
        }
        #region
        private void chargermoyen()
        {
            btn_facile.Visible = true;
            btn_moyen.Visible = false;
            btn_difficile.Visible = true;
            adaptateur.SelectCommand = new OleDbCommand("select * from tb_moyencampagne order by Temp ", connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_modecampagne.Rows.Clear();
            dgv_modecampagne.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {

                dgv_modecampagne[0, i].Value = i + 1;
                dgv_modecampagne[1, i].Value = dt.Rows[i]["Nom"];
                dgv_modecampagne[2, i].Value = dt.Rows[i]["Coup"];
                dgv_modecampagne[3, i].Value = dt.Rows[i]["Temp"];
                
            }

            adaptateur.SelectCommand = new OleDbCommand("select * from tb_moyentemp order by Temp ", connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_contretemps.Rows.Clear();
            dgv_contretemps.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {

                dgv_contretemps[0, i].Value = i + 1;
                dgv_contretemps[1, i].Value = dt.Rows[i]["Nom"];
                dgv_contretemps[2, i].Value = dt.Rows[i]["Coup"];
                dgv_contretemps[3, i].Value = dt.Rows[i]["Temp"];

            }

        }

        private void chargerdifficile()
        {
            btn_facile.Visible = true;
            btn_moyen.Visible = true;
            btn_difficile.Visible = false;
            adaptateur.SelectCommand = new OleDbCommand("select * from tb_difficilecampagne order by Temp", connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_modecampagne.Rows.Clear();
            dgv_modecampagne.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {

                dgv_modecampagne[0, i].Value = i + 1;
                dgv_modecampagne[1, i].Value = dt.Rows[i]["Nom"];
                dgv_modecampagne[2, i].Value = dt.Rows[i]["Coup"];
                dgv_modecampagne[3, i].Value = dt.Rows[i]["Temp"];
                
            }

            adaptateur.SelectCommand = new OleDbCommand("select * from tb_difficiletemp order by Temp ", connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            dgv_contretemps.Rows.Clear();
            dgv_contretemps.RowCount = dt.Rows.Count;
            for (i = 0; i < dt.Rows.Count; i++)
            {

                dgv_contretemps[0, i].Value = i + 1;
                dgv_contretemps[1, i].Value = dt.Rows[i]["Nom"];
                dgv_contretemps[2, i].Value = dt.Rows[i]["Coup"];
                dgv_contretemps[3, i].Value = dt.Rows[i]["Temp"];

            }

        }

        #endregion

        private void btn_moyen_Click(object sender, EventArgs e)
        {
            chargermoyen();
        }

        private void btn_difficile_Click(object sender, EventArgs e)
        {
            chargerdifficile();
        }

    }
}
