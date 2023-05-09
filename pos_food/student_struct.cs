using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//同分問題

namespace pos_food
{
    public partial class student_struct : Form
    {
        string name;
        int chinese, english, math;
        int high, low;
        int[] grade_array;
        int rehigh, relow;
        string shhigh, shlow;

        private void grade_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void grade_order_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void most_textBox_TextChanged(object sender, EventArgs e)
        {

        }


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


            grade_array = new int[]{ chinese, english, math};

            for (int a = 0; a < grade_array.Length; a++)
            {
                high = grade_array[0];
                if ( high < grade_array[a])
                {
                    high = grade_array[a];
                    rehigh = a;
                }
            }

            for (int b = 0; b < grade_array.Length; b++)
            {
                low = grade_array[0];
                if (low > grade_array[b])
                {
                    low = grade_array[b];
                    relow = b;
                }
            }

            if ( rehigh == 0 )
            {
                shhigh = "國文";
            }

            if (rehigh == 1)
            {
                shhigh = "英文";
            }

            if (rehigh == 2)
            {
                shhigh = "數學";
            }

            if (relow == 0)
            {
                shlow = "國文";
            }

            if (relow == 1)
            {
                shlow = "英文";
            }

            if (relow == 2)
            {
                shlow = "數學";
            }

            this.most_textBox.Text = "最高科目成績為 : " + shhigh + high + "分\r\n"
                + "最低科目成績為 : " + shlow + low + "分\r\n";



        }



    }
}
