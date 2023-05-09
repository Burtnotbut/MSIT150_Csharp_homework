namespace pos_food
{
    partial class loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.money_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.interest_label = new System.Windows.Forms.Label();
            this.first_cash_label = new System.Windows.Forms.Label();
            this.money_textBox = new System.Windows.Forms.TextBox();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.interest_textBox = new System.Windows.Forms.TextBox();
            this.first_cash_textBox = new System.Windows.Forms.TextBox();
            this.mon_pay_button = new System.Windows.Forms.Button();
            this.total_amount_button = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // money_label
            // 
            this.money_label.AutoSize = true;
            this.money_label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money_label.Location = new System.Drawing.Point(108, 66);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(105, 29);
            this.money_label.TabIndex = 0;
            this.money_label.Text = "貸款金額";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_label.Location = new System.Drawing.Point(108, 123);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(96, 29);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "期限(年)";
            // 
            // interest_label
            // 
            this.interest_label.AutoSize = true;
            this.interest_label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.interest_label.Location = new System.Drawing.Point(108, 185);
            this.interest_label.Name = "interest_label";
            this.interest_label.Size = new System.Drawing.Size(93, 29);
            this.interest_label.TabIndex = 2;
            this.interest_label.Text = "利率(%)";
            // 
            // first_cash_label
            // 
            this.first_cash_label.AutoSize = true;
            this.first_cash_label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.first_cash_label.Location = new System.Drawing.Point(108, 257);
            this.first_cash_label.Name = "first_cash_label";
            this.first_cash_label.Size = new System.Drawing.Size(82, 29);
            this.first_cash_label.TabIndex = 3;
            this.first_cash_label.Text = "頭期款";
            // 
            // money_textBox
            // 
            this.money_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money_textBox.Location = new System.Drawing.Point(310, 66);
            this.money_textBox.Name = "money_textBox";
            this.money_textBox.Size = new System.Drawing.Size(161, 38);
            this.money_textBox.TabIndex = 4;
            this.money_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // time_textBox
            // 
            this.time_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_textBox.Location = new System.Drawing.Point(310, 120);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(161, 38);
            this.time_textBox.TabIndex = 5;
            this.time_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // interest_textBox
            // 
            this.interest_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.interest_textBox.Location = new System.Drawing.Point(310, 185);
            this.interest_textBox.Name = "interest_textBox";
            this.interest_textBox.Size = new System.Drawing.Size(161, 38);
            this.interest_textBox.TabIndex = 6;
            this.interest_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // first_cash_textBox
            // 
            this.first_cash_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.first_cash_textBox.Location = new System.Drawing.Point(310, 257);
            this.first_cash_textBox.Name = "first_cash_textBox";
            this.first_cash_textBox.Size = new System.Drawing.Size(161, 38);
            this.first_cash_textBox.TabIndex = 7;
            this.first_cash_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mon_pay_button
            // 
            this.mon_pay_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mon_pay_button.Location = new System.Drawing.Point(122, 358);
            this.mon_pay_button.Name = "mon_pay_button";
            this.mon_pay_button.Size = new System.Drawing.Size(163, 57);
            this.mon_pay_button.TabIndex = 8;
            this.mon_pay_button.Text = "PMT(月付額)";
            this.mon_pay_button.UseVisualStyleBackColor = true;
            this.mon_pay_button.Click += new System.EventHandler(this.mon_pay_button_Click);
            // 
            // total_amount_button
            // 
            this.total_amount_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.total_amount_button.Location = new System.Drawing.Point(310, 358);
            this.total_amount_button.Name = "total_amount_button";
            this.total_amount_button.Size = new System.Drawing.Size(163, 57);
            this.total_amount_button.TabIndex = 9;
            this.total_amount_button.Text = "總付款";
            this.total_amount_button.UseVisualStyleBackColor = true;
            this.total_amount_button.Click += new System.EventHandler(this.total_amount_button_Click);
            // 
            // report_button
            // 
            this.report_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.report_button.Location = new System.Drawing.Point(603, 358);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(163, 57);
            this.report_button.TabIndex = 10;
            this.report_button.Text = "Report";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.total_amount_button);
            this.Controls.Add(this.mon_pay_button);
            this.Controls.Add(this.first_cash_textBox);
            this.Controls.Add(this.interest_textBox);
            this.Controls.Add(this.time_textBox);
            this.Controls.Add(this.money_textBox);
            this.Controls.Add(this.first_cash_label);
            this.Controls.Add(this.interest_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.money_label);
            this.Name = "loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label interest_label;
        private System.Windows.Forms.Label first_cash_label;
        private System.Windows.Forms.TextBox money_textBox;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.TextBox interest_textBox;
        private System.Windows.Forms.TextBox first_cash_textBox;
        private System.Windows.Forms.Button mon_pay_button;
        private System.Windows.Forms.Button total_amount_button;
        private System.Windows.Forms.Button report_button;
    }
}