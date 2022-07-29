using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Number_Sort
{
    public partial class Frm_Menu : Form
    {
        bool son = true;
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_contre_Click(object sender, EventArgs e)
        {
            musique(btn_contre);
            Frm_Choix f = new Frm_Choix("Contre le temps");
            f.Show();
            this.Hide();

        }

        private void btn_campagne_Click(object sender, EventArgs e)
        {
            musique(btn_campagne);
            Frm_Choix f = new Frm_Choix("Mode campagne");
            f.Show();
            this.Hide();

        }
        private void musique(Button btn)
        {
            
        }
        

        private void btn_recordes_Click(object sender, EventArgs e)
        {
            musique(btn_score);
            Frm_Score r = new Frm_Score();
            r.Show();
            this.Hide();
        }

        private void btn_somnot_Click(object sender, EventArgs e)
        {
            son = true;
            
        }

        private void btn_som_Click(object sender, EventArgs e)
        {
            son = false;
            
        }

        private void btn_aide_Click(object sender, EventArgs e)
        {
            Frm_About s = new Frm_About();
            s.Show();
            this.Hide();
        }


    }
}
