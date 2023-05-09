namespace pos_food
{
    partial class guess_number
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
            this.title_label = new System.Windows.Forms.Label();
            this.guess_button = new System.Windows.Forms.Button();
            this.show_ans_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(43, 29);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(588, 81);
            this.title_label.TabIndex = 10;
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guess_button
            // 
            this.guess_button.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guess_button.Location = new System.Drawing.Point(164, 295);
            this.guess_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guess_button.Name = "guess_button";
            this.guess_button.Size = new System.Drawing.Size(139, 49);
            this.guess_button.TabIndex = 12;
            this.guess_button.Text = "Guess";
            this.guess_button.UseVisualStyleBackColor = true;
            this.guess_button.Click += new System.EventHandler(this.guess_button_Click);
            // 
            // show_ans_button
            // 
            this.show_ans_button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.show_ans_button.Location = new System.Drawing.Point(341, 295);
            this.show_ans_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_ans_button.Name = "show_ans_button";
            this.show_ans_button.Size = new System.Drawing.Size(139, 49);
            this.show_ans_button.TabIndex = 13;
            this.show_ans_button.Text = "Show Answer";
            this.show_ans_button.UseVisualStyleBackColor = true;
            this.show_ans_button.Click += new System.EventHandler(this.show_ans_button_Click);
            // 
            // guess_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(647, 362);
            this.Controls.Add(this.show_ans_button);
            this.Controls.Add(this.guess_button);
            this.Controls.Add(this.title_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "guess_number";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.guess_number_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button guess_button;
        private System.Windows.Forms.Button show_ans_button;
    }
}