namespace KLS_Furniture.Model.Entities
{
    /// <summary>
    /// Represents a rental transaction item from the rental_transaction_items table.
    /// </summary>
    public class RentalTransactionItem
    {
        public int RentalTransactionId { get; set; }
        public int FurnitureId { get; set; }

        public int Quantity { get; set; }
        public decimal DailyRateAtRent { get; set; }
    }
}