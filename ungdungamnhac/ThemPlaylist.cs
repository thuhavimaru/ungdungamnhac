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
    public partial class ThemPlaylist : Form
    {
        public ThemPlaylist()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhatNhac f=new PhatNhac();
            f.Show();

        }
    }
}
