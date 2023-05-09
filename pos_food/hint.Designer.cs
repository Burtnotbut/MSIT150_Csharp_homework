namespace pos_food
{
    partial class hint
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
            this.enter_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.guess_value_textBox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enter_button.Location = new System.Drawing.Point(224, 7);
            this.enter_button.Margin = new System.Windows.Forms.Padding(2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(68, 28);
            this.enter_button.TabIndex = 14;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancel_button.Location = new System.Drawing.Point(224, 49);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(68, 28);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // guess_value_textBox
            // 
            this.guess_value_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.guess_value_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guess_value_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.guess_value_textBox.Location = new System.Drawing.Point(26, 96);
            this.guess_value_textBox.Name = "guess_value_textBox";
            this.guess_value_textBox.Size = new System.Drawing.Size(219, 32);
            this.guess_value_textBox.TabIndex = 16;
            this.guess_value_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(8, 35);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(206, 28);
            this.title_label.TabIndex = 17;
            this.title_label.Text = "Please input a number.";
            // 
            // hint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(306, 133);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.guess_value_textBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.enter_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hint";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox guess_value_textBox;
        private System.Windows.Forms.Label title_label;
    }
}