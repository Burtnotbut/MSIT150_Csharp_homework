using Docker.DotNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace pos_food
{
    public partial class guess_number : Form
    {
        public guess_number()
        {
            InitializeComponent();
        }

        int guess, min, max;
        //開始時，畫面載入
        private void guess_number_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 100);
            min = 1;
            max = 100;
            title_label.Text = "Please Select A Number Between 1 to 100!";
        }

        //猜數字的框框
        private void guess_button_Click(object sender, EventArgs e)
        {
            //展示輸入數字的畫面
            hint input = new hint();
            input.SendNumber(guess, min, max);
            input.ChangeText += new ChangeTextHandler(Change_Text);
            input.ShowDialog();
        }

        //回傳數值
        public void BackNumber(int min_b, int max_b)
        {
            min = min_b;
            max = max_b;
        }

        public void Change_Text(string str1, string str2, string tips)
        {
            title_label.Text = tips + "\r\nBetween " + str1 + " and " + str2;
        }

        private void show_ans_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: " + guess);
        }
    }
}
