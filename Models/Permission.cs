using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCRM.Models
{
    public class Permission
    {
        [Key]
        [Column(TypeName = "char(13)")]
        public string? staff_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public required string username { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? Role { get; set; }

        public int level { get; set; }

        [StringLength(1)]
        public required string active { get; set; }
    }
}
