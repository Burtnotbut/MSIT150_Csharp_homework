using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//圖片功能顯示

namespace pos_food
{
    public partial class notepad : Form
    {
        public notepad()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                main_textBox.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, main_textBox.Text, Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";  //將openFileDialog1的FileName屬性設為空字串
            main_textBox.Clear();  //內容清除
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "") //沒有已開啟檔名，以另存新檔處理
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, main_textBox.Text, Encoding.Default);
                }    
            }
            else  //已有開啟檔名，直接回存，新內容寫入舊檔案
            {
                File.WriteAllText(saveFileDialog1.FileName, main_textBox.Text, Encoding.Default);
            }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_textBox.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_textBox.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_textBox.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_textBox.SelectAll();
        }

        private void 搜尋SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_panel.Visible = true;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            search_panel.Visible =false;
        }

        //搜尋-->功能不全
        private void search_button_Click(object sender, EventArgs e)
        {
            int P;
            if (main_textBox.SelectionLength > 0)
            {  //已有目標搜尋到時
                P = main_textBox.Text.IndexOf(search_textBox.Text, main_textBox.SelectionStart + 1);
            }
            else
            {  //尚無目標被搜尋到時
                P = main_textBox.Text.IndexOf(search_textBox.Text, main_textBox.SelectionStart);
            }

            if (P < 0 ) 
            {  //找不到目標時，p值沒有+1，
                MessageBox.Show("未發現搜尋字串!");
            }
            else
            {  //找到目標時，選取被找到的目標
                main_textBox.SelectionStart = P;
                main_textBox.SelectionLength = search_textBox.TextLength;
                main_textBox.Select();
            }
        }

        //取代
        private void replace_button_Click(object sender, EventArgs e)
        {
            main_textBox.SelectedText = replace_textBox.Text;
        }


        //拖曳搜尋取代面板
        int mdx, mdy;
        //開始拖曳 
        private void search_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }



        private void search_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) //左鍵為按下狀態
            {
                search_panel.Left += e.X - mdx;
                search_panel.Top += e.Y - mdy;
            }
        }


        //顏色選擇
        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();  //開啟對話方塊
            main_textBox.ForeColor = colorDialog1.Color;  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";  //將openFileDialog1的FileName屬性設為空字串
            main_textBox.Clear();  //內容清除
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";  //將openFileDialog1的FileName屬性設為空字串
            main_textBox.Clear();  //內容清除
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                main_textBox.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "") //沒有已開啟檔名，以另存新檔處理
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, main_textBox.Text, Encoding.Default);
                }
            }
            else  //已有開啟檔名，直接回存，新內容寫入舊檔案
            {
                File.WriteAllText(saveFileDialog1.FileName, main_textBox.Text, Encoding.Default);
            }
        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            main_textBox.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            main_textBox.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            main_textBox.Paste();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info input = new info();
            input.ShowDialog();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            info input = new info();
            input.ShowDialog();
        }







        //字型選擇
        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();  //開啟對話方塊
            main_textBox.Font = fontDialog1.Font;
        }
    }
}
