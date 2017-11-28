using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public abstract class BaseRepository<TContract> : IDisposable where TContract : class
    {
        #region Class variables

        private ChannelFactory<TContract> channelFactory = null;
        private TContract channel = null;

        #endregion Class variables

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseRepository(string endpoint)
        {
            CreateChannelFactory(endpoint);
            channel = channelFactory.CreateChannel();
        }

        #endregion Constructor

        #region Public Methods

        protected void Execute(Action<TContract> action)
        {
            action.Invoke(channel);
        }

        /// <summary>
        /// Permite la ejecución de las peticiones al servicio que se invoca
        /// </summary>
        protected TResult Ejecutar<TResult>(Func<TContract, TResult> function)
        {
            return function.Invoke(channel);
        }

        #endregion Metodos publicos

        #region Private methods

        /// <summary>
        /// Creates a Channel Factory
        /// </summary>
        private void CreateChannelFactory(string endpoint)
        {
            channelFactory = new ChannelFactory<TContract>(ConfigurationManager.AppSettings[endpoint]);
        }

        #endregion Private methods

        #region Dispose

        /// <summary>
        /// Implementación de la interfaz IDisposable
        /// </summary>
        public void Dispose()
        {
            try
            {
                if (channel != null)
                {
                    var currentChannel = channel as IClientChannel;
                    if (currentChannel.State == CommunicationState.Faulted)
                    {
                        currentChannel.Abort();
                    }
                    else
                    {
                        currentChannel.Close();
                    }
                }
            }
            finally
            {
                channel = null;
                GC.SuppressFinalize(this);
            }
        }

        #endregion

    }
}
