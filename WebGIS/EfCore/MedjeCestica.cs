using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGIS.EfCore
{
    public class MedjeCestica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? MaticniBrojKo { get; set; }
        public string? MedjaCesticeId { get; set; }
        public string? Broj { get; set; }
        public string? Coordinates { get; set; }
    }
}
