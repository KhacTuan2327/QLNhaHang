using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNhaHang.Data;
/*using QLNhaHang.Statistical;
using QLNhaHang.Warehouse;
using QLNhaHang.Introduce;
using QLNhaHang.Food;*/
namespace QLNhaHang
{
    public partial class MainForm : Form
    {
        int newLocationX;
        int newLocationY;
        public int permission;
        //1: quản lý nhà hàng
        //2: nhân viên quản lý kho
        //3: đối tượng còn lại
        public MainForm()
        {
            InitializeComponent();
            sidePanel.Height = guna2GradientTileBtnHome.Height;  // sidePanel la thanh truot ben nut menu
            sidePanel.Top = guna2GradientTileBtnHome.Top;
            MainPage.BringToFront();  //mainpage
            // hien thong tin user 
            lbName.Text = Login.name;
            lbPosition.Text = Login.position;
        }
    }
}
