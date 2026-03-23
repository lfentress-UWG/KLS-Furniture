using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KLS_Furniture.DAL;

namespace KLS_Furniture.Controller
{
    /// <summary>
    /// Controller class that acts as the intermediary between the forms
    /// and the <see cref="KLS_DAL"/>.
    /// Contains all business logic related to incidents and provides a clean interface
    /// for adding, retrieving, editing and filtering application requirements.
    /// </summary>
    public class KSL_Controller
    {
        /// <summary>
        /// Reference <see cref="KLS_DAL"/> responsible for storing, editing, and retrieving application needs.
        /// </summary>
        private readonly KLS_DAL DAL_Source;

        /// <summary>
        /// Initializes a new instance of the <see cref="KSL_Controller"/> class.
        /// Creates a new instance of <see cref="KLS_DAL"/> for data operations.
        /// </summary>
        public KSL_Controller() 
        {
            this.DAL_Source = new KLS_DAL();
        }
    }
}
