using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities;

public class Category
{
        public int Id  { get; set; }
        public int SortOrder  { get; set; }
        public bool IsShowOnHome  { get; set; }
        public int? ParentId   { get; set; }
        public Status Status { get; set; }

        public ICollection<ProductInCategory>  ProductInCategories { get; set; } = new  List<ProductInCategory>();
        public ICollection<CategoryTranslation> CategoryTranslations   { get; set; } = new  List<CategoryTranslation>();
}