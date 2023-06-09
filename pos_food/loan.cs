﻿using Docker.DotNet.Models;
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
    internal partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        double money;//貸款金額
        double time; // 期限(年)
        double interest; //利率(%)
        double first_cash; //頭期款

        double total_amount; // 總共付款金額
        double month_pay;// 每月付款的金額

        internal void mon_pay_button_Click(object sender, EventArgs e)
        {
            calculate_pay();
            MessageBox.Show("月付額: " + month_pay +"元");
        }

        private void total_amount_button_Click(object sender, EventArgs e)
        {
            calculate_pay();
            MessageBox.Show("總付款: " + total_amount + "元");
        }

        internal void calculate_pay() // 計算月付額
        {
            money = Convert.ToDouble(money_textBox.Text);  //貸款金額
            time = Convert.ToDouble(time_textBox.Text); // 期限(年)
            interest = Convert.ToDouble(interest_textBox.Text); //利率(%)
            //first_cash = Convert.ToDouble(first_cash_textBox.Text); //頭期款



            month_pay = Convert.ToInt32((Math.Pow(1 + interest / 1200, time * 12) * ( interest / 1200 ) ) / 
               ( Math.Pow( 1 + interest / 1200 , time * 12 ) - 1 ) * 100000);

            total_amount = month_pay * 12 * time;
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            loan_report report = new loan_report();
            report.SetTextBox(money_textBox.Text, time_textBox.Text, interest_textBox.Text, month_pay, total_amount);
            report.Show();
        }
    }
}
