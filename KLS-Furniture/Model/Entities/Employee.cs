using System;

namespace KLS_Furniture.Model.Entities
{
    /// <summary>
    /// Represents an employee from the employees table.
    /// </summary>
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public bool IsAdmin { get; set; }

        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}