using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace Login_Nhom20
{
    public partial class DangKy : Form
    {
        public DangNhap dn;

        public DangKy(DangNhap dangnhap)
        {
            dn = dangnhap;
            InitializeComponent();
        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                SV_Login.LoginServiceClient cl = new SV_Login.LoginServiceClient();
                cl.DangKy(tb_TaiKhoan.Text, tb_MatKhau.Text,tb_NhapLaiMK.Text, tb_HoTen.Text, tb_Email.Text, tb_Phone.Text);
                dn.Show();
                this.Close();
            }

            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.GetType().ToString());
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            dn.Hide();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            dn.Show();
            this.Close();
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            dn.Close();
        }


    }
}
