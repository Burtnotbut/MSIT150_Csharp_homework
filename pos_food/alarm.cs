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
using System.Media;


namespace pos_food
{
    public partial class alarm : Form
    {
        public alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            h = int.Parse(hour_numericUpDown.Text);
            m = int.Parse(minute_numericUpDown.Text);
            s = int.Parse(second_numericUpDown.Text);

            time_label.Text = DateTime.Now.ToString("T");

            if (b == false  && set_checkBox.Checked == true)//證明時間沒到,進行一次時間判斷,時間到了就不要進行判斷
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            b = true;//證明時間剛好到了
                            DialogResult result;
                            result = MessageBox.Show("時間到");
                            if (result == DialogResult.OK)
                                b = false;
                        }
                    }
                }
            }
        }

        bool b = false;//這個變數記錄時間是否到了
        int h, m, s;

        private void alarm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
