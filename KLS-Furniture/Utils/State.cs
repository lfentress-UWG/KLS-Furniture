using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLS_Furniture.Utils
{
    /// <summary>
    /// Util Class that supports US state names and abbreviations
    /// </summary>
    public class State
    {
        /// <summary>
        /// Getter/Setter for Abbreviation field
        /// </summary>
        public string Abbreviation {  get; set; }
        /// <summary>
        /// Getter/Setter for Name field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Combines and formats Abbreviation and Name combination
        /// </summary>
        /// <returns>String with Abbreviation and Name combined and formatted</returns>
        public override string ToString()
        {
            return $"{Abbreviation} - {Name}";
        }
    }
}
