using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_food
{
    public partial class myclac : Form
    {
        public myclac()
        {
            InitializeComponent();
        }

        double num1, num2, ans;



        private void add_button_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1_textBox.Text);
            num2 = Convert.ToDouble(num2_textBox.Text);
            ans = num1 + num2;
            answer_textBox.Text = Convert.ToString(ans);
        }


        private void sub_button_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1_textBox.Text);
            num2 = Convert.ToDouble(num2_textBox.Text);
            ans = num1 - num2;
            answer_textBox.Text = Convert.ToString(ans);
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1_textBox.Text);
            num2 = Convert.ToDouble(num2_textBox.Text);
            ans = num1 * num2;
            answer_textBox.Text = Convert.ToString(ans);
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1_textBox.Text);
            num2 = Convert.ToDouble(num2_textBox.Text);
            ans = num1 / num2;
            answer_textBox.Text = Convert.ToString(ans);
        }
    }
}
