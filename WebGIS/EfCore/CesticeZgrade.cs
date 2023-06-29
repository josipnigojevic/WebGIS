using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGIS.EfCore
{
    public class CesticeZgrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? ZgradaId { get; set; }
        public string? CesticaId { get; set; }
    }
}
