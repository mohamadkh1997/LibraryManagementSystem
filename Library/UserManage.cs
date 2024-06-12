using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Library
{
    internal class UserManage
    {

        public bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";
            var parameters = new Dictionary<string, object>
        {
            {"@Username", username}
        };

            int userCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return userCount > 0;
        }

        public bool AddUser(User user)
        {
            string query = "INSERT INTO [User] (Username, Password, Role, DATETIME) VALUES (@Username, @Password, @Role, @CreatedDate)";
            var parameters = new Dictionary<string, object>
    {
        {"@Username", user.Username},
        {"@Password", BCrypt.Net.BCrypt.HashPassword(user.Password)}, // Ensure this is hashed
        {"@Role", 1},  // Ensure this corresponds to an actual role ID in your database
        {"@CreatedDate", user.CreatedDate}
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }



        public string Login(string username, string password)
        {
            string query = "SELECT Password, Role, IsActive FROM [User] WHERE Username = @Username";
            var parameters = new Dictionary<string, object>
        {
            {"@Username", username}
        };

            using (SqlDataReader reader = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                if (reader != null && reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();
                    int role = Convert.ToInt32(reader["Role"]);
                    bool isActive = Convert.ToBoolean(reader["IsActive"]);

                    if (!BCrypt.Net.BCrypt.Verify(password, storedPassword))
                    {
                        return "Incorrect password.";
                    }
                    else if (role != 1)
                    {
                        return "Access denied. User does not have the required permissions.";
                    }
                    else if (!isActive)
                    {
                        return "Account is not active.";
                    }
                    else
                    {
                        return "Login successful.";
                    }
                }
                return "User does not exist.";
            }
        }




    }
}
