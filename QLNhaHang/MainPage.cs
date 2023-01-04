using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang
{
    public partial class MainPage : UserControl
    {
        public int hienthi = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            hienthi = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthi = 1;
        }
    }
}
