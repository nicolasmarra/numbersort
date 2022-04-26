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
    public partial class Frm_win : Form
    {
        //int n = 0;
        public Frm_win()
        {
            InitializeComponent();
            
        }

        private void btn_non_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_win_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_oui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //n++;
            //if (n == 4)
            //{
            //    this.Hide();
            //}
        }
    }
}
