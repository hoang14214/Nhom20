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
    public partial class DangNhap : Form
    {
        SV_Login.LoginServiceClient _serviceProxy = new Login_Nhom20.SV_Login.LoginServiceClient();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_serviceProxy.KiemTraTaiKhoan(tb_User.Text,tb_Pass.Text).ToString());
            }

            catch (Exception exp)//bat loi o code rieng phia client
            {
                MessageBox.Show(exp.Message.ToString(), exp.GetType().ToString());
            }
        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {          
            DangKy dk = new DangKy(this);
            dk.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

    }
}
