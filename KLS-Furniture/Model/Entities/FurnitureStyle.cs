namespace KLS_Furniture.Model.Entities
{
    /// <summary>
    /// Represents a furniture style from the furniture_styles table.
    /// </summary>
    public class FurnitureStyle
    {
        public int StyleId { get; set; }
        public string StyleName { get; set; } = "";
    }
}