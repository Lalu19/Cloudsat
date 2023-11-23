using AdminClient.DTO;
using AdminClient.ViewModels.App;

namespace AdminClient.Model.Restaurant
{
    public interface IRestaurantImage
    {
        public RestaurantImageViewModel CreateRestaurantImage(RestaurantImageNewDTO restaurantImageNewDTO);
    }
}
