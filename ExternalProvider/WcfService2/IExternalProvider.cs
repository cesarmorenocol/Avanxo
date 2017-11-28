using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProviderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IExternalProvider
    {
        // TODO: Add your service operations here
        [OperationContract]
        RequestREF GenerateRequest(Request request);
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
