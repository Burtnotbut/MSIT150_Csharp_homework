using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_food
{
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void sayhello_button_Click(object sender, EventArgs e)
        {
            string gender;
            string eng_gender;

            if (gender_comboBox.Text == "男性")
            {
                gender = "先生";
                eng_gender = "Mr ";
            }
            else
            {
                gender = "小姐";
                eng_gender = "Miss ";
            }

            MessageBox.Show( name_textBox.Text + gender + ", 你好!\r\n"  + eng_gender + english_textBox.Text + " , hi!\r\n" 
                + "生日是" + dateTimePicker .Text + "\r\n" + "星座是" + star_textBox.Text + "\r\n" + "柴犬祝你發大財~");
        }
    }
}
