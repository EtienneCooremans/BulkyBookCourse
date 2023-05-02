using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        // all the rows for the catergory table
        [Key] // The field below is a primay key
        public int Id { get; set; } // primary key
        [Required] // The field below is required
        public string Name { get; set; } // name category
        public int DisplayOrder { get; set; } // determines which category is shown first
    }
}
