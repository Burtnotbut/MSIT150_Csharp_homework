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
    public partial class student_struct : Form
    {
        string name;
        int chinese, english, math;
        int high, low;
        int[] grade_array;

        public student_struct()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            name = name_textBox.Text;
            chinese = Convert.ToInt32(chinese_textBox.Text);
            english = Convert.ToInt32(english_textBox.Text);
            math = Convert.ToInt32(math_textBox.Text);
        }

        private void show_save_button_Click(object sender, EventArgs e)
        {
            this.grade_order_textBox.Text = "姓名: " + name + "\r\n" + 
                "國文: " + chinese + "\r\n" +
                "英文: " + english + "\r\n" +
                "數學: " + math + "\r\n";
        }

        private void show_most_button_Click(object sender, EventArgs e)
        {
            int high;
            int low;

            grade_array = new int[]{ chinese, english, math};

            high = grade_array[0];
            low = grade_array[0];

            for (int a = 0; a < grade_array.Length; a++)
            {
                if ( high < grade_array[a])
                {
                    high = grade_array[a];
                }
            }

            for (int b = 0; b < grade_array.Length; b++)
            {
                if (low > grade_array[b])
                {
                    low = grade_array[b];
                }
            }

            string shhigh_a = "";
            string shhigh_b = "";
            string shhigh_c = "";
            string shlow_a = "";
            string shlow_b = "";
            string shlow_c = "";

            if ( chinese == high )
            {
                shhigh_a = "國文";
            }

            if ( english == high)
            {
                shhigh_b = "英文";
            }

            if ( math == high)
            {
                shhigh_c = "數學";
            }

            if ( chinese == low)
            {
                shlow_a = "國文";
            }

            if ( english == low)
            {
                shlow_b = "英文";
            }

            if ( math == low)
            {
               shlow_c  = "數學";
            }

            this.most_textBox.Text = "最高科目成績為 : " + shhigh_a + shhigh_b + shhigh_c + high + "分\r\n"
                + "最低科目成績為 : " + shlow_a +shlow_b + shlow_c + low + "分\r\n";
        }
    }
}
