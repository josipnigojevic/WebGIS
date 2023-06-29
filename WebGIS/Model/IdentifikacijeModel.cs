using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGIS.Model
{
    public class IdentifikacijeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? MaticniBrojKo { get; set; }
        public string? Verificirano { get; set; }
        public string? ZkCesticaId { get; set; }
        public string? BrojZkCestice { get; set; }
        public string? PodbrojZkCestice { get; set; }
        public string? GlavnaKnjigaId { get; set; }
        public string? OznakaVezeCestice { get; set; }
        public string? OznakaVezeZkCestice { get; set; }
        public string? BrojCestice { get; set; }
        public string? CesticaId { get; set; }
        public string? Coordinates { get; set; }
    }
}
