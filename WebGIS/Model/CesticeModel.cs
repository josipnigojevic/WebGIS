using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGIS.Model
{
    public class CesticeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? MaticniBrojKo { get; set; }
        public string? CesticaId { get; set; }
        public string? BrojCestice { get; set; }
        public string? PovrsinaAtributna { get; set; }
        public string? PovrsinaGraficka { get; set; }
        public string? AdresaOpisna { get; set; }
        public string? StatusCestice { get; set; }
        public string? StatusKzKn {get; set; }
        public string? CesticaIzvorId { get; set; }
        public string? OznakaOkoline { get; set; }
        public string? DetaljniList { get; set; }
        public string? IzvornoMjerilo { get; set; }
        public string? Coordinates { get; set; }
    }
}
