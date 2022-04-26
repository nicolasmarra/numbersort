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
    public partial class Frm_Choix : Form
    {
        public Frm_Choix(string nom)
        {
            
            InitializeComponent();
            lbl_mode.Text = nom;
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Choix_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void txt_player_TextChanged(object sender, EventArgs e)
        {
            if (txt_player.Text != "")
            {
                btn_difficile.Enabled = true;
                btn_facile.Enabled = true;
                btn_moyen.Enabled = true;
                
            }
            else
            {
                btn_difficile.Enabled = false;
                btn_facile.Enabled = false;
                btn_moyen.Enabled = false;

            }
        }

        private void musique(Button btn)
        {
            
        }
        private void btn_facile_Click(object sender, EventArgs e)
        {
            musique(btn_facile);
            if (lbl_mode.Text == "Mode campagne")
            {
                Frm_PlayCamp c = new Frm_PlayCamp("facile",txt_player.Text);
                c.Show();
                this.Hide();
            }
            else
            {
                Frm_PlayTime t = new Frm_PlayTime("facile",txt_player.Text);
                t.Show();
                this.Hide();
            }
        }

        private void btn_moyen_Click(object sender, EventArgs e)
        {
            musique(btn_moyen);
            if (lbl_mode.Text == "Mode campagne")
            {
                Frm_PlayCamp c = new Frm_PlayCamp("moyen", txt_player.Text);
                c.Show();
                this.Hide();
            }
            else
            {
                Frm_PlayTime t = new Frm_PlayTime("moyen", txt_player.Text);
                t.Show();
                this.Hide();
            }
        }

        private void btn_difficile_Click(object sender, EventArgs e)
        {
            musique(btn_difficile);
            if (lbl_mode.Text == "Mode campagne")
            {
                Frm_PlayCamp c = new Frm_PlayCamp("difficile", txt_player.Text);
                c.Show();
                this.Hide();
            }
            else
            {
                Frm_PlayTime t = new Frm_PlayTime("difficile", txt_player.Text);
                t.Show();
                this.Hide();
            }
        }

        
    }
}
