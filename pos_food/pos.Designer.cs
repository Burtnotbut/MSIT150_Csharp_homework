namespace pos_food
{
    partial class pos
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pos));
            this.menu_label = new System.Windows.Forms.Label();
            this.hamburger = new System.Windows.Forms.Button();
            this.pizza = new System.Windows.Forms.Button();
            this.chicken = new System.Windows.Forms.Button();
            this.beer = new System.Windows.Forms.Button();
            this.order_label = new System.Windows.Forms.Label();
            this.order_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.cash_button = new System.Windows.Forms.Button();
            this.credit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_label.Location = new System.Drawing.Point(43, 64);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(239, 307);
            this.menu_label.TabIndex = 0;
            this.menu_label.Text = "菜單 Menu";
            // 
            // hamburger
            // 
            this.hamburger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hamburger.BackgroundImage")));
            this.hamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hamburger.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hamburger.ForeColor = System.Drawing.Color.Teal;
            this.hamburger.Location = new System.Drawing.Point(62, 103);
            this.hamburger.Name = "hamburger";
            this.hamburger.Size = new System.Drawing.Size(80, 105);
            this.hamburger.TabIndex = 1;
            this.hamburger.Text = "漢堡 NT $150";
            this.hamburger.UseVisualStyleBackColor = true;
            this.hamburger.Click += new System.EventHandler(this.hamburger_Click);
            // 
            // pizza
            // 
            this.pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pizza.BackgroundImage")));
            this.pizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pizza.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pizza.ForeColor = System.Drawing.Color.Teal;
            this.pizza.Location = new System.Drawing.Point(175, 103);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(80, 105);
            this.pizza.TabIndex = 2;
            this.pizza.Text = "披薩 NT $200";
            this.pizza.UseVisualStyleBackColor = true;
            this.pizza.Click += new System.EventHandler(this.pizza_Click);
            // 
            // chicken
            // 
            this.chicken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chicken.BackgroundImage")));
            this.chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chicken.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chicken.ForeColor = System.Drawing.Color.Teal;
            this.chicken.Location = new System.Drawing.Point(62, 238);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(80, 105);
            this.chicken.TabIndex = 3;
            this.chicken.Text = "烤雞 NT $300";
            this.chicken.UseVisualStyleBackColor = true;
            this.chicken.Click += new System.EventHandler(this.chicken_Click);
            // 
            // beer
            // 
            this.beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beer.BackgroundImage")));
            this.beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beer.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beer.ForeColor = System.Drawing.Color.Teal;
            this.beer.Location = new System.Drawing.Point(175, 238);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(80, 105);
            this.beer.TabIndex = 4;
            this.beer.Text = "啤酒 NT $100";
            this.beer.UseVisualStyleBackColor = true;
            this.beer.Click += new System.EventHandler(this.beer_Click);
            // 
            // order_label
            // 
            this.order_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_label.Location = new System.Drawing.Point(519, 64);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(239, 307);
            this.order_label.TabIndex = 5;
            this.order_label.Text = "訂餐資訊 Order";
            // 
            // order_textBox
            // 
            this.order_textBox.Location = new System.Drawing.Point(536, 94);
            this.order_textBox.Multiline = true;
            this.order_textBox.Name = "order_textBox";
            this.order_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.order_textBox.Size = new System.Drawing.Size(206, 207);
            this.order_textBox.TabIndex = 6;
            this.order_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(288, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "總金額 Total Price";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxSubtotal.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSubtotal.Location = new System.Drawing.Point(305, 103);
            this.textBoxSubtotal.Multiline = true;
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(177, 42);
            this.textBoxSubtotal.TabIndex = 8;
            this.textBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSubtotal.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(294, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 191);
            this.label2.TabIndex = 9;
            this.label2.Text = "付款方式";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(625, 324);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(104, 37);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "清除清單";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // cash_button
            // 
            this.cash_button.Location = new System.Drawing.Point(345, 216);
            this.cash_button.Name = "cash_button";
            this.cash_button.Size = new System.Drawing.Size(104, 37);
            this.cash_button.TabIndex = 11;
            this.cash_button.Text = "現金";
            this.cash_button.UseVisualStyleBackColor = true;
            this.cash_button.Click += new System.EventHandler(this.cash_button_Click);
            // 
            // credit_button
            // 
            this.credit_button.Location = new System.Drawing.Point(345, 264);
            this.credit_button.Name = "credit_button";
            this.credit_button.Size = new System.Drawing.Size(104, 37);
            this.credit_button.TabIndex = 12;
            this.credit_button.Text = "信用卡";
            this.credit_button.UseVisualStyleBackColor = true;
            this.credit_button.Click += new System.EventHandler(this.credit_button_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(360, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 43);
            this.label3.TabIndex = 13;
            this.label3.Text = "信用卡享9折!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.credit_button);
            this.Controls.Add(this.cash_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_textBox);
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.hamburger);
            this.Controls.Add(this.menu_label);
            this.Name = "pos";
            this.Text = "pos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button hamburger;
        private System.Windows.Forms.Button pizza;
        private System.Windows.Forms.Button chicken;
        private System.Windows.Forms.Button beer;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.TextBox order_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button cash_button;
        private System.Windows.Forms.Button credit_button;
        private System.Windows.Forms.Label label3;
    }
}

