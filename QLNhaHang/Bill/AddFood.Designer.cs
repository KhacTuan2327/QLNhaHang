
namespace QLNhaHang.Food
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbb_Kind = new System.Windows.Forms.ComboBox();
            this.btn_image = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtID_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDish = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BtnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PnlAddFood = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2PnlAddFood.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(267, 139);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 168);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // cbb_Kind
            // 
            this.cbb_Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Kind.FormattingEnabled = true;
            this.cbb_Kind.Items.AddRange(new object[] {
            "Burger",
            "Pizza",
            "Nước"});
            this.cbb_Kind.Location = new System.Drawing.Point(93, 34);
            this.cbb_Kind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Kind.Name = "cbb_Kind";
            this.cbb_Kind.Size = new System.Drawing.Size(160, 30);
            this.cbb_Kind.TabIndex = 14;
            // 
            // btn_image
            // 
            this.btn_image.BorderThickness = 1;
            this.btn_image.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_image.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_image.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_image.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_image.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_image.FillColor = System.Drawing.Color.Gold;
            this.btn_image.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_image.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.ForeColor = System.Drawing.Color.Black;
            this.btn_image.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_image.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_image.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_image.Location = new System.Drawing.Point(95, 174);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(132, 36);
            this.btn_image.TabIndex = 13;
            this.btn_image.Text = "      Browser";
            // 
            // txtID_Add
            // 
            this.txtID_Add.BorderColor = System.Drawing.Color.Silver;
            this.txtID_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID_Add.DefaultText = "";
            this.txtID_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_Add.Location = new System.Drawing.Point(337, 34);
            this.txtID_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Add.Name = "txtID_Add";
            this.txtID_Add.PasswordChar = '\0';
            this.txtID_Add.PlaceholderText = "";
            this.txtID_Add.SelectedText = "";
            this.txtID_Add.Size = new System.Drawing.Size(153, 30);
            this.txtID_Add.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.BorderColor = System.Drawing.Color.Silver;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Maroon;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(93, 243);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(132, 29);
            this.txt_price.TabIndex = 11;
            // 
            // txtDish
            // 
            this.txtDish.BorderColor = System.Drawing.Color.Silver;
            this.txtDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDish.DefaultText = "";
            this.txtDish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDish.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDish.Location = new System.Drawing.Point(163, 90);
            this.txtDish.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDish.Name = "txtDish";
            this.txtDish.PasswordChar = '\0';
            this.txtDish.PlaceholderText = "";
            this.txtDish.SelectedText = "";
            this.txtDish.Size = new System.Drawing.Size(204, 31);
            this.txtDish.TabIndex = 10;
            // 
            // guna2btnCancel
            // 
            this.guna2btnCancel.BorderThickness = 1;
            this.guna2btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnCancel.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2btnCancel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnCancel.ForeColor = System.Drawing.Color.White;
            this.guna2btnCancel.Location = new System.Drawing.Point(291, 325);
            this.guna2btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2btnCancel.Name = "guna2btnCancel";
            this.guna2btnCancel.Size = new System.Drawing.Size(160, 36);
            this.guna2btnCancel.TabIndex = 9;
            this.guna2btnCancel.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(30, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Food";
            // 
            // guna2BtnAddFood
            // 
            this.guna2BtnAddFood.BorderThickness = 1;
            this.guna2BtnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2BtnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2BtnAddFood.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2BtnAddFood.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2BtnAddFood.ForeColor = System.Drawing.Color.White;
            this.guna2BtnAddFood.Location = new System.Drawing.Point(48, 325);
            this.guna2BtnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2BtnAddFood.Name = "guna2BtnAddFood";
            this.guna2BtnAddFood.Size = new System.Drawing.Size(160, 36);
            this.guna2BtnAddFood.TabIndex = 8;
            this.guna2BtnAddFood.Text = "Add Food";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(286, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(89, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kind";
            // 
            // guna2PnlAddFood
            // 
            this.guna2PnlAddFood.BorderColor = System.Drawing.Color.Yellow;
            this.guna2PnlAddFood.BorderThickness = 2;
            this.guna2PnlAddFood.Controls.Add(this.pictureBox2);
            this.guna2PnlAddFood.Controls.Add(this.cbb_Kind);
            this.guna2PnlAddFood.Controls.Add(this.btn_image);
            this.guna2PnlAddFood.Controls.Add(this.txtID_Add);
            this.guna2PnlAddFood.Controls.Add(this.txt_price);
            this.guna2PnlAddFood.Controls.Add(this.txtDish);
            this.guna2PnlAddFood.Controls.Add(this.guna2btnCancel);
            this.guna2PnlAddFood.Controls.Add(this.guna2BtnAddFood);
            this.guna2PnlAddFood.Controls.Add(this.label6);
            this.guna2PnlAddFood.Controls.Add(this.label5);
            this.guna2PnlAddFood.Controls.Add(this.label4);
            this.guna2PnlAddFood.Controls.Add(this.label3);
            this.guna2PnlAddFood.Controls.Add(this.label2);
            this.guna2PnlAddFood.Location = new System.Drawing.Point(30, 86);
            this.guna2PnlAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PnlAddFood.Name = "guna2PnlAddFood";
            this.guna2PnlAddFood.Size = new System.Drawing.Size(509, 390);
            this.guna2PnlAddFood.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(15, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.guna2PnlAddFood);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 502);
            this.panel2.TabIndex = 3;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(597, 522);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2PnlAddFood.ResumeLayout(false);
            this.guna2PnlAddFood.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbb_Kind;
        private Guna.UI2.WinForms.Guna2GradientButton btn_image;
        private Guna.UI2.WinForms.Guna2TextBox txtID_Add;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2TextBox txtDish;
        private Guna.UI2.WinForms.Guna2Button guna2btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2BtnAddFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2PnlAddFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}