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
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_temp_Tick(object sender, EventArgs e)
        {
            n++;            
            if (n == 30)
            {
                Frm_Menu p = new Frm_Menu();
                p.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
