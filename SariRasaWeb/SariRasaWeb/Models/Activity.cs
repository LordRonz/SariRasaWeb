namespace SariRasaWeb.Models
{
    public class Activity(string tanggal, string keterangan, int point)
    {
        public string Tanggal { get; set; } = tanggal;
        public string Keterangan { get; set; } = keterangan;
        public int Point { get; set; } = point;
    }
}