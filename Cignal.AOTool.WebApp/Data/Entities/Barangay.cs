using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cignal.AOTool.WebApp.Data.Entities
{
    public class Barangay 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarangayId { get; set; }

        [Required,MaxLength(50)]
        public string BarangayNo { get; set;}

        [Required]
        public string BarangayName { get; set; }

        [Required]
        public string SystemName { get; set; }

        [Required]
        public int ZipCode { get; set; }  
        public City City { get; set; }
        
    }
}