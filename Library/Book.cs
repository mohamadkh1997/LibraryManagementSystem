using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public string Genre { get; set; }

        public string Description { get; set; }
        public int? ShelfID { get; set; }  // Nullable to handle cases where no shelf is assigned

        // Navigation property to represent the relationship to Shelf
        public Shelf Shelf { get; set; }

        // Constructor
        public Book() { }
    }
}
