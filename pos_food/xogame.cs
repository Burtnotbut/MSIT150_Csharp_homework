using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//測試算完成

namespace pos_food
{
    public partial class xogame : Form
    {
        public xogame()
        {
            InitializeComponent();
        }


        //重玩按鍵
        private void reset_button_Click(object sender, EventArgs e)
        {
            N = 0; //玩次數歸零
            foreach( Control x in this.Controls ) //表單上的每一個控制項
            {
                if ( x is Label)  //如果是標籤物件
                {
                    ((Label)x).Text = "";    //清除文字內容
                    ((Label)x).Tag = "";  //清除標籤內容
                    ((Label)x).Image = null;  //清除影像
                    title_label.Text = "X O Game";
                    win_label.Text = "勝者是";
                }
            }
        }

        private void reset()
        {
            N = 0; //玩次數歸零
            foreach (Control x in this.Controls) //表單上的每一個控制項
            {
                if (x is Label)  //如果是標籤物件
                {
                    ((Label)x).Text = "";    //清除文字內容
                    ((Label)x).Tag = "";  //清除標籤內容
                    ((Label)x).Image = null;  //清除影像
                    title_label.Text = "X O Game";
                    win_label.Text = "勝者是";
                }
            }
        }

        //下棋動作控制程式
        Boolean T = false;  //下棋次序切換變數
        int N = 0; //下棋次數
        string whowin; //記錄誰贏
        private void C1_Click(object sender, EventArgs e)
        {
            if (win_label.Text == "勝者是") //未完成局
            { 
                Label c = sender as Label;
                if (c.Tag.ToString() == "")  //棋格為空的，則玩家可以點選
                {
                    if ( T == true ) 
                    {
                        c.Tag = "X";  //註記畫X
                        c.Text = "X";
                    }
                    else
                    {
                        c.Tag = "O";  //註記畫O
                        c.Text = "O";
                    }
                    T = !T;   //切換下棋序
                    N = N+1;  //計算下棋次數
                    whowin = ChkWin();
                    if ( whowin != "")  //確認是否有連線的情況了
                    {
                        win_label.Text = ChkWin() + "勝出!";
                        N = 0;
                    }
                    if (N == 9 && whowin == "")  //九次和局的狀況
                    {
                        DialogResult result;
                        win_label.Text = "平手";
                        result = MessageBox.Show("平手!按下確定重新開始");
                        if (result == DialogResult.OK)
                            reset();
                    }
                }
            }
        }

        private void xogame_Load(object sender, EventArgs e)
        {
            this.C2.Click += new System.EventHandler(this.C1_Click);
            this.C3.Click += new System.EventHandler(this.C1_Click);
            this.C4.Click += new System.EventHandler(this.C1_Click);
            this.C5.Click += new System.EventHandler(this.C1_Click);
            this.C6.Click += new System.EventHandler(this.C1_Click);
            this.C7.Click += new System.EventHandler(this.C1_Click);
            this.C8.Click += new System.EventHandler(this.C1_Click);
            this.C9.Click += new System.EventHandler(this.C1_Click);
            reset_button_Click(sender, e);
        }


        string ChkWin()
        {
            if (C1.Tag.ToString() + C2.Tag.ToString() + C3.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(橫一)
            if (C4.Tag.ToString() + C5.Tag.ToString() + C6.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(橫二)
            if (C7.Tag.ToString() + C8.Tag.ToString() + C9.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(橫三)
            if (C1.Tag.ToString() + C4.Tag.ToString() + C7.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(縱一)
            if (C2.Tag.ToString() + C5.Tag.ToString() + C8.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(縱二)
            if (C3.Tag.ToString() + C6.Tag.ToString() + C9.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(縱三)
            if (C1.Tag.ToString() + C5.Tag.ToString() + C9.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(斜一)
            if (C3.Tag.ToString() + C5.Tag.ToString() + C7.Tag.ToString() == "OOO") { return "O"; } //圈圈連線(斜二)
            if (C1.Tag.ToString() + C2.Tag.ToString() + C3.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(橫一)
            if (C4.Tag.ToString() + C5.Tag.ToString() + C6.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(橫二)
            if (C7.Tag.ToString() + C8.Tag.ToString() + C9.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(橫三)
            if (C1.Tag.ToString() + C4.Tag.ToString() + C7.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(縱一)
            if (C2.Tag.ToString() + C5.Tag.ToString() + C8.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(縱二)
            if (C3.Tag.ToString() + C6.Tag.ToString() + C9.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(縱三)
            if (C1.Tag.ToString() + C5.Tag.ToString() + C9.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(斜一)
            if (C3.Tag.ToString() + C5.Tag.ToString() + C7.Tag.ToString() == "XXX") { return "X"; } //叉叉連線(斜二)       
            return ""; //圈叉都未連線
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
