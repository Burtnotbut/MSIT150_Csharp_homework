using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pos_food
{
    public partial class pictureviewer : Form
    {
        public pictureviewer()
        {
            InitializeComponent();
        }

        List<string> fileNames = new List<string>();

        private void listViewFile_ItemActivate(object sender, EventArgs e)
        {
            //if (listViewFile.FocusedItem != null)
            //{
            //    using (pictureviewer3 frm = new pictureviewer3())
            //    {
            //        Image img = Image.FromFile(fileNames[listViewFile.FocusedItem.Index]);
            //        frm.ImageBox = img;
            //        frm.ShowDialog();
            //    }
            //}
        }

        private void pictureviewer_Load(object sender, EventArgs e)
        {

            //listView1.LargeImageList = imageList1;
            //imageList1.ImageSize = new Size(37, 36);
            //listView1.Items[0].ImageIndex = 0;
            //listView1.Items[1].ImageIndex = 1;
            //listView1.Items[2].ImageIndex = 2;
            //listView1.Items[3].ImageIndex = 3;
            //listView1.Items[4].ImageIndex = 4;
            //listView1.Items[5].ImageIndex = 5;

            //listView11.columns.Add：imageList1.Images[i];


            //this.listView1.Image = this.imageList1.Images[0];

            //ImageList.Images.Add：加入图像

            //foreach (int  i in fileNames)
            //{
            //    listView1.Image = imageList1.Images[i];

            //}
            //foreach (string fileName in imageList1.Images)
            //{
            //    FileInfo fi = new FileInfo(fileName);
            //    fileNames.Add(fi.FullName);
            //    listViewFile.Items.Add(fi.Name, 0);
            //}
        }
    }
}
