using System;
using System.ComponentModel;
using System.IO;

namespace KLS_Furniture.DAL
{
    /// <summary>
    /// Builds a connection string to the local KLSFurniture.mdf located in App_Data folder.
    /// </summary>
    public static class KLSFurnitureDBConnection
    {
        private static string _cs;

        /// <summary>
        /// Returns connection string for KLSFurniture.mdf (LocalDB attach).
        /// </summary>
        public static string GetConnectionString()
        {

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return "";

            if (string.IsNullOrEmpty(_cs))
            {
                string mdfPath = Path.Combine(AppContext.BaseDirectory, "App_Data", "KLSFurniture.mdf");

                if (!File.Exists(mdfPath))
                    throw new FileNotFoundException("KLSFurniture.mdf not found.", mdfPath);

                _cs = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                      "AttachDbFilename=" + mdfPath + ";" +
                      "Integrated Security=True;" +
                      "Connect Timeout=30;";
            }

            return _cs;
        }
    }
}