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


//contextMenuStrip上面抓一格，下面抓二格

namespace pos_food
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //1.下為點擊hello按鈕，呼叫視窗
        private void button1_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            hello son = new hello();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //hello son = new hello();
            //AddNewForm(son);
        }

        //2.下為點擊loan按鈕，呼叫視窗
        private void loan_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            loan son = new loan();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //loan son = new loan();
            //AddNewForm(son);
        }

        //3.下為點擊pos按鈕，呼叫視窗
        private void pos_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            pos son = new pos();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //pos son = new pos();
            //AddNewForm(son);
        }

        //4.下為點擊student_struct按鈕，呼叫視窗
        private void student_struct_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            student_struct son = new student_struct();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //student_struct son = new student_struct();
            //AddNewForm(son);
        }

        //5.下為點擊student_grade按鈕，呼叫視窗
        private void students_grade_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            students_grade son = new students_grade();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //students_grade son = new students_grade();
            //AddNewForm(son);
        }

        //7.下為點擊method按鈕，呼叫視窗
        private void method_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            method son = new method();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //method son = new method();
            //AddNewForm(son);
        }

        //8.下為點擊myclac按鈕，呼叫視窗
        private void myclac_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            myclac son = new myclac();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //myclac son = new myclac();
            //AddNewForm(son);
        }

        //9.下為點擊fordowhile按鈕，呼叫視窗
        private void fordowhile_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            fordowhile son = new fordowhile();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();

            //fordowhile son = new fordowhile();
            //AddNewForm(son);
        }

        //10.下為點擊xogame按鈕，呼叫視窗
        private void xogame_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            xogame son = new xogame();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //11.為點擊screensaver按紐，進入螢幕保護程式
        private void screensaver_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            screensaver son = new screensaver();
            //son.TopLevel = false;
            //right_panel.Controls.Add(son);
            son.Show();
        }

        //12.下為點擊notepad按鈕，呼叫視窗
        private void notepad_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            notepad son = new notepad();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //13.下為點擊junior_painter按鈕，呼叫視窗
        private void junior_painter_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            junior_painter son = new junior_painter();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //14.下為點擊pictureviewer按鈕，呼叫視窗
        private void pictureviewer_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            pictureviewer2 son = new pictureviewer2();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //15.下為點擊guess_number按鈕，呼叫視窗
        private void guess_number_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            guess_number son = new guess_number();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //16.下為點擊alarm_number按鈕，呼叫視窗
        private void alarm_button_Click(object sender, EventArgs e)
        {
            right_panel.Controls.Clear();
            alarm son = new alarm();
            son.TopLevel = false;
            right_panel.Controls.Add(son);
            son.Show();
        }

        //方法二 留著備用
        public void AddNewForm(Form form)
        {
            foreach (Control item in right_panel.Controls)
            {
                item.Dispose();
            }

            form.TopLevel = false;

            form.FormBorderStyle = FormBorderStyle.None;

            form.Dock = DockStyle.Fill;
            Panel son = new Panel();
            son.Dock = DockStyle.Fill;
            son.Controls.Clear();
            son.Controls.Add(form);
            right_panel.Controls.Clear();
            right_panel.Controls.Add(son);
            form.Show();
        }


    }
}
