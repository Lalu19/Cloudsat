using AdminClient.DTO;
using AdminClient.ViewModels.App;

namespace AdminClient.Model.Product
{
    public interface IProduct
    { 
        public ProductViewModel CreateProduct(ProductNewDTO productNewDTO);
        public ProductViewModel UpdateProduct(ProductNewDTO productNewDTO);
    }
}
