using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KLS_Furniture.Model.Entities;

namespace KLS_Furniture.DAL
{
    public class MemberManagementDBDAL
    {
        private readonly string _cs;

        /// <summary>
        /// Initializes DAL and resolves the KLSFurniture database connection string.
        /// </summary>
        public MemberManagementDBDAL() 
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                _cs = "";
                return;
            }

            _cs = KLSFurnitureDBConnection.GetConnectionString();
        }

        public Member AddMember(Member newMember) 
        {
            if (newMember == null)
                throw new ArgumentNullException(nameof(newMember));

            const string sql = @"INSERT INTO members 
                    (last_name, first_name, sex, date_of_birth, phone, 
                     address_line_1, address_line_2, city, state, zip_code)
                    OUTPUT INSERTED.member_id
                    VALUES
                    (@last_name, @first_name, @sex, @date_of_birth, @phone, 
                     @address_line_1, @address_line_2, @city, @state, @zip_code);";

            using(SqlConnection conn = new SqlConnection(_cs))
                using(SqlCommand cmd = new SqlCommand(sql, conn)) 
                {
                    cmd.Parameters.AddWithValue("@last_name", newMember.LastName);
                    cmd.Parameters.AddWithValue("@first_name", newMember.FirstName);
                    cmd.Parameters.AddWithValue("@sex", (object)newMember.Sex ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date_of_birth", newMember.DateOfBirth);
                    cmd.Parameters.AddWithValue("@phone", newMember.Phone);
                    cmd.Parameters.AddWithValue("@address_line_1", (object)newMember.AddressLine1 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@address_line_2", (object)newMember.AddressLine2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@city", (object)newMember.City ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@state", (object)newMember.State ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@zip_code", (object)newMember.ZipCode ?? DBNull.Value);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        newMember.MemberId = Convert.ToInt32(result);
                    }

                    return newMember;
                }
        }
    }
}
