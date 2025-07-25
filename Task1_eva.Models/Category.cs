using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1_eva.Models
{
    [Table("Categories", Schema = "MasterSchema")]
    public class Category
    {
        // [Key]
        public int Id { get; set; }

        // [Required]
        // [MaxLength(50)]
        public string CatName { get; set; }

        // [Required]
        public int CatOrder { get; set; }

        // [NotMapped]
        public DateTime CreatedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
