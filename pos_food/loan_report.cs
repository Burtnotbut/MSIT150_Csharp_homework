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
    public partial class loan_report : Form
    {
        public loan_report()
        {
            InitializeComponent();
        }

        public void SetTextBox(string text1, string text2, string text3, double text4, double text5) //實作一個公開方法，使其他Form可以傳遞資料進來
        {
            money2_label.Text = text1;
            time2_label.Text = text2;
            interest2_label.Text = text3;
            month_pay2_label.Text = text4.ToString();
            total_pay2_label.Text = text5.ToString();
        }

        private void email_button_Click(object sender, EventArgs e)
        {

        }
    }
}
