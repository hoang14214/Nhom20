using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Tuan4_Server
{
    public partial class Tuan4_Server : Form
    {
        bool serviceStarted = false;
        ServiceHost myServiceHost = null;
        ServiceMetadataBehavior behavior;

        public Tuan4_Server()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (!serviceStarted)
            {
                Uri baseAddress;

                try
                {
                    //Kết nối kiểu BasicHttpBinding
                    if (rad_BasicHttpBinding.Checked == true)
                    {
                        baseAddress = new Uri("http://" + tb_BaseAddress.Text + "/" + tb_BasicHttpBinding.Text);
                        myServiceHost = new ServiceHost(typeof(Server), baseAddress);
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new BasicHttpBinding(), baseAddress);

                        if (cb_Mex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myServiceHost.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myServiceHost.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX1");
                        }
                        myServiceHost.Open();
                        tb_Message.Text = "Tạo kiểu kết nối BasicHttpBinding thành công !";
                    }
                    //Kết nối kiểu WSHttpBinding
                    if (rad_WSHttpBinding.Checked == true)
                    {
                        baseAddress = new Uri("http://" + tb_BaseAddress.Text + "/" + tb_WSHttpBinding.Text);
                        myServiceHost = new ServiceHost(typeof(Server), baseAddress);
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new WSHttpBinding(), baseAddress);

                        if (cb_Mex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myServiceHost.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myServiceHost.AddServiceEndpoint(typeof(IMetadataExchange), new WSHttpBinding(), "MEX2");
                        }
                        myServiceHost.Open();
                        tb_Message.Text = "Tạo kiểu kết nối WSHttpBinding thành công !";
                    }

                    //Kết nối kiểu NetTcpBinding
                    if (rad_NetTcpBinding.Checked == true)
                    {
                        baseAddress = new Uri("net.tcp://" + tb_BaseAddress.Text + "/" + tb_NetTcpBinding.Text);
                        myServiceHost = new ServiceHost(typeof(Server), baseAddress);
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new NetTcpBinding(), baseAddress);
                        myServiceHost.Open();
                        tb_Message.Text = "Tạo kiểu kết nối NetTcpBinding thành công !";
                    }


                    serviceStarted = true;
                    bt_Stop.Enabled = true;
                    bt_Start.Enabled = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lõi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            myServiceHost.Close();
            serviceStarted = false;
            bt_Stop.Enabled = false;
            bt_Start.Enabled = true;
            tb_Message.Text = "Không có kết nối nào !";
        }

        private void Tuan4_Server_Load(object sender, EventArgs e)
        {
            bt_Stop.Enabled = false;
        }

        
    }
}
