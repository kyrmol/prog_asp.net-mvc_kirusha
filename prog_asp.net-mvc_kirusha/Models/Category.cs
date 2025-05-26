using System.ComponentModel.DataAnnotations;

namespace prog_asp.net_mvc_kirusha.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
