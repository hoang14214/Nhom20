using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FaultContract
{
    public class LoginService : ILoginService
    {
        public bool KiemTraTaiKhoan(string id, string mk)
        {
            try
            {
                KiemTra.CheckCa2(id, mk);
                KiemTra.ID(id);
                KiemTra.MatKhau(mk);
            }
            catch (ArgumentException ex)
            {
                throw new FaultException(ex.Message);
            }
            catch (Exception exp)
            {
                FaultReasonText reason = new FaultReasonText("Error processing invoice");
                throw new FaultException(new FaultReason(reason), FaultCode.CreateReceiverFaultCode(new FaultCode("ApproveInvoice")));
                //throw new FaultException("Basic Exception (hard coded for Ids 11-20).");
            }
            return true;
        }

        public void DangKy(string tk, string mk1,string mk2, string ht, string em, string pn)
        {
            try
            {
                KiemTra.SoSanhMatKhauDK(mk1, mk2);
                KiemTra.TaoTK(tk, mk2, ht, em, pn);
            }
            catch (ArgumentException ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
