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
    public partial class Frm_Defaite : Form
    {
        int n = 0;
        public Frm_Defaite()
        {
            InitializeComponent();
        }

        private void btn_oui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_non_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            if (n == 5)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
