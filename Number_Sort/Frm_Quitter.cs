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
    public partial class Frm_Quitter : Form
    {
        
        public Frm_Quitter()
        {
            
            InitializeComponent();
        }

        
        private void btn_oui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_non_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

    }
}
