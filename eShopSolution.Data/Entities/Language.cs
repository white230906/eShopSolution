namespace eShopSolution.Data.Entities;

public class Language
{
    public string Id { get; set; }

    public string Name { get; set; }

    public bool IsDefault { get; set; }

    public ICollection<ProductInCategory>  ProductInCategories { get; set; } = new  List<ProductInCategory>();
    public ICollection<CategoryTranslation> CategoryTranslations   { get; set; } = new  List<CategoryTranslation>();
    public ICollection<ProductTranslation> ProductTranslations { get; set; } = new List<ProductTranslation>();
}