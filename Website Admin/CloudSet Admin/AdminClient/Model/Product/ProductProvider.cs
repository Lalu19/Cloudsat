using AdminClient.DTO;
using AdminClient.Model.Utility;
using AdminClient.ViewModels.App;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Product
{
    public class ProductProvider : IProduct
    {
        IHttpWebClients _objIHttpWebClients;



        public ProductProvider(IHttpWebClients objIHttpWebClients)
        {

            _objIHttpWebClients = objIHttpWebClients;
        }

        public ProductViewModel CreateProduct(ProductNewDTO productNewDTO)
        {
            try
            {
                ProductViewModel objupdateResults = new ProductViewModel();
                objupdateResults = JsonConvert.DeserializeObject<ProductViewModel>(_objIHttpWebClients.PostRequest("api/Product/CreateProduct", JsonConvert.SerializeObject(productNewDTO), true));
                return objupdateResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductViewModel UpdateProduct(ProductNewDTO productNewDTO)
        {
            try
            {
                ProductViewModel objupdateResults = new ProductViewModel();
                objupdateResults = JsonConvert.DeserializeObject<ProductViewModel>(_objIHttpWebClients.PostRequest("api/Product/UpdateProduct", JsonConvert.SerializeObject(productNewDTO), true));
                return objupdateResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
