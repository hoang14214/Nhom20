using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FaultContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILoginService
    {

        [OperationContract]
        [FaultContract(typeof(KiemTra))]
        bool KiemTraTaiKhoan(string tk, string mk);

        [OperationContract]
        [FaultContract(typeof(KiemTra))]
        void DangKy(string tk, string mk1, string mk2, string ht, string em, string pn);
    }

}
