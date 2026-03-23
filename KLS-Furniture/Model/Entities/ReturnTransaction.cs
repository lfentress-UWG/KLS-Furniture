using System;

namespace KLSFurniture.Model.Entities
{
    /// <summary>
    /// Represents a return transaction from the return_transactions table.
    /// </summary>
    public class ReturnTransaction
    {
        public int ReturnTransactionId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReturnDateTime { get; set; }

        public decimal TotalFineAmount { get; set; }
        public decimal TotalRefundAmount { get; set; }
    }
}