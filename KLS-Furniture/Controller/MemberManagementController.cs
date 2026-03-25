using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KLS_Furniture.DAL;
using KLS_Furniture.Model.Entities;

namespace KLS_Furniture.Controller
{
    /// <summary>
    /// Handles Member Management actions: Add, Edit, Retrieve, and Search
    /// </summary>
    public class MemberManagementController
    {
        private readonly MemberManagementDBDAL memberMangagementDAL;

        public MemberManagementController()
        {
            this.memberMangagementDAL = new MemberManagementDBDAL();
        }

        public Member AddMember(Member newMember) 
        {
            if (newMember == null)
                throw new ArgumentNullException(nameof(newMember));
            
            return memberMangagementDAL.AddMember(newMember);
        }
    }
}
