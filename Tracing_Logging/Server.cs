using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tuan4_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Server" in both code and config file together.
    public class Server : IServer
    {
        public string[] GetAuthors()
        {
            string[] tacgia = new string[] {"Nguyễn Mạnh Hoàng","Nguyễn Đình Thi","Phan Quốc Anh"};
            return tacgia;
        }
        public string DeTai()
        {
            return "Hệ thống thông tin giao thông";
        }
    }
}
