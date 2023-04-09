using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
        public static int inputanUser;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            inputanUser = Convert.ToInt32(textBoxTebakBerapa.Text);
            if(inputanUser >= 3)
            {
                FormGame.inputanUser = inputanUser;
                FormGame frm = new FormGame();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Angka tidak boleh kurang dari 3");
                textBoxTebakBerapa.Text = "";
            }
            
            
            
        }

        private void textBoxTebakBerapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harus Angka yaa", "NINUNINU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
