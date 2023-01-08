using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang.Help
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        //1
        private void hideSubMenu()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }

        private void ch1_Click(object sender, EventArgs e)
        {
            showSubMenu(pnch1);
        }

        //2
        private void hideSubMenu2()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu2(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }

        private void ch2_Click(object sender, EventArgs e)
        {
            showSubMenu2(pnch2);
        }

        //3
        private void hideSubMenu3()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu3(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }

        private void ch3_Click(object sender, EventArgs e)
        {
            showSubMenu3(pnch3);
        }


        //4
        private void hideSubMenu4()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu4(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }


        private void ch4_Click(object sender, EventArgs e)
        {
            showSubMenu4(pnch4);
        }

        //5
        private void hideSubMenu5()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu5(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }

        private void ch5_Click(object sender, EventArgs e)
        {
            showSubMenu5(pnch5);
        }

        private void Help_Load(object sender, EventArgs e)
        {
            pnch1.Visible = false;
            pnch2.Visible = false;
            pnch3.Visible = false;
            pnch4.Visible = false;
            pnch5.Visible = false;
            pnch6.Visible = false;
        }

        //6
        private void hideSubMenu6()
        {
            if (pnch1.Visible == true)
                pnch1.Visible = false;
        }

        private void showSubMenu6(Panel tl)
        {
            if (tl.Visible == false)
            {
                hideSubMenu();
                tl.Visible = true;
            }
            else
                tl.Visible = false;
        }

        private void ch6_Click(object sender, EventArgs e)
        {
            showSubMenu6(pnch6);
        }
    }
}
