using Entities;
using ServiceLayer.ServiceExternalProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class RequestRepository : BaseRepository<IExternalProviderChannel>
    {
        #region Class variables

        private const string endpoint = "EndPointExternalProvider";

        #endregion Class variables

        #region Constructor

        public RequestRepository() : base(endpoint)
        {
        }

        #endregion Constructor

        #region Public Methods

        public int GenerateRequest(Delivery delivery)
        {
            var request = new Request() { SpecialGiftQuantity = 3, CardMessage = String.Empty };
            var response = Ejecutar(p => p.GenerateRequest(request));
            return response.RequestId;
        }

        #endregion Public Methods
    }
}
