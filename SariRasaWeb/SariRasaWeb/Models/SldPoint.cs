using System.ComponentModel.DataAnnotations;

namespace SariRasaWeb.Models
{
    public class SldPoint
    {
        [Key]
        public string? NOMBR { get; set; }
        public int? POINT { get; set; }
    }
}
