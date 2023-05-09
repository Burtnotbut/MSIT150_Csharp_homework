namespace pos_food
{
    partial class junior_painter
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
            this.color_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.color_textBox = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // color_button
            // 
            this.color_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_button.BackColor = System.Drawing.Color.White;
            this.color_button.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color_button.Location = new System.Drawing.Point(693, 61);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(105, 60);
            this.color_button.TabIndex = 0;
            this.color_button.Text = "顏色";
            this.color_button.UseVisualStyleBackColor = false;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(742, 252);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 183);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // color_textBox
            // 
            this.color_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_textBox.BackColor = System.Drawing.Color.Black;
            this.color_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.color_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.color_textBox.Enabled = false;
            this.color_textBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color_textBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.color_textBox.Location = new System.Drawing.Point(693, 140);
            this.color_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.color_textBox.MaxLength = 0;
            this.color_textBox.Multiline = true;
            this.color_textBox.Name = "color_textBox";
            this.color_textBox.Size = new System.Drawing.Size(105, 59);
            this.color_textBox.TabIndex = 26;
            // 
            // value_label
            // 
            this.value_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.value_label.AutoSize = true;
            this.value_label.BackColor = System.Drawing.Color.White;
            this.value_label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.value_label.Location = new System.Drawing.Point(730, 458);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(0, 29);
            this.value_label.TabIndex = 27;
            // 
            // junior_painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 586);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.color_textBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.color_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "junior_painter";
            this.Text = "junior_painter";
            this.Load += new System.EventHandler(this.junior_painter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox color_textBox;
        private System.Windows.Forms.Label value_label;
    }
}