using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eBooksWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Enter Category Name")]
        [MaxLength(30)]
        public string? Name { get; set; }
        [DisplayName ("Enter Display Order Number")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }

    }
}
