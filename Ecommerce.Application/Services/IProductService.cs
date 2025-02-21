using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Services;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product product);
}