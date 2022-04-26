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
using System.Data.OleDb;
namespace Number_Sort
{
    public partial class Frm_PlayCamp : Form
    {
        string res,joueur;
        int s = 0, m = 0;
        int  n = 4;
        int c;
        bool son = true;
        OleDbConnection connexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + @"\db_numbersort.mdb");
        OleDbDataAdapter adaptateur = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();
        int r = 0;
        public Frm_PlayCamp(string nom, string coup)
        {
            
            InitializeComponent();
            joueur = coup;
            res = nom;
        }

        private void inserir()
        {
            connexion.Open();
            cmd.Connection = connexion;
            string nom = lbl_joueur.Text;
            int coup = int.Parse(lbl_coup.Text);
            int min = int.Parse(lbl_min.Text);
            int seg = int.Parse(lbl_sec.Text);
            int op = min * 60;
            int res = op + seg;
            if (r == 1)
            {
                cmd.CommandText = "insert into tb_facilecampagne(Nom,Coup,Temp) values (?,?,?)";
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Coup", coup);
                cmd.Parameters.AddWithValue("@Temp", res);

                cmd.ExecuteNonQuery();
            }
            else if (r == 2)
            {
                cmd.CommandText = "insert into tb_moyencampagne(Nom,Coup,Temp) values (?,?,?)";
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Coup", coup);
                cmd.Parameters.AddWithValue("@Temp", res);

                cmd.ExecuteNonQuery();
            }
            else if (r == 3)
            {
                cmd.CommandText = "insert into tb_difficilecampagne(Nom,Coup,Temp) values (?,?,?)";
                
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Coup", coup);
                cmd.Parameters.AddWithValue("Temp", res);

                cmd.ExecuteNonQuery();
            }
            connexion.Close();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            Frm_Menu p = new Frm_Menu();
            p.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Frm_Quitter d = new Frm_Quitter();
            d.ShowDialog();

        }

        private void Frm_PlayCamp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void tmr_sec_Tick(object sender, EventArgs e)
        {
            lbl_sec.Text = s.ToString();
            lbl_min.Text = m.ToString();
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
            }
        }


        private void tmr_ini_Tick(object sender, EventArgs e)
        {
            c = 0;
            lbl_coup.Text = c.ToString();
            n--;
            lbl_info.Text = n.ToString();
            pnl_jeu.Visible = false;
            if (n == 0)
            {
                m = 0;
                s = 0;
                c = 0;
                lbl_coup.Text = c.ToString();
                lbl_info.Text = "Jouez!";
                pnl_jeu.Visible = true;
                tmr_ini.Stop();
                tmr_sec.Start();
            }
        }

        
        
        
        private void melange_facile()
        {
            int i, j, res;
            int[] vet = new int[9];
            Boolean ver = false;
            i = 1;

            do
            {
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 8)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        ver = true;
                        break;
                    }

                }
                if (ver == true)
                {
                    ver = false;
                }
                else
                {
                    vet[i] = res;
                    i = i + 1;
                }
            }
            while (i <= 8);
            btn_1.Text = Convert.ToString(vet[1]);
            btn_2.Text = Convert.ToString(vet[2]);
            btn_3.Text = Convert.ToString(vet[3]);
            btn_4.Text = Convert.ToString(vet[4]);
            btn_5.Text = Convert.ToString(vet[5]);
            btn_6.Text = Convert.ToString(vet[6]);
            btn_7.Text = Convert.ToString(vet[7]);
            btn_8.Text = Convert.ToString(vet[8]);
            btn_9.Text = "";
        }
        private void melange_moyen()
        {
            int i, j, res;
            int[] vet = new int[16];
            Boolean ver = false;
            i = 1;

            do
            {
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        ver = true;
                        break;
                    }

                }
                if (ver == true)
                {
                    ver = false;
                }
                else
                {
                    vet[i] = res;
                    i = i + 1;
                }
            }
            while (i <= 15);
            btn1.Text = Convert.ToString(vet[1]);
            btn2.Text = Convert.ToString(vet[2]);
            btn3.Text = Convert.ToString(vet[3]);
            btn4.Text = Convert.ToString(vet[4]);
            btn5.Text = Convert.ToString(vet[5]);
            btn6.Text = Convert.ToString(vet[6]);
            btn7.Text = Convert.ToString(vet[7]);
            btn8.Text = Convert.ToString(vet[8]);
            btn9.Text = Convert.ToString(vet[9]);
            btn10.Text = Convert.ToString(vet[10]);
            btn11.Text = Convert.ToString(vet[11]);
            btn12.Text = Convert.ToString(vet[12]);
            btn13.Text = Convert.ToString(vet[13]);
            btn14.Text = Convert.ToString(vet[14]);
            btn15.Text = Convert.ToString(vet[15]);
            btn16.Text = "";
        }
        private void gagne()
        {

            if (btn_1.Text == "1" && btn_2.Text == "2" && btn_3.Text == "3" && btn_4.Text == "4" && btn_5.Text == "5" && btn_6.Text == "6" && btn_7.Text == "7" && btn_8.Text == "8" && btn_9.Text == "")
            {
                tmr_sec.Stop();
                inserir();
                Frm_win w = new Frm_win();
                w.ShowDialog();
                n = 3;
                s = 0;
                m = 0;
                c = 0;
                tmr_ini.Start();
                melange_facile();

            }
        }
        private void troca(Button btn_1, Button btn_2)
        {
            if (btn_2.Text == "")
            {
                c = c + 1;
                lbl_coup.Text = c.ToString();
                btn_2.Text = btn_1.Text;
                btn_1.Text = "";
                n = 0;
            }
            n = 1;
        }
        private void Frm_PlayCamp_Load(object sender, EventArgs e)
        {
            if (res == "facile")
            {
                r = 1;
                melange_facile();
                pnl_facile.Visible = true;
                pnl_difficile.Visible = false;
                pnl_moyen.Visible = false;
            }
            else if (res == "moyen")
            {
                r = 2;
                pnl_moyen.Visible = true;
                pnl_facile.Visible = false;
                pnl_difficile.Visible = false;
                melange_moyen();
            }
            else if (res == "difficile")
            {
                r = 3;
                pnl_moyen.Visible = false;
                pnl_facile.Visible = false;
                pnl_difficile.Visible = true;
                melange_difficile();
            }
            lbl_joueur.Text = joueur;
            
        }

        #region
        private void btn_1_Click(object sender, EventArgs e)
        {
            troca(btn_1, btn_2);
            troca(btn_1, btn_4);
            gagne();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            troca(btn_2, btn_3);
            troca(btn_2, btn_1);
            troca(btn_2, btn_5);
            gagne();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            troca(btn_3, btn_2);
            troca(btn_3, btn_6);
            gagne();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            troca(btn_4, btn_7);
            troca(btn_4, btn_1);
            troca(btn_4, btn_5);
            gagne();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            troca(btn_5, btn_2);
            troca(btn_5, btn_4);
            troca(btn_5, btn_6);
            troca(btn_5, btn_8);
            gagne();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            troca(btn_6, btn_9);
            troca(btn_6, btn_5);
            troca(btn_6, btn_3);
            gagne();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            troca(btn_7, btn_8);
            troca(btn_7, btn_4);
            gagne();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            troca(btn_8, btn_9);
            troca(btn_8, btn_5);
            troca(btn_8, btn_7);
            gagne();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            troca(btn_9, btn_6);
            troca(btn_9, btn_8);
            gagne();
        }

#endregion

        private void win()
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" && btn4.Text == "4" && btn5.Text == "5" && btn6.Text == "6" && btn7.Text == "7" && btn8.Text == "8" && btn9.Text == "9" && btn10.Text == "10" && btn11.Text == "11" && btn12.Text == "12" && btn13.Text == "13" && btn14.Text == "14" && btn15.Text == "15" && btn16.Text == "")
            {
                tmr_sec.Stop();
                inserir();
                Frm_win w = new Frm_win();
                w.Show();
                n = 3;
                s = 0; 
                m = 0;
                c = 0;
                tmr_ini.Start();
                
                melange_moyen();
                 
            }
        }

        #region
        private void btn1_Click(object sender, EventArgs e)
        {
            troca(btn1, btn2);
            troca(btn1, btn5);
            win();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            troca(btn2, btn1);
            troca(btn2, btn3);
            troca(btn2, btn6);
            win();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            troca(btn3, btn2);
            troca(btn3, btn4);
            troca(btn3, btn7);
            win();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            troca(btn4, btn3);
            troca(btn4, btn8);
            win();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            troca(btn5, btn1);
            troca(btn5, btn9);
            troca(btn5, btn6);
            win();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            troca(btn6, btn2);
            troca(btn6, btn7);
            troca(btn6, btn5);
            troca(btn6, btn10);
            win();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            troca(btn7, btn3);
            troca(btn7, btn8);
            troca(btn7, btn6);
            troca(btn7, btn11);
            win();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            troca(btn8, btn4);
            troca(btn8, btn7);
            troca(btn8, btn12);
            win();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            troca(btn9, btn13);
            troca(btn9, btn5);
            troca(btn9, btn10);
            win();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            troca(btn10, btn6);
            troca(btn10, btn11);
            troca(btn10, btn14);
            troca(btn10, btn9);
            win();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            troca(btn11, btn12);
            troca(btn11, btn7);
            troca(btn11, btn15);
            troca(btn11, btn10);
            win();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            troca(btn12, btn8);
            troca(btn12, btn11);
            troca(btn12, btn16);
            win();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            troca(btn13, btn9);
            troca(btn13, btn14);
            win();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            troca(btn14, btn10);
            troca(btn14, btn13);
            troca(btn14, btn15);
            win();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            troca(btn15, btn11);
            troca(btn15, btn14);
            troca(btn15, btn16);
            win();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            troca(btn16, btn12);
            troca(btn16, btn15);
            win();
        }
#endregion

        private void melange_difficile()
        {
            int i, j, res;
            int[] vet = new int[25];
            Boolean ver = false;
            i = 1;

            do
            {
                
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 24)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        ver = true;
                        break;
                    }

                }
                if (ver == true)
                {
                    ver = false;
                }
                else
                {
                    vet[i] = res;
                    i = i + 1;
                }
            }
            while (i <= 24);
            button1.Text = Convert.ToString(vet[1]);
            button2.Text = Convert.ToString(vet[2]);
            button3.Text = Convert.ToString(vet[3]);
            button4.Text = Convert.ToString(vet[4]);
            button5.Text = Convert.ToString(vet[5]);
            button6.Text = Convert.ToString(vet[6]);
            button7.Text = Convert.ToString(vet[7]);
            button8.Text = Convert.ToString(vet[8]);
            button9.Text = Convert.ToString(vet[9]);
            button10.Text = Convert.ToString(vet[10]);
            button11.Text = Convert.ToString(vet[11]);
            button12.Text = Convert.ToString(vet[12]);
            button13.Text = Convert.ToString(vet[13]);
            button14.Text = Convert.ToString(vet[14]);
            button15.Text = Convert.ToString(vet[15]);
            button16.Text = Convert.ToString(vet[16]);
            button17.Text = Convert.ToString(vet[17]);
            button18.Text = Convert.ToString(vet[18]);
            button19.Text = Convert.ToString(vet[19]);
            button20.Text = Convert.ToString(vet[20]);
            button21.Text = Convert.ToString(vet[21]);
            button22.Text = Convert.ToString(vet[22]);
            button23.Text = Convert.ToString(vet[23]);
            button24.Text = Convert.ToString(vet[24]);
            button25.Text = "";

        }
        private void gagner()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && button19.Text == "19" && button20.Text == "20" && button21.Text == "21" && button22.Text == "22" && button23.Text == "23" && button24.Text == "24" && button25.Text == "")
            {
                tmr_sec.Stop();
                inserir();                
                Frm_win w = new Frm_win();
                w.ShowDialog();
                n = 3;
                c = 0;
                m = 0;
                s = 0;
                tmr_ini.Start();
                melange_difficile();
            }
        }

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            troca(button1, button6);
            troca(button1, button2);
            gagner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            troca(button2, button1);
            troca(button2, button3);
            troca(button2, button7);
            gagner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            troca(button3, button2);
            troca(button3, button4);
            troca(button3, button8);
            gagner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            troca(button4, button5);
            troca(button4, button3);
            troca(button4, button9);
            gagner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            troca(button5, button4);
            troca(button5, button10);
            gagner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            troca(button6, button1);
            troca(button6, button11);
            troca(button6, button7);
            gagner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            troca(button7, button2);
            troca(button7, button6);
            troca(button7, button8);
            troca(button7, button12);
            gagner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            troca(button8, button3);
            troca(button8, button7);
            troca(button8, button9);
            troca(button8, button13);
            gagner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            troca(button9, button4);
            troca(button9, button8);
            troca(button9, button10);
            troca(button9, button14);
            gagner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            troca(button10, button9);
            troca(button10, button15);
            troca(button10, button5);
            gagner();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            troca(button11, button6);
            troca(button11, button12);
            troca(button11, button16);
            gagner();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            troca(button12, button11);
            troca(button12, button17);
            troca(button12, button7);
            troca(button12, button13);
            gagner();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            troca(button13, button12);
            troca(button13, button8);
            troca(button13, button18);
            troca(button13, button14);
            gagner();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            troca(button14, button13);
            troca(button14, button9);
            troca(button14, button19);
            troca(button14, button15);
            gagner();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            troca(button15, button10);
            troca(button15, button20);
            troca(button15, button14);
            gagner();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            troca(button16, button11);
            troca(button16, button21);
            troca(button16, button17);
            gagner();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            troca(button17, button12);
            troca(button17, button18);
            troca(button17, button16);
            troca(button17, button22);
            gagner();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            troca(button18, button13);
            troca(button18, button17);
            troca(button18, button19);
            troca(button18, button23);
            gagner();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            troca(button19, button14);
            troca(button19, button18);
            troca(button19, button20);
            troca(button19, button24);
            gagner();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            troca(button20, button19);
            troca(button20, button15);
            troca(button20, button25);
            gagner();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            troca(button21, button16);
            troca(button21, button22);
            gagner();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            troca(button22, button17);
            troca(button22, button21);
            troca(button22, button23);
            gagner();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            troca(button23, button18);
            troca(button23, button22);
            troca(button23, button24);
            gagner();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            troca(button24, button19);
            troca(button24, button23);
            troca(button24, button25);
            gagner();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            troca(button25, button20);
            troca(button25, button24);
            gagner();
        }
#endregion

        private void btn_son_Click(object sender, EventArgs e)
        {
            son = false;
            btn_sonnot.Visible = true;
            btn_son.Visible = false;
        }

        private void btn_sonnot_Click(object sender, EventArgs e)
        {
            son = true;
            btn_son.Visible = true;
            btn_sonnot.Visible = false;
        }
        private void sonbtn()
        {
            if (son == true)
            {

            }
            else
            {

            }
        }
        private void sonwin()
        {
            if (son == true)
            {

            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
