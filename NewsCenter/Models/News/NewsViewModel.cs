using System.ComponentModel.DataAnnotations;

namespace NewsCenter.Models
{
    public class NewsViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Haber başlığı zorunludur")]
        public string Header { get; set; }
        [Required(ErrorMessage = "Haber sıra no zorunludur")]
        public int SortNumber { get; set; }
        [Required(ErrorMessage = "Haber içeriği zorunludur")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Yayınlama tarihi zorunludur")]
        public DateTime? PublishDate { get; set; }
        public string? ImageURL { get; set; }
        public bool Active { get; set; }
        public int AppUserID { get; set; }
        [Required(ErrorMessage = "Haber kategorisi zorunludur")]
        [PositiveNumber(ErrorMessage = "Haber kategorisi zorunludur")]
        public int CategoryID { get; set; }

    }
}
