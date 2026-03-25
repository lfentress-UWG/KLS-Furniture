namespace KLS_Furniture.Model.Lookups
{
    /// <summary>
    /// Provides lightweight information about the logged-in employee.
    /// </summary>
    public class LoggedInUserLookupItem
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Returns the display text for the logged-in user.
        /// </summary>
        public override string ToString()
        {
            return FirstName + " " + LastName + " (" + Username + ")";
        }
    }
}