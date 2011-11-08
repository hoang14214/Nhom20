using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Nhom20_MayChu
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string[] GetAuthors();

        [OperationContract]
        string DeTai();
    }
}
