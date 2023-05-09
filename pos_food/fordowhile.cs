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
    public partial class fordowhile : Form
    {
        public fordowhile()
        {
            InitializeComponent();
        }

        int user_num;

        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
       
        //判斷奇偶數
        private void odd_even_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(number_textBox.Text, out user_num))
            {
                if (user_num % 2 == 0)
                {
                    answer_label.Text = "輸入的數字 " + user_num + " 為偶數。";
                }
                else
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


        private void ninenine_button_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 1; i < 10; i += 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    answer_label.Text += ($"{i:##} * {j:##} = {i * j:##}");
                    answer_label.Text += ($"{(i + 1):##} * {j:##} = {(i + 1) * j}");
                    answer_label.Text += ($"{(i + 2):##} * {j:##} = {(i + 2) * j}\r\n");
                }
                //answer_label.Text += "";
                //Console.WriteLine();
            }
            //Console.ReadKey();
            */
            
            answer_label.Text = "九九乘法表\r\n" +
                "2*1= 2|  3*1= 3|   4*1= 4|  5*1=  5|  6*1=  6|    7*1=   7|  8*1= 8|  9*1=  9|\r\n" +
                "2*2= 4|  3*2= 6|   4*2= 8|  5*2=10|  6*2=12|   7*2=14|  8*2=16|  9*2=18|\r\n" +
                "2*3= 6|  3*3= 9|   4*3=12|  5*3=15|  6*3=18|   7*3=21|  8*3=24|  9*3=27|\r\n" +
                "2*4= 8|  3*4=12|   4*4=16|  5*4=20|  6*4=24|   7*4=28|  8*4=32|  9*4=36|\r\n" +
                "2*5=10|  3*5=15|   4*5=20|  5*5=25|  6*5=30|   7*5=35|  8*5=40|  9*5=45|\r\n" +
                "2*6=12|  3*6=18|   4*6=24|  5*6=30|  6*6=36|   7*6=42|  8*6=48|  9*6=54|\r\n" +
                "2*7=14|  3*7=21|   4*7=28|  5*7=35|  6*7=42|   7*7=49|  8*7=56|  9*7=63|\r\n" +
                "2*8=16|  3*8=24|   4*8=32|  5*8=40|  6*8=48|   7*8=56|  8*8=64|  9*8=72|\r\n" +
                "2*9=18|  3*9=27|   4*9=36|  5*9=45|  6*9=54|   7*9=63|  8*9=72|  9*9=81|\r\n";
        
        }

        //統計奇偶數
        private void question1_button_Click(object sender, EventArgs e)
        {
            //泛用集合
            List<int> arr_odd = new List<int>();
            List<int> arr_even = new List<int>();

            for (int a = 0; a < arr0711.Length; a++)
            {
                if (arr0711[a] % 2 == 0)
                {
                    arr_odd.Add(arr0711[a]);
                }
                else
                {
                    arr_even.Add(arr0711[a]);
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

        }
    }
}
