using AdminClient.DTO;
using AdminClient.Model.Utility;
using AdminClient.ViewModels.App;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Store
{
    public class StoreProvider : IStore
    {
 
        IHttpWebClients _objIHttpWebClients;

        /// <summary>
        /// Constructor declaration
        /// </summary>
        /// 
       
        /// <param name="objKeyList"></param>
        /// <param name="objIHttpWebClients"></param>
        public StoreProvider( IHttpWebClients objIHttpWebClients)
        {
            
            _objIHttpWebClients = objIHttpWebClients;
        }

        public StoreViewModel CreateStore(StoreNewDTO storeNewDTO)
        {
            try
            {
                StoreViewModel objupdateResults = new StoreViewModel();
                objupdateResults = JsonConvert.DeserializeObject<StoreViewModel>(_objIHttpWebClients.PostRequest("api/Store/CreateStore", JsonConvert.SerializeObject(storeNewDTO), true));
                return objupdateResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
