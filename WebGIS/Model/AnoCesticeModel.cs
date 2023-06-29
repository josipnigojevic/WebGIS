using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGIS.Model
{
    public class AnoCesticeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? MaticniBrojKo { get; set; }
        public string? Rotacija { get; set; }
        public string? AnoCesticaId { get; set; }
        public string? BrojCestice { get; set; }
        public string? Coordinates { get; set; }
    }
}
