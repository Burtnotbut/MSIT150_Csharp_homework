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
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using Gif.Components;

//隨機晃動
//mousemove//gif

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


        private int xDirection = 5;
        private int yDirection = 5;

        Random picture = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //移動圖片框
            this.label1.Left += this.xDirection;
            this.label1.Top += this.yDirection;

            //檢查是否碰到邊界，改變移動方向
            if (this.label1.Left < 0 || this.label1.Right > this.ClientSize.Width)
            {
                this.xDirection *= -1;
            }

            if (this.label1.Top < 0 || this.label1.Bottom > this.ClientSize.Height)
            {
                this.yDirection *= -1;
            }

            this.label1.Left += this.xDirection;
            this.label1.Top += this.yDirection;
        }


        int mmX, mmY; //繪圖動作起點
        Random R = new Random();

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("哈哈")

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Close();
        }






    }
}
