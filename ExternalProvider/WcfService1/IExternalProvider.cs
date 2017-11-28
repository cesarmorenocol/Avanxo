using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service.ExternalProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IExternalProvider
    {
        [OperationContract]
        RequestREF GenerateRequest(Request request);
        // TODO: Add your service operations here
    }

    [DataContract]
    public class RequestREF
    {
        [DataMember]
        public int RequestId { get; set; }
    }

    [DataContract]
    public class Request : RequestREF
    {
        [DataMember]
        public int SpecialGiftQuantity { get; set; }

        [DataMember]
        public string CardMessage { get; set; }
    }
}
