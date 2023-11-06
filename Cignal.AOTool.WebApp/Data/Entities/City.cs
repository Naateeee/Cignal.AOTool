using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cignal.AOTool.WebApp.Data.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        
        [Required,MaxLength(50)]
        public string CityName { get;set; }

        public ICollection<Barangay> Barangays { get; set; }
    }
}