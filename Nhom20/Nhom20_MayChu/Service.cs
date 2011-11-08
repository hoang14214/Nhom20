using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Nhom20_MayChu
{
    public class Service : IService
    {
        public string[] GetAuthors()
        {
            Thread.Sleep(1000);
            string[] tacgia = new string[] { "Nguyễn Mạnh Hoàng", "Nguyễn Đình Thi", "Phan Quốc Anh" };
            return tacgia;
        }
        public string DeTai()
        {
            Thread.Sleep(10000);
            return "Hệ thống thông tin giao thông";
        }
    }
}
