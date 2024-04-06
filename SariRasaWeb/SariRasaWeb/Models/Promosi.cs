using System.ComponentModel.DataAnnotations;

namespace SariRasaWeb.Models
{
    public class MPromosi
    {
        [Key]
        public int? ID { get; set; }
        public DateTime? TGLAwal { get; set; }
        public DateTime? TGLAkhir { get; set; }
        public string? Promosi { get; set; }
        public int? Prioritas { get; set; }
    }
}
