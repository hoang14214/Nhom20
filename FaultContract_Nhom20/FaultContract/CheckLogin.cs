using System;
using System.Runtime.Serialization;

namespace FaultContract
{
    [DataContract]
    public class KiemTra
    {
        static string[] Account=new string[5]{"","","","",""};
        internal static void ID(string id)
        {
            if (id.Trim()=="")
            {
                throw new ArgumentException("Xin điền Tài khoản vào ô trống !");
            }
            else if (id != Account[0])
            {
                throw new ArgumentException("Tài khoản không chính xác !");
            }
        }

        
        internal static void MatKhau(string mk)
        {
            if (mk.Trim()=="")
            {
                throw new ArgumentException("Xin điền Mật khẩu vào ô trống !");
            }
            else if(mk.Length<=5)
            {
                throw new ArgumentException("Mật khẩu phải có độ dài > 5 !");
            }
            else if (mk != Account[1])
            {
                throw new ArgumentException("Mật khẩu không chính xác !");
            }
        }

        
        internal static void CheckCa2(string id, string mk)
        {
            if (id.Trim()=="" && mk.Trim()=="")
            {
                throw new ArgumentException("Không được để trống cả 2 !");
            }
            else
            {
                ID(id);
                MatKhau(mk);
            }
            
        }


        internal static void TaoTK(string tk, string mk, string ht, string em, string pn)
        {
            Account = new string[5] { tk, mk, ht, em, pn };
        }

        internal static void SoSanhMatKhauDK(string mk1 ,string mk2)
        {
            if (mk1 != mk2)
                throw new ArgumentException("Mật khẩu nhập lại không chính xác !");
        }

    }

}