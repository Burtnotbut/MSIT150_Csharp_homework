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
    public partial class students_grade : Form
    {
        public students_grade()
        {
            InitializeComponent();
        }

        string[] subject = new string[] { "姓名", "國文", "英文", "數學", "總分", "平均", "最低", "最高"};  //宣告科目陣列
        
        string name;
        string chinese, english, math;


        private void random_add_button_Click(object sender, EventArgs e)
        {
            //foreach (string items in subject)
            //{
            //    grade_order_textBox.Text += "           " + items;
            //}
        }

        private void students_grade_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score_textBox.Text != "")
            {
                grade_order_textBox.Text = "           姓名           國文          英文          數學          總分          平均          最低          最高";
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            score_textBox.Text = "";
            most_textBox.Text = "";
            grade_order_textBox.Text = "";
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            name = name_textBox.Text;
            chinese = chinese_textBox.Text;
            english = english_textBox.Text;
            math = math_textBox.Text;
        }
    }
}
