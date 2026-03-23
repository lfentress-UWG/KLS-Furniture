using KLS_Furniture.Model.Lookups;

namespace KLS_Furniture.Model
{
    /// <summary>
    /// Stores information about the currently logged-in employee.
    /// </summary>
    public static class CurrentSession
    {
        public static LoggedInUserLookupItem LoggedInUser { get; set; }

        public static bool IsLoggedIn
        {
            get { return LoggedInUser != null; }
        }

        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}