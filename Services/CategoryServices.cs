using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class CategoryServices
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryServices(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public CategoryEntity CreateCategory(string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
        categoryEntity ??= _categoryRepository.Create(new CategoryEntity { CategoryName = categoryName });

        return categoryEntity;
    }

    public CategoryEntity GetCategoryByName(string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);

        return categoryEntity;
    }

    public CategoryEntity GetCategoryById(int Id)
    {
        var categoryEntity = _categoryRepository.Get(x => x.Id == Id);

        return categoryEntity;
    }

    public IEnumerable<CategoryEntity> GetCategories()
    {
        var categoryEntity = _categoryRepository.GetAll();

        return categoryEntity;
    }

    public CategoryEntity UpdateCategory(CategoryEntity categoryEntity)
    {
        var updatedCategoryEntity = _categoryRepository.Update(x => x.Id == categoryEntity.Id, categoryEntity);

        return categoryEntity;
    }

    public void DeleteCategory(int Id)
    {
        _categoryRepository.Delete(x => x.Id == Id);
    }
}