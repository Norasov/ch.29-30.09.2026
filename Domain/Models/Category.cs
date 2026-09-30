namespace Domain.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    private static List<Category> categories = [];

    public static void CreateCategory(string name)
    {
        Category category = new Category();

        category.Id = categories.Count + 1;
        category.Name = name;
        category.CreatedAt = DateTime.Now;

        categories.Add(category);
    }

    public static List<Category> GetCategories()
    {
        return categories;
    }

    public static Category GetCategoryById(int id)
    {
        return categories.Find(x => x.Id == id)!;
    }

    public static Category GetCategoryByName(string name)
    {
        return categories.Find(x => x.Name == name)!;
    }

    public static List<Category> GetCategoryByDate(DateTime date)
    {
        return categories.FindAll(x => x.CreatedAt.Date == date.Date);
    }

    public static void DeleteCategory(int id)
    {
        categories.RemoveAll(x => x.Id == id);
    }
}