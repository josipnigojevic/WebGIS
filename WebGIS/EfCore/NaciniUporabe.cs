using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGIS.EfCore
{
    public class NaciniUporabe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? NacinUporabeId { get; set; }
        public string? MaticniBrojKo { get; set; }
        public string? Povrsina { get; set; }
        public string? SifraVrsteUporabe { get; set; }
        public string? BrojCestice { get; set; }
        public string? NazivVrsteUporabe { get; set; }
        public string? AdresaOpisna { get; set; }
        public string? PosjedovniListBroj { get; set; }
        public string? CesticaId { get; set; }
        public string? StatusNacinaUporabe { get; set; }
        public string? OznakaPravaGradjenja { get; set; }
        public string? Coordinates { get; set; }
    }
}
