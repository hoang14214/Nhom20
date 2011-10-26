using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Tuan4_Server;

namespace Tuan4_Client
{
    public partial class Tuan4_Client : Form
    {

        IServer patientSvc = null;

        public Tuan4_Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds_KetNoi.SelectedIndex = 0;
            
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds_KetNoi.SelectedIndex == 0)
                {
                    EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8000/BasicHttpBinding"));
                    ChannelFactory<IServer> factory = new ChannelFactory<IServer>(new BasicHttpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
                else if (ds_KetNoi.SelectedIndex == 1)
                {
                    EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8000/WSHttpBinding"));
                    ChannelFactory<IServer> factory = new ChannelFactory<IServer>(new WSHttpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
                else if (ds_KetNoi.SelectedIndex == 2)
                {
                    EndpointAddress address = new EndpointAddress(new Uri("net.tcp://localhost:8000/NetTcpBinding"));
                    ChannelFactory<IServer> factory = new ChannelFactory<IServer>(new NetTcpBinding(), address);
                    patientSvc = factory.CreateChannel();
                    for (int i = 0; i < patientSvc.GetAuthors().Count(); i++)
                        lv_ThanhVien.Items.Add(patientSvc.GetAuthors()[i]);
                    tb_DeTai.Text = patientSvc.DeTai();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Không kết nối được !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_DeTai.Text = "";
                lv_ThanhVien.Items.Clear();
            }
        }
    }
}
