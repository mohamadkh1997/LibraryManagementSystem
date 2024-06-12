using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookManagment
    {


        // Adds a new book to the database
        public bool AddBook(Book book)
        {
            string query = "INSERT INTO Books (Title, Author, ISBN, PublishedYear, Genre, ShelfID) VALUES (@Title, @Author, @ISBN, @PublishedYear, @Genre, @ShelfID)";
            var parameters = new Dictionary<string, object>
        {
            {"@Title", book.Title},
            {"@Author", book.Author},
            {"@ISBN", book.ISBN},
            {"@PublishedYear", book.PublishedYear},
            {"@Genre", book.Genre},
            {"@ShelfID", book.ShelfID}
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Updates an existing book in the database
        public bool UpdateBook(Book book)
        {
            string query = "UPDATE Books SET Title = @Title, Author = @Author, ISBN = @ISBN, PublishedYear = @PublishedYear, Genre = @Genre, ShelfID = @ShelfID WHERE BookID = @BookID";
            var parameters = new Dictionary<string, object>
        {
            {"@BookID", book.BookID},
            {"@Title", book.Title},
            {"@Author", book.Author},
            {"@ISBN", book.ISBN},
            {"@PublishedYear", book.PublishedYear},
            {"@Genre", book.Genre},
            {"@ShelfID", book.ShelfID}
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Removes a book from the database
        public bool RemoveBook(int bookId)
        {
            string query = "DELETE FROM Books WHERE BookID = @BookID";
            var parameters = new Dictionary<string, object>
        {
            {"@BookID", bookId}
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves a book by its ID
        public Book GetBookById(int bookId)
        {
            string query = "SELECT * FROM Books WHERE BookID = @BookID";
            var parameters = new Dictionary<string, object>
        {
            {"@BookID", bookId}
        };

            using (var reader = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                if (reader != null && reader.Read())
                {
                    return new Book
                    {
                        BookID = reader.GetInt32(reader.GetOrdinal("BookID")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        Author = reader.GetString(reader.GetOrdinal("Author")),
                        ISBN = reader.GetString(reader.GetOrdinal("ISBN")),
                        PublishedYear = reader.GetInt32(reader.GetOrdinal("PublishedYear")),
                        Genre = reader.GetString(reader.GetOrdinal("Genre")),
                        ShelfID = reader.IsDBNull(reader.GetOrdinal("ShelfID")) ? null : reader.GetInt32(reader.GetOrdinal("ShelfID"))
                    };
                }
                return null;
            }
        }




        public List<Book> SearchBooks(string name, string author, int? year, string genre, int? shelf)
        {
            List<string> conditions = new List<string>();
            var parameters = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                conditions.Add("Title LIKE @Name");
                parameters.Add("@Name", $"%{name}%");
            }
            if (!string.IsNullOrWhiteSpace(author))
            {
                conditions.Add("Author LIKE @Author");
                parameters.Add("@Author", $"%{author}%");
            }
            if (year.HasValue)
            {
                conditions.Add("PublishedYear = @Year");
                parameters.Add("@Year", year.Value);
            }
            if (!string.IsNullOrWhiteSpace(genre))
            {
                conditions.Add("Genre LIKE @Genre");
                parameters.Add("@Genre", $"%{genre}%");
            }
            if (shelf.HasValue)
            {
                conditions.Add("ShelfID = @Shelf");
                parameters.Add("@Shelf", shelf.Value);
            }

            string query = "SELECT * FROM Book";
            if (conditions.Any())
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            List<Book> books = new List<Book>();
            using (var reader = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                while (reader != null && reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = reader.GetInt32(reader.GetOrdinal("Id")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        Author = reader.GetString(reader.GetOrdinal("Author")),
                        ISBN = reader.GetString(reader.GetOrdinal("ISBN")),
                        PublishedYear = reader.GetInt32(reader.GetOrdinal("PublishedYear")),
                        Genre = reader.GetString(reader.GetOrdinal("Genre")),
                        Description = reader.GetString(reader.GetOrdinal("Description")),
                        ShelfID = reader.IsDBNull(reader.GetOrdinal("ShelfID")) ? null : reader.GetInt32(reader.GetOrdinal("ShelfID"))
                    });
                }
            }
            return books;
        }


    }
}
