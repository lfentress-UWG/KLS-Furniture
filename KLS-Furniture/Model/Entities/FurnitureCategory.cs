namespace KLSFurniture.Model.Entities
{
    /// <summary>
    /// Represents a furniture category from the furniture_categories table.
    /// </summary>
    public class FurnitureCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "";
    }
}