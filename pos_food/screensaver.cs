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

//隨機晃動
//mousemove

namespace pos_food
{
    public partial class screensaver : Form
    {
        public screensaver()
        {
            InitializeComponent();
        }

        private void screensaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void test_panel_Click(object sender, EventArgs e)
        {
            
        }


        private int xDirection = 5;
        private int yDirection = 5;

        Random picture = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //picture_panel.Left -= 5;
            //if (picture_panel.Right < 0) 
            //{
            //    picture_panel.Left = this.Width;
            //}

            //移動圖片框
            this.picture_panel.Left += this.xDirection;
            this.picture_panel.Top += this.yDirection;

            //檢查是否碰到邊界，改變移動方向
            if ( this.picture_panel.Left < 0 || this.picture_panel.Right > this.ClientSize.Width)
            {
                this.xDirection *= -1;
            }

            if ( this.picture_panel.Top < 0 || this.picture_panel.Bottom > this.ClientSize.Height)
            {
                this.yDirection *= -1;
            }

            this.picture_panel.Left += this.xDirection;
            this.picture_panel.Top += this.yDirection;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {


        }

        /*
        private void label1_TextChanged(object sender, EventArgs e)
        {
            if ( label1.Text != X：{ e.X }, Y：{ e.Y })
        }
        */

        int mmX, mmY; //繪圖動作起點
        Random R = new Random();

        private void test_panel_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Close();
        }



        private void screensaver_MouseMove(object sender, MouseEventArgs e)
        {
            //mmX = e.X;
            //mmY = e.Y;

            //if (mmX != e.X || mmY != e.Y)
            //{
            //    this.Close();
            //}

            //this.Close();
            //screensaver.Exit();
            //Application.Exit();

            //label1.Text = String.Format("X：{0}, Y：{1}", e.X, e.Y);

            //ixStart = e.X;
            //iyStart = e.Y;

            //if (ixStart == 0 &; &; iyStart == 0 )
            //    {
            //    ixStart = e.X;
            //    iyStart = e.Y;
            //    return;
            //}
            ////判斷自螢幕保護程式執行後,滑鼠的位置是否變動
            //else if (e.X != ixStart || e.Y != iyStart)
            //{
            //    //Cursor.Show();
            //    //timerSaver.Enabled = false;
            //    this.Close();
            //};

            //timer1.Start();

        }






    }
}
