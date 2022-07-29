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
    public partial class Frm_PlayTime : Form
    {
        string res,joueur;
        int s = 0, m = 0,t=0;
        int c,n = 4;
        bool son = true;
        OleDbConnection connexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + @"\db_numbersort.mdb"); 
        OleDbDataAdapter adaptateur = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();
        
        public Frm_PlayTime(string nom,string coup)
        {
            InitializeComponent();
            res = coup;
            joueur = nom;
     
        }

        private void ajouter()
        {
            connexion.Open();
            cmd.Connection = connexion;
            string nom = lbl_joueur.Text;
            int coup = int.Parse(lbl_coup.Text);
            int min = int.Parse(lbl_min.Text);
            int sec = int.Parse(lbl_sec.Text);
            int op = min * 60;
            int mn = 0;
            int sg = 0;
            int op1 = 0;
            if (t == 1)
            {
             
                    mn = 4;
                    sg = 60;
            }
            else if (t == 2)
            {
                mn = 3;
                sg = 60;
                    
            }
            else if (t == 3)
            {
                mn = 1;
                sg = 60;  

            }
            op1 = mn * 60;
            int rg = op1 + sg;
            int re = op + sec;
            int res = re - rg; 
            if (t == 1)
            {
                cmd.CommandText = "insert into tb_faciletemp(Nom,Coup,Temp) values (?,?,?)";
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Coup", coup);
                cmd.Parameters.AddWithValue("@Temp", res);

                cmd.ExecuteNonQuery();
            }
            else if (t == 2)
            {
                cmd.CommandText = "insert into tb_moyentemp(Nom,Coup,Temp) values (?,?,?)";
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Coup", coup);
                cmd.Parameters.AddWithValue("@Temp", res);

                cmd.ExecuteNonQuery();
            }
            else if (t == 3)
            {
                cmd.CommandText = "insert into tb_difficiletemp(Nom,Coup,Temp) values (?,?,?)";

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

        private void Frm_PlayTime_Load(object sender, EventArgs e)
        {
            if (res == "facile")
            {
                t = 1;
                m = 4;
                s = 60;
                melange_facile();
                pnl_facile.Visible = true;
                pnl_difficile.Visible = false;
                pnl_moyen.Visible = false;
            }
            else if (res == "moyen")
            {
                t = 2;
                m = 3;
                s = 60;
                pnl_moyen.Visible = true;
                pnl_facile.Visible = false;
                pnl_difficile.Visible = false;
                melange_moyen();
            }
            else if (res == "difficile")
            {
                t = 3;
                m = 1;
                s = 60;
                pnl_moyen.Visible = false;
                pnl_facile.Visible = false;
                pnl_difficile.Visible = true;
                melange_difficile();
            }
            lbl_joueur.Text = joueur;
            
        }
        private void melange_facile()
        {
            int i, j, res;
            int[] vet = new int[9];
            Boolean voir = false;
            i = 1;

            do
            {
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 8)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        voir = true;
                        break;
                    }

                }
                if (voir == true)
                {
                    voir = false;
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

        private void gagne()
        {
           
            if (btn_1.Text == "1" && btn_2.Text == "2" && btn_3.Text == "3" && btn_4.Text == "4" && btn_5.Text == "5" && btn_6.Text == "6" && btn_7.Text == "7" && btn_8.Text == "8" && btn_9.Text == "")
            {
               
               tmr_sec.Stop();
               ajouter(); 
               Frm_win w = new Frm_win();
               w.ShowDialog();
               n = 3;
               c = 0;
               tmr_ini.Start();
               melange_facile();
            
            }
        }

        private void change(Button btn_1, Button btn_2)
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

        private void melange_moyen()
        {
            int i, j, res;
            int[] vet = new int[16];
            Boolean voir = false;
            i = 1;

            do
            {
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        voir = true;
                        break;
                    }

                }
                if (voir == true)
                {
                    voir = false;
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
        private void win()
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" && btn4.Text == "4" && btn5.Text == "5" && btn6.Text == "6" && btn7.Text == "7" && btn8.Text == "8" && btn9.Text == "9" && btn10.Text == "10" && btn11.Text == "11" && btn12.Text == "12" && btn13.Text == "13" && btn14.Text == "14" && btn15.Text == "15" && btn16.Text == " ")
            {
                tmr_sec.Stop();
                ajouter();
                Frm_win w = new Frm_win();
                w.ShowDialog();
                n = 3;
                c = 0;
                tmr_ini.Start(); 
                melange_moyen();
                
            }
        }

        private void melange_difficile()
        {
            int i, j, res;
            int[] vet = new int[25];
            Boolean voir = false;
            i = 1;

            do
            {
                Random rnd = new Random();
                res = Convert.ToInt32((rnd.Next(0, 24)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (vet[j] == res)
                    {
                        voir = true;
                        break;
                    }

                }
                if (voir == true)
                {
                    voir = false;
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
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && button19.Text == "19" && button20.Text == "20" && button21.Text == "21" && button22.Text == "22"  && button23.Text == "23" && button24.Text == "24" && button25.Text == " " )
            
            {
                tmr_sec.Stop();
                ajouter();
                Frm_win w = new Frm_win();
                w.ShowDialog();
                n = 3;
                c = 0;
                tmr_ini.Start(); 
                melange_difficile();
            }
        }
        private void Frm_PlayTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region
        private void btn_1_Click(object sender, EventArgs e)
        {
            change(btn_1, btn_2);
            change(btn_1, btn_4);
            gagne();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            change(btn_9, btn_6);
            change(btn_9, btn_8);
            gagne();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            change(btn_2, btn_3);
            change(btn_2, btn_1);
            change(btn_2, btn_5);
            gagne();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            change(btn_3, btn_2);
            change(btn_3, btn_6);
            gagne();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            change(btn_4, btn_7);
            change(btn_4, btn_1);
            change(btn_4, btn_5);
            gagne();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            change(btn_5, btn_2);
            change(btn_5, btn_4);
            change(btn_5, btn_6);
            change(btn_5, btn_8);
            gagne();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            change(btn_6, btn_9);
            change(btn_6, btn_5);
            change(btn_6, btn_3);
            gagne();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            change(btn_7, btn_8);
            change(btn_7, btn_4);
            gagne();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            change(btn_8, btn_9);
            change(btn_8, btn_5);
            change(btn_8, btn_7);
            gagne();
        }
        #endregion
        private void tmr_ini_Tick(object sender, EventArgs e)
        {
            c = 0;
            lbl_coup.Text = c.ToString();
            n--;
            lbl_ini.Text = n.ToString();
            tmr_sec.Stop();
            pnl_jeu.Visible = false;
            if (n == 0)
            {
                lbl_ini.Text = "coupue!";
                pnl_jeu.Visible = true;
                tmr_ini.Stop();
                c = 0;
                lbl_coup.Text = c.ToString();
                if (t == 1)
                {
                    c = 0;
                    lbl_coup.Text = c.ToString();
                    m = 4;
                    s = 60;
                    tmr_sec.Start();
                }
                else if (t == 2)
                {

                    c = 0;
                    lbl_coup.Text = c.ToString();
                    m = 3;
                    s = 60;
                    tmr_sec.Start();
                }
                else if (t == 3)
                {
                    c = 0;
                    lbl_coup.Text = c.ToString();
                    m = 1;
                    s = 60;
                    tmr_sec.Start();
                }
                        
                
            }
            if (s == 0)
            {
                if(m==0)
                {
                    n--;
                    lbl_ini.Text = n.ToString();
                    if (n == 0)
                    {
                        pnl_jeu.Visible = true;
                        lbl_ini.Text = "Jouez!";
                        tmr_sec.Start();
                    }
                }
                
            }
        }

        private void tmr_sec_Tick(object sender, EventArgs e)
        {
            lbl_min.BackColor = Color.Honeydew;
            lbl_sec.BackColor = Color.Honeydew;
            panel2.BackColor = Color.Honeydew;
            lbl_sec.Text = s.ToString();
            lbl_min.Text = m.ToString();
            s--;
            pnl_jeu.Visible = true;
            if (s <= 10)
            {
                if (m == 0)
                {
                    lbl_min.BackColor = Color.Red;
                    lbl_sec.BackColor = Color.Red;
                    panel2.BackColor = Color.IndianRed;
                }
                
            }
            if (s == -1)
            {
                if (m == 0) 
                {

                        
                        tmr_sec.Stop();
                        Frm_Defaite d = new Frm_Defaite();
                        d.ShowDialog();
                        if (t == 1)
                        {
                            melange_facile();

                        }
                        else if (t == 2)
                        {

                            melange_moyen();

                        }
                        else if (t == 3)
                        {
                            melange_difficile();
                        }
                        n = 3;

                        tmr_ini.Start();
                  }
                
                else
                {
                    m = m - 1;

                    s = 60;
                } 
                
            }
            
        }
        #region
        private void btn1_Click(object sender, EventArgs e)
        {
            change(btn1, btn2);
            change(btn1, btn5);
            win();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            change(btn2, btn1);
            change(btn2, btn3);
            change(btn2, btn6);
            win();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            change(btn3, btn2);
            change(btn3, btn4);
            change(btn3, btn7);
            win();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            change(btn4, btn3);
            change(btn4, btn8);
            win();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            change(btn5, btn1);
            change(btn5, btn9);
            change(btn5, btn6);
            win();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            change(btn6, btn2);
            change(btn6, btn7);
            change(btn6, btn5);
            change(btn6, btn10); 
            win();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            change(btn7, btn3);
            change(btn7, btn8);
            change(btn7, btn6);
            change(btn7, btn11);
            win();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            change(btn8, btn4);
            change(btn8, btn7);
            change(btn8, btn12);
            win();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            change(btn9, btn13);
            change(btn9, btn5);
            change(btn9, btn10);
            win();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            change(btn10, btn6);
            change(btn10, btn11);
            change(btn10, btn14);
            change(btn10, btn9);
            win();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            change(btn11, btn12);
            change(btn11, btn7);
            change(btn11, btn15);
            change(btn11, btn10);
            win();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            change(btn12, btn8);
            change(btn12, btn11);
            change(btn12, btn16);
            win();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            change(btn13, btn9);
            change(btn13, btn14);
            win();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            change(btn14, btn10);
            change(btn14, btn13);
            change(btn14, btn15);
            win();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            change(btn15, btn11);
            change(btn15, btn14);
            change(btn15, btn16);
            win();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            change(btn16, btn12);
            change(btn16, btn15);
            win();
        }
#endregion

        #region 5X5
        private void button1_Click(object sender, EventArgs e)
        {
            change(button1, button6);
            change(button1, button2);
            gagner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change(button2, button1);
            change(button2, button3);
            change(button2, button7);
            gagner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change(button3, button2);
            change(button3, button4);
            change(button3, button8);
            gagner();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            change(button4, button5);
            change(button4, button3);
            change(button4, button9);
            gagner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change(button5, button4);
            change(button5, button10);
            gagner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            change(button6, button1);
            change(button6, button11);
            change(button6, button7);
            gagner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change(button7, button2);
            change(button7, button6);
            change(button7, button8);
            change(button7, button12);
            gagner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            change(button8, button3);
            change(button8, button7);
            change(button8, button9);
            change(button8, button13);
            gagner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            change(button9, button4);
            change(button9, button8);
            change(button9, button10);
            change(button9, button14);
            gagner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            change(button10, button9);
            change(button10, button15);
            change(button10, button5);
            gagner();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            change(button11, button6);
            change(button11, button12);
            change(button11, button16);
            gagner();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            change(button12, button11);
            change(button12, button17);
            change(button12, button7);
            change(button12, button13);
            gagner();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            change(button13, button12);
            change(button13, button8);
            change(button13, button18);
            change(button13, button14);
            gagner();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            change(button14, button13);
            change(button14, button9);
            change(button14, button19);
            change(button14, button15);
            gagner();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            change(button15, button10);
            change(button15, button20);
            change(button15, button14);
            gagner();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            change(button16, button11);
            change(button16, button21);
            change(button16, button17);
            gagner();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            change(button17, button12);
            change(button17, button18);
            change(button17, button16);
            change(button17, button22);
            gagner();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            change(button18, button13);
            change(button18, button17);
            change(button18, button19);
            change(button18, button23);
            gagner();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            change(button19, button14);
            change(button19, button18);
            change(button19, button20);
            change(button19, button24);
            gagner();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            change(button21, button16);
            change(button21, button22);
            gagner();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            change(button20, button19);
            change(button20, button15);
            change(button20, button25);
            gagner();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            change(button22, button17);
            change(button22, button21);
            change(button22, button23);
            gagner();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            change(button23, button18);
            change(button23, button22);
            change(button23, button24);
            gagner();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            change(button24, button19);
            change(button24, button23);
            change(button24, button25);
            gagner();
        
        }

        private void button25_Click(object sender, EventArgs e)
        {
                change(button25, button20);
                change(button25, button24);
                gagner();
        }
        #endregion

        private void btn_som_Click(object sender, EventArgs e)
        {
            son = false;
            btn_sonnot.Visible = true;
            btn_son.Visible = false;
        }

        private void btn_somnot_Click(object sender, EventArgs e)
        {
            son = true;
            btn_son.Visible = true;
            btn_sonnot.Visible = false;
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
        
    }
