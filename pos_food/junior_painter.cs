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
    public partial class junior_painter : Form
    {
        public junior_painter()
        {
            InitializeComponent();
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();  //開啟對話方塊
            //main_textBox.ForeColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_textBox.BackColor = colorDialog1.Color;
            }
        }

        private void junior_painter_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            value_label.Text = trackBar1.Value.ToString();
        }

        int x0, y0; //繪圖動作起點
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X; 
            y0 = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value_label.Text = trackBar1.Value.ToString();
        }

            


        //塗鴉動作
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                //前為顏色，後為搖桿數值作為筆寬
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }
    }
}
