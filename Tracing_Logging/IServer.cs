using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tuan4_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServer" in both code and config file together.
    [ServiceContract]
    public interface IServer
    {
        [OperationContract]
        string[] GetAuthors();

        [OperationContract]
        string DeTai();
    }
}
