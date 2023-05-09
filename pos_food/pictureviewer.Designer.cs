namespace pos_food
{
    partial class pictureviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pictureviewer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dog.jpg");
            this.imageList1.Images.SetKeyName(1, "1657077940743.jpg");
            this.imageList1.Images.SetKeyName(2, "1645849041094.jpg");
            this.imageList1.Images.SetKeyName(3, "1653667425320.jpg");
            this.imageList1.Images.SetKeyName(4, "下載.jpg");
            this.imageList1.Images.SetKeyName(5, "EGdWXHYU4AEeD74 (1).jpg");
            this.imageList1.Images.SetKeyName(6, "8304898.jpg");
            this.imageList1.Images.SetKeyName(7, "企鵝.jpg");
            this.imageList1.Images.SetKeyName(8, "沙漠.jpg");
            this.imageList1.Images.SetKeyName(9, "無尾熊.jpg");
            this.imageList1.Images.SetKeyName(10, "菊花.jpg");
            this.imageList1.Images.SetKeyName(11, "鬱金香.jpg");
            this.imageList1.Images.SetKeyName(12, "10fe7f6eae7c8b46fd5e2215c74e85e9.gif");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(808, 490);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // pictureviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 490);
            this.Controls.Add(this.listView1);
            this.Name = "pictureviewer";
            this.Text = "pictureviewer";
            this.Load += new System.EventHandler(this.pictureviewer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}