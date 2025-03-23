using System.ComponentModel.DataAnnotations;

namespace entityFramework.Data
{
    public class Ogrenci
    {
        [Key]
        public int KimlikNo { get; set; }
        public string? OgrenciAdi { get; set; }
        public string? OgrenciSoyadi { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

    }
}