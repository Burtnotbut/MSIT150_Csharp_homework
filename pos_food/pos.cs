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
    public partial class pos : Form
    {
        String name; // 品名
        double price; // 單價
        double number; // 數量
        double subTotal; // 小計

        int ham_num = 0;
        int piz_num = 0;
        int chi_num = 0;
        int bee_num = 0;
        public pos()
        {
            InitializeComponent();
            Text = "收銀機";

        }

        /*4項產品的按鈕*/
        private void hamburger_Click(object sender, EventArgs e)
        {
            ham_num = ham_num + 1;
            calculateSubTotal();
            this.order_textBox.Text += "漢堡 * 1 , 共" + subTotal + "元\r\n";
        }

        private void pizza_Click(object sender, EventArgs e)
        {
            piz_num = piz_num + 1;
            calculateSubTotal();
            this.order_textBox.Text += "披薩 * 1 , 共" + subTotal + "元\r\n";
        }

        private void chicken_Click(object sender, EventArgs e)
        {
            chi_num = chi_num + 1;
            calculateSubTotal();
            this.order_textBox.Text += "烤雞 * 1 , 共" + subTotal + "元\r\n";
        }

        private void beer_Click(object sender, EventArgs e)
        {
            bee_num = bee_num + 1;
            calculateSubTotal();
            this.order_textBox.Text += "啤酒 * 1 , 共" + subTotal + "元\r\n";
        }

        /*計算總價的方式*/
        private void calculateSubTotal() // 計算小計
        {
            subTotal = ham_num * 150 + piz_num * 200 + chi_num * 300 + bee_num * 100;          
            textBoxSubtotal.Text = subTotal.ToString();

            /*
            price = double.Parse(textBoxPrice.Text);
            number = (double)numericUpDownNumber.Value;
            subTotal = price * number; // 小計 = 價格 * 數量
           
            */
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.order_textBox.Clear();
            ham_num = 0;
            piz_num = 0;
            chi_num = 0;
            bee_num = 0;
            subTotal = 0;
            textBoxSubtotal.Text = subTotal.ToString();
        }

        private void cash_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: " + subTotal , "確認付款" );
        }

        private void credit_button_Click(object sender, EventArgs e)
        {
            subTotal = subTotal * 0.9;
            MessageBox.Show("總金額: " + subTotal, "確認付款");
        }
    }
}
