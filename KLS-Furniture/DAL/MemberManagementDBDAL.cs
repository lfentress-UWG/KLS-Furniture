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

        /// <summary>
        /// Adds a new member in the database and returns the member.
        /// </summary>
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

        /// <summary>
        /// Updates an existing member in the database and returns the updated member.
        /// </summary>
        public Member UpdateMember(Member member)
        {
            if (member == null)
                throw new ArgumentNullException(nameof(member));

            if (member.MemberId <= 0)
                throw new ArgumentException("Valid MemberId is required for update.", nameof(member));

            const string sql = @"
                UPDATE members 
                SET last_name      = @last_name,
                    first_name     = @first_name,
                    sex            = @sex,
                    date_of_birth  = @date_of_birth,
                    phone          = @phone,
                    address_line_1 = @address_line_1,
                    address_line_2 = @address_line_2,
                    city           = @city,
                    state          = @state,
                    zip_code       = @zip_code
                WHERE member_id = @member_id;

                SELECT member_id, last_name, first_name, sex, date_of_birth, phone,
                       address_line_1, address_line_2, city, state, zip_code
                FROM members 
                WHERE member_id = @member_id;";

            using (SqlConnection conn = new SqlConnection(_cs))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@member_id", member.MemberId);
                cmd.Parameters.AddWithValue("@last_name", (object)member.LastName);
                cmd.Parameters.AddWithValue("@first_name", (object)member.FirstName);
                cmd.Parameters.AddWithValue("@sex", (object)member.Sex ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@date_of_birth", member.DateOfBirth);
                cmd.Parameters.AddWithValue("@phone", (object)member.Phone);
                cmd.Parameters.AddWithValue("@address_line_1", (object)member.AddressLine1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@address_line_2", (object)member.AddressLine2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@city", (object)member.City ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@state", (object)member.State ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@zip_code", (object)member.ZipCode ?? DBNull.Value);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Refresh the member object with latest data from DB
                        member.LastName = reader["last_name"] as string;
                        member.FirstName = reader["first_name"] as string;
                        member.Sex = reader["sex"] as string;
                        member.DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]);
                        member.Phone = reader["phone"] as string;
                        member.AddressLine1 = reader["address_line_1"] as string ?? "";
                        member.AddressLine2 = reader["address_line_2"] as string ?? "";
                        member.City = reader["city"] as string ?? "";
                        member.State = reader["state"] as string;
                        member.ZipCode = reader["zip_code"] as string ?? "";
                    }
                }

                return member;
            }
        }
    }
}
