namespace pos_food
{
    partial class fordowhile
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
            this.label1 = new System.Windows.Forms.Label();
            this.clean_button = new System.Windows.Forms.Button();
            this.odd_even_button = new System.Windows.Forms.Button();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.ninenine_button = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.question3_button = new System.Windows.Forms.Button();
            this.question2_button = new System.Windows.Forms.Button();
            this.question1_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "Result:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clean_button
            // 
            this.clean_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clean_button.Location = new System.Drawing.Point(191, 264);
            this.clean_button.Margin = new System.Windows.Forms.Padding(4);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(132, 44);
            this.clean_button.TabIndex = 23;
            this.clean_button.Text = "清空結果欄";
            this.clean_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // odd_even_button
            // 
            this.odd_even_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.odd_even_button.Location = new System.Drawing.Point(42, 117);
            this.odd_even_button.Margin = new System.Windows.Forms.Padding(4);
            this.odd_even_button.Name = "odd_even_button";
            this.odd_even_button.Size = new System.Drawing.Size(255, 44);
            this.odd_even_button.TabIndex = 22;
            this.odd_even_button.Text = "輸入的數為奇數或偶數?";
            this.odd_even_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odd_even_button.UseVisualStyleBackColor = true;
            this.odd_even_button.Click += new System.EventHandler(this.odd_even_button_Click);
            // 
            // number_textBox
            // 
            this.number_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number_textBox.Location = new System.Drawing.Point(134, 36);
            this.number_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(132, 38);
            this.number_textBox.TabIndex = 21;
            this.number_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // number_label
            // 
            this.number_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number_label.Location = new System.Drawing.Point(13, 36);
            this.number_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(113, 51);
            this.number_label.TabIndex = 20;
            this.number_label.Text = "Number:";
            this.number_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ninenine_button
            // 
            this.ninenine_button.BackColor = System.Drawing.SystemColors.Info;
            this.ninenine_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ninenine_button.Location = new System.Drawing.Point(780, 246);
            this.ninenine_button.Margin = new System.Windows.Forms.Padding(4);
            this.ninenine_button.Name = "ninenine_button";
            this.ninenine_button.Size = new System.Drawing.Size(136, 44);
            this.ninenine_button.TabIndex = 26;
            this.ninenine_button.Text = "九九乘法表";
            this.ninenine_button.UseVisualStyleBackColor = false;
            this.ninenine_button.Click += new System.EventHandler(this.ninenine_button_Click);
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.BackColor = System.Drawing.SystemColors.Info;
            this.answer_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answer_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.answer_label.Location = new System.Drawing.Point(13, 343);
            this.answer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(61, 30);
            this.answer_label.TabIndex = 42;
            this.answer_label.Text = "結果";
            this.answer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question3_button
            // 
            this.question3_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.question3_button.Location = new System.Drawing.Point(318, 133);
            this.question3_button.Margin = new System.Windows.Forms.Padding(4);
            this.question3_button.Name = "question3_button";
            this.question3_button.Size = new System.Drawing.Size(275, 44);
            this.question3_button.TabIndex = 48;
            this.question3_button.Text = "陣列arr0711Str[]最長的名字";
            this.question3_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.question3_button.UseVisualStyleBackColor = true;
            this.question3_button.Click += new System.EventHandler(this.question3_button_Click);
            // 
            // question2_button
            // 
            this.question2_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.question2_button.Location = new System.Drawing.Point(43, 190);
            this.question2_button.Margin = new System.Windows.Forms.Padding(4);
            this.question2_button.Name = "question2_button";
            this.question2_button.Size = new System.Drawing.Size(255, 44);
            this.question2_button.TabIndex = 47;
            this.question2_button.Text = "陣列arr0711[]最大/小值";
            this.question2_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.question2_button.UseVisualStyleBackColor = true;
            this.question2_button.Click += new System.EventHandler(this.question2_button_Click);
            // 
            // question1_button
            // 
            this.question1_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.question1_button.Location = new System.Drawing.Point(318, 37);
            this.question1_button.Margin = new System.Windows.Forms.Padding(4);
            this.question1_button.Name = "question1_button";
            this.question1_button.Size = new System.Drawing.Size(275, 44);
            this.question1_button.TabIndex = 46;
            this.question1_button.Text = "陣列arr0711統計奇偶數";
            this.question1_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.question1_button.UseVisualStyleBackColor = true;
            this.question1_button.Click += new System.EventHandler(this.question1_button_Click);
            // 
            // fordowhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(939, 750);
            this.Controls.Add(this.question3_button);
            this.Controls.Add(this.question2_button);
            this.Controls.Add(this.question1_button);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.ninenine_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.odd_even_button);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.number_label);
            this.Name = "fordowhile";
            this.Text = "fordowhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button odd_even_button;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Button ninenine_button;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.Button question3_button;
        private System.Windows.Forms.Button question2_button;
        private System.Windows.Forms.Button question1_button;
    }
}