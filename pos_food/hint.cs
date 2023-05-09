using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pos_food
{

    public delegate void ChangeTextHandler(string str1, string str2, string tips);

    public partial class hint : Form
    {
        public hint()
        {
            InitializeComponent();
        }

        public event ChangeTextHandler ChangeText;

        private string Msg;
        int guess,  min, max;


        private void enter_button_Click(object sender, EventArgs e)
        {
            if ( int.TryParse(guess_value_textBox.Text, out int myguess))
            {
                if ( myguess >= 1 && myguess <= 100  )
                {
                    if (myguess == guess)
                    {
                        MessageBox.Show("Congradulations!! You got " + guess + "!!!");
                    }
                    else if ( myguess <= min || myguess >= max )
                    {
                        MessageBox.Show("請輸入" + min + "~" + max + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (myguess > guess)
                    {
                        max = myguess;
                        ChangeText(min.ToString(), max.ToString(), "Too Large!!!");
                    }
                    else if (myguess < guess)
                    {
                        min = myguess;
                        ChangeText(min.ToString(), max.ToString(), "Too Small!!!");
                    }
                }
                else 
                {
                    MessageBox.Show("請輸入" + min + "~" + max + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("請輸入" + min + "~" + max + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SendNumber(int guess_a, int min_a, int max_a)
        {
            guess = guess_a;
            min = min_a;
            max = max_a;
        }

    }
}
