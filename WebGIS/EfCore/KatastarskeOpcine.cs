using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGIS.EfCore
{
    public class KatastarskeOpcine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string? MaticniBrojKo { get; set; }
        public string? NazivKo { get; set; }
        public string? IzvornoMjerilo { get; set; }
        public string? StatusKzKn { get; set; }
        public string? KatastarskaOpcinaId { get; set; }
        public string? VrstaKatastarskeOpcine { get; set; }
        public string? Coordinates { get; set; }
    }
}
