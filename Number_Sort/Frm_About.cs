using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Sort
{
    public partial class Frm_About : Form
    {
        int y1 = 39;
        int y2 = 406;
        public Frm_About()
        {
            InitializeComponent();
        }

        private void tmr_change_Tick(object sender, EventArgs e)
        {
            y1--;
            y2--;
            if (y2 == 30)
            {
                
                panel2.Location = new Point(8,406);
                panel1.Location = new Point(2, 39);
                y1 = 39;
                y2 = 406;
            }
            // panel2.location = 8; Y(406);
            // panel1.location = 2; y(39)
            //y = haut/bas
            panel1.Location = new Point(2, y1);
            panel2.Location = new Point(8, y2);
        }

        
        private void Frm_Sobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Menu p = new Frm_Menu();
            p.Show();
            this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel2_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel2.BackColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
