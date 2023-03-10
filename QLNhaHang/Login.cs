using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QLNhaHang.Data;

namespace QLNhaHang
{
    public partial class Login : Form
    {
        SqlConnection sqlCon = new SqlConnection(Data_Provider.connectionSTR);
        DataTable dtbl;

        public static string position;
        public static string name;
        public static string manv;
        public static int permission;
        public Login()
        {
            InitializeComponent();
            textPass.UseSystemPasswordChar = false;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnLogin, "Đăng nhập vào chương trình");
            toolTip1.SetToolTip(picPassword, "Hiển thị mật khẩu");
            toolTip1.SetToolTip(btCustomers, "Sử dụng với tư cách là khách hàng");
            toolTip1.SetToolTip(btnForgetPassword, "Quên mật khẩu");
        }
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            NewPass f = new NewPass();
            f.Show();
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm cusForm = new CustomerForm();
            this.Hide();
            cusForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textPass.UseSystemPasswordChar = true;
        }

        private void picPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textPass.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string query = "Select * from NHANVIEN where matkhau= '" + ComputeSha256Hash(textPass.Text) + "' and manv= N'" + textUser.Text + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);

            // Create a DataSet.
            dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            if (dtbl.Rows.Count == 1)
            {
                manv = textPass.Text.Trim(); //////////
                foreach (DataRow dr in dtbl.Rows)
                {
                    name = dr["hoTen"].ToString();
                    position = dr["chucVu"].ToString();
                    if (position.Trim() == "Administrator")
                    {
                        permission = 1;
                    }
                    else if (position.Trim() == "WarehouseManager" || position.Trim() == "WarehouseStaff")
                    {
                        permission = 2;
                    }
                    else
                    {
                        permission = 3;
                    }
                }

                MainForm frm = new MainForm();
                frm.Show();
                frm.permission = permission;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your Username and Password!");
            }
        }
    }
}
