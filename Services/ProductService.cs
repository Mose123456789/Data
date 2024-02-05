using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryServices _categoryServices;

    public ProductService(ProductRepository productRepository, CategoryServices categoryServices)
    {
        _productRepository = productRepository;
        _categoryServices = categoryServices;
    }

    public ProductEntity CreateProduct(string title, decimal price, string categoryName)
    {
        var categoryEntity = _categoryServices.CreateCategory(categoryName);

        var productEntity = new ProductEntity
        {
            Title = title,
            Price = price,
            CategoryId = categoryEntity.Id,
        };

        productEntity = _productRepository.Create(productEntity);
        return productEntity;
    }

    public ProductEntity GetProductById(int Id)
    {
        var productEntity = _productRepository.Get(x => x.Id == Id);

        return productEntity;
    }

    public IEnumerable<ProductEntity> GetProducts()
    {
        var products = _productRepository.GetAll();

        return products;
    }

    public ProductEntity UpdateProduct(ProductEntity productEntity)
    {
        var updatedproductEntity = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);

        return productEntity;
    }

    public void DeleteProduct(int Id)
    {
        _productRepository.Delete(x => x.Id == Id);
    }
}