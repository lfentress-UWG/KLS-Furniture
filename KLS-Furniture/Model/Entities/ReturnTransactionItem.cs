namespace KLS_Furniture.Model.Entities
{
    /// <summary>
    /// Represents a return transaction item from the return_transaction_items table.
    /// </summary>
    public class ReturnTransactionItem
    {
        public int ReturnTransactionId { get; set; }
        public int RentalTransactionId { get; set; }
        public int FurnitureId { get; set; }

        public int QuantityReturned { get; set; }
        public decimal FineAmount { get; set; }
        public decimal RefundAmount { get; set; }
    }
}