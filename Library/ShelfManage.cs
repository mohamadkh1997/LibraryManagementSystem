using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library
{
    internal class ShelfManage
    {
        // Method to add a new shelf to the database
        public bool AddShelf(Shelf shelf)
        {
            string query = "INSERT INTO Shelves (Location, Description) VALUES (@Location, @Description)";
            var parameters = new Dictionary<string, object>
        {
            {"@Location", shelf.Location},
            {"@Description", shelf.Description}
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Method to update an existing shelf
        public bool UpdateShelf(Shelf shelf)
        {
            string query = "UPDATE Shelves SET Location = @Location, Description = @Description WHERE Id = @ShelfID";
            var parameters = new Dictionary<string, object>
        {
            {"@ShelfID", shelf.ShelfID},
            {"@Location", shelf.Location},
            {"@Description", shelf.Description}
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }





        // Method to delete a shelf
        public bool DeleteShelf(int shelfId)
        {

          
            string query = "DELETE FROM Shelves WHERE Id = @ShelfID"; // Ensure the column name is correct in the query
            var parameters = new Dictionary<string, object>
    {
        {"@ShelfID", shelfId}
    };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }




        // Method to retrieve a shelf by ID
        public Shelf GetShelfById(int shelfId)
        {
            string query = "SELECT * FROM Shelves WHERE Id = @ShelfID";
            var parameters = new Dictionary<string, object>
        {
            {"@ShelfID", shelfId}
        };

            using (var reader = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                if (reader != null && reader.Read())
                {
                    return new Shelf
                    {
                        ShelfID = reader.GetInt32(reader.GetOrdinal("Id")),
                        Location = reader.GetString(reader.GetOrdinal("Location")),
                        Description = reader.GetString(reader.GetOrdinal("Description"))
                    };
                }
            }
            return null;
        }






     public SqlDataReader searchshelf(string location)
        {

            string query = "SELECT * FROM Shelves WHERE ";
            var parameters = new Dictionary<string, object>();

            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(location))
            {
                conditions.Add("Location LIKE @location");
                parameters.Add("@location", $"%{location}%");
            }

            if (conditions.Count == 0)
            {
                query = "SELECT * FROM Shelves"; // Select all if no conditions
            }
            else
            {
                query += string.Join(" AND ", conditions);
            }

            SqlDataReader reader = DatabaseHelper.ExecuteQuery(query, parameters); 
            return reader;
        }


    }
}
