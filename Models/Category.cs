using System.Collections.Generic;

namespace RecipeBook_00019247.Models
{
    public class Category
    {
        public int Id { get; set; }

        // Non-nullable string, as the category name is required.
        public string Name { get; set; }

        // Collection of recipes linked to the category (nullable as there may be no recipes).
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
