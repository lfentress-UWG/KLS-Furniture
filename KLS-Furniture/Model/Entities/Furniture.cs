namespace KLSFurniture.Model.Entities
{
    /// <summary>
    /// Represents a furniture item from the furniture table.
    /// </summary>
    public class Furniture
    {
        public int FurnitureId { get; set; }

        public string Name { get; set; } = "";
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public int StyleId { get; set; }

        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }
    }
}