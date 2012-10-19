﻿using Eloqua.Api.Rest.ClientLibrary.Clients.Assets;
using Eloqua.Api.Rest.ClientLibrary.Clients.Data;
using Eloqua.Api.Rest.ClientLibrary.Clients.Systems;

namespace Eloqua.Api.Rest.ClientLibrary
{
    public class Client : BaseClient
    {
        #region constructor

        public Client(string site, string user, string password, string baseUrl)
        {
            BaseClient = new BaseClient(site, user, password, baseUrl);
        }

        #endregion

        #region properties

        protected BaseClient BaseClient;

        #endregion

        #region Assets Client

        public AssetClient Assets
        {
            get { return new AssetClient(BaseClient);}
        }

        #endregion

        #region Data Client

        public DataClient Data
        {
            get { return new DataClient(BaseClient); }
        }

        #endregion

        #region Systems Client

        public SystemClient Systems
        {
            get { return new SystemClient(BaseClient); }
        }

        #endregion
    }
}