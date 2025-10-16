using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCRM.Models
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "char(13)")]
        public string? staff_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public required string username { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? Role { get; set; }

        [Column(TypeName = "char(1)")]
        public string? active { get; set; }
    }
}
