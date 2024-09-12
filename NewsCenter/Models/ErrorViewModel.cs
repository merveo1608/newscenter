using Org.BouncyCastle.Bcpg;

namespace NewsCenter.Models
{
    public class ErrorViewModel
    {
        //hata yönetimi için aç?lm??t?r. Böylece hatalar?n sorunlar?n daha kolay çözülmesin? sa?lar.
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
