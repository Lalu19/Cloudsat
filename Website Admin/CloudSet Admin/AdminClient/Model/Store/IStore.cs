using AdminClient.DTO;
using AdminClient.ViewModels.App;

namespace AdminClient.Model.Store
{ 
    public interface IStore
    {
        public StoreViewModel CreateStore(StoreNewDTO storeNewDTO);
    }
}
