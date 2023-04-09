using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWordle
{
    public partial class FormGame : Form
    {
        public static int inputanUser;
        string tebakanUser = "";
       public string kataRandom;
        string wadahTebakan;
        int counterRow = 0;
        int counterCol = 0;
        int tebakanBenar = 0;
        bool menang = false;
        int multipleWord = 0;
        public FormGame()
        {
            InitializeComponent();
        }


        private Random acak = new Random();
        private Button[,] tebakKata = new Button[inputanUser, 5];
       public static string path = File.ReadAllText(@"E:\Bahar Project C#\GameWordle\Wordle Word List.txt", Encoding.UTF8);
        string[] liststring = path.Split(',');

        private void FormGame_Load(object sender, EventArgs e)
        {
            //button_a.Tag = "a";
            //button_b.Tag = "b";
            //button_c.Tag = "c";
            //button_d.Tag = "d";
            //button_e.Tag = "e";
            //button_f.Tag = "f";
            //button_g.Tag = "g";
            //button_h.Tag = "h";
            //button_i.Tag = "i";
            //button_j.Tag = "j";
            //button_k.Tag = "k";
            //button_l.Tag = "l";
            //button_m.Tag = "m";
            //button_n.Tag = "n";
            //button_o.Tag = "o";
            //button_p.Tag = "p";
            //button_q.Tag = "q";
            //button_r.Tag = "r";
            //button_s.Tag = "s";
            //button_t.Tag = "t";
            //button_u.Tag = "u";
            //button_v.Tag = "v";
            //button_w.Tag = "w";
            //button_x.Tag = "x";
            //button_y.Tag = "y";
            //button_z.Tag = "z";

            

            int num = acak.Next(0,liststring.Length);
            kataRandom = liststring[num];
            MessageBox.Show(kataRandom);
          
          
            for (int i = 0; i < inputanUser; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tebakKata[i, j] = new Button();
                    tebakKata[i, j].Size = new Size(50, 50);
                    tebakKata[i, j].Location = new Point(40 + j * 50, 50 + i * 50);
                    tebakKata[i, j].Text = "";
                    tebakKata[i, j].Enabled = true;
                    this.Controls.Add(tebakKata[i, j]);
                }
            }
        }
        private void wordButtonPressed(object sender, EventArgs e)
        {
             if (menang == false)
             {
              if (counterRow != 5)
              {
                    Button button = sender as Button;
                    tebakanUser = string.Concat(tebakanUser, button.Text);
                    wadahTebakan = tebakanUser;
                    tebakKata[counterCol, counterRow].Text = button.Text;
                    counterRow++;
                }
              
            }
        }

        private void button_q_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_w_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_r_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_t_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_y_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_u_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_i_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_o_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_p_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_d_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_f_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_g_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_h_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_j_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_k_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_l_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_z_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_v_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_n_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }

        private void button_m_Click(object sender, EventArgs e)
        {
            wordButtonPressed(sender, e);
        }


        private void hapus()
        {
            if (menang == false)
            {
                if (counterRow != 0)
                {
                    counterRow--;
                    tebakanUser = tebakanUser.Substring(0, counterRow);
                    wadahTebakan = tebakanUser;
                    tebakKata[counterCol, counterRow].Text = "";

                }
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void cekKondisi()
        {
            
            if(tebakanUser != "")
            {
                tebakanBenar = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (kataRandom[i] == tebakanUser.ToLower()[i])
                    {
                        tebakKata[counterCol, i].BackColor = Color.LightGreen;
                        //string ubahWarna = Convert.ToString(tebakanUser.ToLower()[i]);
                        //foreach (Control c in this.Controls)
                        //{
                        //    if (c is Button button)
                        //    {
                        //        string tag = button.Tag.ToString();

                        //        if (ubahWarna == tag)
                        //        {
                        //            button.BackColor = Color.LightYellow;
                        //        }
                        //    }
                        //}
                        tebakanBenar++;
                    }
                    else if (kataRandom.Contains<char>(tebakanUser.ToLower()[i]))
                    {
                        tebakKata[counterCol, i].BackColor = Color.LightYellow;
                        //string ubahWarna = Convert.ToString(tebakanUser.ToLower()[i]);
                        //foreach (Control c in this.Controls)
                        //{
                        //    if (c is Button button)
                        //    {
                        //        string tag = button.Tag.ToString();
                                
                        //        if(ubahWarna == tag) 
                        //        {
                        //            button.BackColor = Color.LightYellow;
                        //        }
                        //    }
                        //}


                    }
                }
                if (tebakanBenar == 5)
                {
                    MessageBox.Show("Selamat Anda Sangat Jeniusss!");
                    menang = true;
                }
                else if (counterCol == inputanUser - 1)
                {
                    MessageBox.Show(string.Concat("haha NT! Kata Yang dimaksud : ", kataRandom.ToUpper()));
                    menang = true;
                }
            }
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if(menang == false)
            {
                if(tebakKata[counterCol, 0].Text != "")
                {
                    if (!liststring.Contains<string>(tebakanUser.ToLower()))
                    {
                        MessageBox.Show(string.Concat("Kata ", tebakanUser, " gaada ya ajg"));
                        int simpan = counterRow;
                        for (int i = 0; i < simpan; i++)
                        {
                            counterRow--;
                            tebakanUser = tebakanUser.Substring(0, counterRow);
                            // wadahTebakan = tebakanUser;
                            tebakKata[counterCol, counterRow].Text = "";
                        }
                        simpan = 0;
                    }
                    else
                    {
                        cekKondisi();
                        counterCol++;
                        counterRow = 0;
                        tebakanUser = "";
                    }
                }
                else
                {
                    MessageBox.Show("isi huruf nya terlebih dahulu blok");
                }
                
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (menang == false)
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (menang == false)
                    {
                        if (counterRow != 0)
                        {
                            counterRow--;
                            tebakanUser = tebakanUser.Substring(0, counterRow);
                            wadahTebakan = tebakanUser;
                            tebakKata[counterCol, counterRow].Text = "";

                        }
                    }
                }
                else if(e.KeyCode == Keys.Enter)
                {
                    if (menang == false)
                    {
                        if (tebakKata[counterCol, 0].Text != "")
                        {
                            if (!liststring.Contains<string>(tebakanUser.ToLower()))
                            {
                                MessageBox.Show(string.Concat("Kata ", tebakanUser, " gaada ya ajg"));
                                int simpan = counterRow;
                                for (int i = 0; i < simpan; i++)
                                {
                                    counterRow--;
                                    tebakanUser = tebakanUser.Substring(0, counterRow);
                                    // wadahTebakan = tebakanUser;
                                    tebakKata[counterCol, counterRow].Text = "";
                                }
                                simpan = 0;
                            }
                            else
                            {
                                cekKondisi();
                                counterCol++;
                                counterRow = 0;
                                tebakanUser = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("isi huruf nya terlebih dahulu blok");
                        }

                    }
                }
                else
                {
                    if (counterRow != 5)
                    {
                        tebakanUser = string.Concat(tebakanUser, e.KeyCode.ToString());
                        wadahTebakan = tebakanUser;
                        tebakKata[counterCol, counterRow].Text = e.KeyCode.ToString();
                        counterRow++;
                    }
                }
              
            }
           
        }
    }
}
