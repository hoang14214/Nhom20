using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Nhom20_MayChu;
using System.Threading;

namespace Nhom20_MayTram
{
    public partial class Nhom20_MayTram : Form
    {
        IService patientSvc = null;
        static EndpointAddress address;
        static ChannelFactory<IService> factory;
        public Nhom20_MayTram()
        {
            InitializeComponent();
        }

        private void Nhom20_MayTram_Load(object sender, EventArgs e)
        {
            ds_KetNoi.SelectedIndex = 0;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds_KetNoi.SelectedIndex == 0)
                {
                    address = new EndpointAddress(new Uri("http://localhost:8000/BasicHttpBinding"));
                    factory = new ChannelFactory<IService>(new BasicHttpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
                else if (ds_KetNoi.SelectedIndex == 1)
                {
                    address = new EndpointAddress(new Uri("http://localhost:8000/WSHttpBinding"));
                    factory = new ChannelFactory<IService>(new WSHttpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
                else if (ds_KetNoi.SelectedIndex == 2)
                {
                    address = new EndpointAddress(new Uri("net.tcp://localhost:8000/NetTcpBinding"));
                    factory = new ChannelFactory<IService>(new NetTcpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Không kết nối được !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_DeTai.Text = "";
                lv_ThanhVien.Items.Clear();
            }
        }

        private void bt_TuDongKetNoi_Click(object sender, EventArgs e)
        {
            bt_Start.Enabled = false;
            ds_KetNoi.Enabled = false;
            TuKetNoi();
        }

        private void TuKetNoi()
        {
            try
            {
                tb_KetNoiTuDong.Text = "Đang chờ kết nối từ Máy chủ !";
                tb_KetNoiTuDong.Update();
                SVR_Basic.ServiceClient Basic = new SVR_Basic.ServiceClient();
                Basic.DeTaiCompleted += new EventHandler<SVR_Basic.DeTaiCompletedEventArgs>(HamDeTaiGoiLai);
                Basic.DeTaiAsync();
                Basic.GetAuthorsCompleted += new EventHandler<SVR_Basic.GetAuthorsCompletedEventArgs>(HamGetAuthorsGoiLai);
                Basic.GetAuthorsAsync();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("asasdad", "3213123");
            }
        }

        void HamDeTaiGoiLai(Object sender, SVR_Basic.DeTaiCompletedEventArgs e)
        {
            try
            {
                string rs = e.Result;
                tb_DeTai.Text = rs;
            }
            catch (System.Exception ex)
            {

            }
            Thread.Sleep(1000);
        }

        void HamGetAuthorsGoiLai(Object sender, SVR_Basic.GetAuthorsCompletedEventArgs e)
        {
            try
            {
                string[] rs = e.Result;
                for (int i = 0; i < rs.Count(); i++)
                {
                    lv_ThanhVien.Items.Add(rs[i]);
                }
                
            }
            catch (System.Exception ex)
            {

            }
            Thread.Sleep(1000);

        }
    }
}
