using OrderService.Models;
using EDADBContext.Models;

namespace OrderService.Business.Interface
{
    public interface IProductBusiness
    {
        Task<List<ProductModel>> GetProductsList();
        Task<ProductModel> GetProductById(Guid productId);
        Task<List<ProductViewModel>> GetProducts();
        Task<string> GetProductNameById(Guid productId);
    }
}
