using System;

namespace KLS_Furniture.Model.Entities
{
    /// <summary>
    /// Represents a rental transaction from the rental_transactions table.
    /// </summary>
    public class RentalTransaction
    {
        public int RentalTransactionId { get; set; }
        public int MemberId { get; set; }
        public int EmployeeId { get; set; }

        public DateTime RentalDateTime { get; set; }
        public DateTime DueDateTime { get; set; }
    }
}