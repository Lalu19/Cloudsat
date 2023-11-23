using AdminClient.DTO;
using AdminClient.Model.Utility;
using AdminClient.ViewModels.App;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Restaurant
{
    public class RestaurantImageProvider:IRestaurantImage
    {
        IHttpWebClients _objIHttpWebClients;
        /// <summary>
        /// Constructor declaration
        /// </summary>
        /// <param name="objKeyList"></param>
        /// <param name="objIHttpWebClients"></param>
        public RestaurantImageProvider(IHttpWebClients objIHttpWebClients)
        {

            _objIHttpWebClients = objIHttpWebClients;
        }

        public RestaurantImageViewModel CreateRestaurantImage(RestaurantImageNewDTO restaurantImageNewDTO)
        {
            try
            {
                RestaurantImageViewModel objupdateResults = new RestaurantImageViewModel();
                objupdateResults = JsonConvert.DeserializeObject<RestaurantImageViewModel>(_objIHttpWebClients.PostRequest("api/RestaurantImage/CreateResturentImage", JsonConvert.SerializeObject(restaurantImageNewDTO), true));
                return objupdateResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
