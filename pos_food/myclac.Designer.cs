namespace pos_food
{
    partial class myclac
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
            this.num1_label = new System.Windows.Forms.Label();
            this.num2_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.sub_button = new System.Windows.Forms.Button();
            this.mul_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.num1_textBox = new System.Windows.Forms.TextBox();
            this.num2_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1_label
            // 
            this.num1_label.AutoSize = true;
            this.num1_label.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num1_label.Location = new System.Drawing.Point(92, 103);
            this.num1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num1_label.Name = "num1_label";
            this.num1_label.Size = new System.Drawing.Size(123, 42);
            this.num1_label.TabIndex = 0;
            this.num1_label.Text = "Num1:";
            // 
            // num2_label
            // 
            this.num2_label.AutoSize = true;
            this.num2_label.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num2_label.Location = new System.Drawing.Point(92, 253);
            this.num2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num2_label.Name = "num2_label";
            this.num2_label.Size = new System.Drawing.Size(123, 42);
            this.num2_label.TabIndex = 1;
            this.num2_label.Text = "Num2:";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_button.Location = new System.Drawing.Point(600, 91);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(84, 38);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // sub_button
            // 
            this.sub_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_button.Location = new System.Drawing.Point(600, 184);
            this.sub_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sub_button.Name = "sub_button";
            this.sub_button.Size = new System.Drawing.Size(84, 38);
            this.sub_button.TabIndex = 3;
            this.sub_button.Text = "-";
            this.sub_button.UseVisualStyleBackColor = true;
            this.sub_button.Click += new System.EventHandler(this.sub_button_Click);
            // 
            // mul_button
            // 
            this.mul_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mul_button.Location = new System.Drawing.Point(600, 277);
            this.mul_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mul_button.Name = "mul_button";
            this.mul_button.Size = new System.Drawing.Size(84, 38);
            this.mul_button.TabIndex = 4;
            this.mul_button.Text = "*";
            this.mul_button.UseVisualStyleBackColor = true;
            this.mul_button.Click += new System.EventHandler(this.mul_button_Click);
            // 
            // div_button
            // 
            this.div_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.div_button.Location = new System.Drawing.Point(600, 364);
            this.div_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(84, 38);
            this.div_button.TabIndex = 5;
            this.div_button.Text = "/";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answer_label.Location = new System.Drawing.Point(92, 436);
            this.answer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(149, 42);
            this.answer_label.TabIndex = 6;
            this.answer_label.Text = "Answer: ";
            // 
            // answer_textBox
            // 
            this.answer_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.answer_textBox.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answer_textBox.Location = new System.Drawing.Point(276, 436);
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.Size = new System.Drawing.Size(240, 51);
            this.answer_textBox.TabIndex = 7;
            this.answer_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num1_textBox
            // 
            this.num1_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.num1_textBox.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num1_textBox.Location = new System.Drawing.Point(276, 100);
            this.num1_textBox.Name = "num1_textBox";
            this.num1_textBox.Size = new System.Drawing.Size(240, 51);
            this.num1_textBox.TabIndex = 8;
            this.num1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2_textBox
            // 
            this.num2_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.num2_textBox.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num2_textBox.Location = new System.Drawing.Point(276, 256);
            this.num2_textBox.Name = "num2_textBox";
            this.num2_textBox.Size = new System.Drawing.Size(240, 51);
            this.num2_textBox.TabIndex = 9;
            this.num2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myclac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 589);
            this.Controls.Add(this.num2_textBox);
            this.Controls.Add(this.num1_textBox);
            this.Controls.Add(this.answer_textBox);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.div_button);
            this.Controls.Add(this.mul_button);
            this.Controls.Add(this.sub_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.num2_label);
            this.Controls.Add(this.num1_label);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "myclac";
            this.Text = "myclac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1_label;
        private System.Windows.Forms.Label num2_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button sub_button;
        private System.Windows.Forms.Button mul_button;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.TextBox num1_textBox;
        private System.Windows.Forms.TextBox num2_textBox;
    }
}