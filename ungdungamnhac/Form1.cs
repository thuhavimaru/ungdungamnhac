using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ungdungamnhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50); // Đặt kích thước của hình ảnh trong ImageList
            button1.ImageList = imageList;
            button1.ImageIndex = 0; // Chọn hình ảnh từ ImageList

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void nhacremix_click(object sender, EventArgs e)
        {

        }

        private void nhacbuon_click(object sender, EventArgs e)
        {

        }

        private void nhacthugian_click(object sender, EventArgs e)
        {

        }

        private void sky_click(object sender, EventArgs e)
        {

        }

        private void chill_click(object sender, EventArgs e)
        {

        }

        private void phatnhac_click(object sender, EventArgs e)
        {

        }

        private void nhacngheganday_click(object sender, EventArgs e)
        {

        }

        private void thuvien_click(object sender, EventArgs e)
        {

        }
    }
}
