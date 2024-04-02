using System.ComponentModel.DataAnnotations;

namespace SariRasaWeb.Models
{
    public class MCustomer
    {
        [Key]
        public string KDCUS { get; set; }
        public string NMCUS { get; set; }
        public string? ALAMAT { get; set; }
        public string? KOTA { get; set; }
        public string? TEL1A { get; set; }
        public string? TEL1B { get; set; }
        public string? NOMHP { get; set; }
        public string? TIPEC { get; set; }
        public string? NOMBR { get; set; }
        public string? AKTIF { get; set; }
        public string? KETER { get; set; }
        public DateTime? UPDDT { get; set; }
        public string? USRID { get; set; }
        public string? KTP { get; set; }
        public DateTime? TGLHR { get; set; }
        public DateTime? TGMBR { get; set; }
        public string? UserName { get; set; }
        public string? UserPass { get; set; }
    }
}
