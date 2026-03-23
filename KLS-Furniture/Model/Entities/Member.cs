using System;

namespace KLSFurniture.Model.Entities
{
    /// <summary>
    /// Represents a member from the members table.
    /// </summary>
    public class Member
    {
        public int MemberId { get; set; }

        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = "";

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}