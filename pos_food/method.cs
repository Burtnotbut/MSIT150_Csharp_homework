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
using System.Collections;

namespace pos_food
{
    public partial class method : Form
    {
        public method()
        {
            InitializeComponent();
        }

        int user_num;

        //判斷奇偶數
        private void odd_even_button_Click(object sender, EventArgs e)
        {

            if (int.TryParse(number_textBox.Text, out user_num))
            {
                if ( user_num % 2 == 0)
                {
                    answer_label.Text = "輸入的數字 " + user_num + " 為偶數。";
                } else
                {
                    answer_label.Text = "輸入的數字 " + user_num + " 為奇數。";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }


        private void clean_button_Click(object sender, EventArgs e)
        {
            answer_label.Text = "結果";
        }


        //宣告陣列arr0711
        //int[] arr0711 = new int[] {1, 5, 6, 8, 7, 97, 54, 887, 65, 578};

        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        
        //統計奇偶數
        private void question1_button_Click(object sender, EventArgs e)
        {
            //泛用集合
            List<int> arr_odd = new List<int>();
            List<int> arr_even = new List<int>();

            for ( int a = 0; a < arr0711.Length; a++)
            {
                if (arr0711[a] % 2 == 0)
                {
                    arr_odd.Add(arr0711[a]);
                }
                else
                {
                    arr_even.Add(arr0711[a] );
                }
            }
            answer_label.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n奇數共" + arr_even.Count + "\r\n偶數共" + arr_odd.Count;
        }

        //求最大最小值
        private void question2_button_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            int min = arr0711.Min();

            answer_label.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最大值為" + max + "\r\n最小值為" + min;
        }

        //求最長的名字
        private void question3_button_Click(object sender, EventArgs e)
        {
            Array.Sort(arr0711_Str);
            int num = arr0711_Str.Length;
            foreach (string str in arr0711_Str)
            {
                answer_label.Text += str;
            }
        }
    }
}
