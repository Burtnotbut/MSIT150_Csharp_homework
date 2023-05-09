namespace pos_food
{
    partial class alarm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.set_checkBox = new System.Windows.Forms.CheckBox();
            this.subject_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.hour_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minute_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.second_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hour_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_label.Location = new System.Drawing.Point(43, 34);
            this.time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(395, 51);
            this.time_label.TabIndex = 10;
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.second_numericUpDown);
            this.groupBox1.Controls.Add(this.minute_numericUpDown);
            this.groupBox1.Controls.Add(this.hour_numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.set_checkBox);
            this.groupBox1.Controls.Add(this.subject_label);
            this.groupBox1.Controls.Add(this.title_label);
            this.groupBox1.Location = new System.Drawing.Point(29, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(505, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 48);
            this.label3.TabIndex = 30;
            this.label3.Text = "秒";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(368, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 48);
            this.label2.TabIndex = 28;
            this.label2.Text = "分";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(231, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 48);
            this.label1.TabIndex = 26;
            this.label1.Text = "時";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // set_checkBox
            // 
            this.set_checkBox.AutoSize = true;
            this.set_checkBox.Location = new System.Drawing.Point(226, 200);
            this.set_checkBox.Name = "set_checkBox";
            this.set_checkBox.Size = new System.Drawing.Size(87, 19);
            this.set_checkBox.TabIndex = 24;
            this.set_checkBox.Text = "Set Alarm";
            this.set_checkBox.UseVisualStyleBackColor = true;
            // 
            // subject_label
            // 
            this.subject_label.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subject_label.Location = new System.Drawing.Point(7, 91);
            this.subject_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(133, 72);
            this.subject_label.TabIndex = 2;
            this.subject_label.Text = "Alarm Time :";
            this.subject_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(165, 12);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(184, 36);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Alarm Time";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_numericUpDown
            // 
            this.hour_numericUpDown.AutoSize = true;
            this.hour_numericUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.hour_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hour_numericUpDown.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hour_numericUpDown.Location = new System.Drawing.Point(169, 115);
            this.hour_numericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hour_numericUpDown.Name = "hour_numericUpDown";
            this.hour_numericUpDown.Size = new System.Drawing.Size(53, 27);
            this.hour_numericUpDown.TabIndex = 31;
            this.hour_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minute_numericUpDown
            // 
            this.minute_numericUpDown.AutoSize = true;
            this.minute_numericUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.minute_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minute_numericUpDown.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.minute_numericUpDown.Location = new System.Drawing.Point(306, 115);
            this.minute_numericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minute_numericUpDown.Name = "minute_numericUpDown";
            this.minute_numericUpDown.Size = new System.Drawing.Size(53, 27);
            this.minute_numericUpDown.TabIndex = 32;
            this.minute_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // second_numericUpDown
            // 
            this.second_numericUpDown.AutoSize = true;
            this.second_numericUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.second_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.second_numericUpDown.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.second_numericUpDown.Location = new System.Drawing.Point(443, 115);
            this.second_numericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.second_numericUpDown.Name = "second_numericUpDown";
            this.second_numericUpDown.Size = new System.Drawing.Size(53, 27);
            this.second_numericUpDown.TabIndex = 33;
            this.second_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(689, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.time_label);
            this.Name = "alarm";
            this.Text = "alarm";
            this.Load += new System.EventHandler(this.alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hour_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.CheckBox set_checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hour_numericUpDown;
        private System.Windows.Forms.NumericUpDown second_numericUpDown;
        private System.Windows.Forms.NumericUpDown minute_numericUpDown;
    }
}