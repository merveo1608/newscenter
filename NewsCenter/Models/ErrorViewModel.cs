using Org.BouncyCastle.Bcpg;

namespace NewsCenter.Models
{
    public class ErrorViewModel
    {
        //hata y�netimi i�in a�?lm??t?r. B�ylece hatalar?n sorunlar?n daha kolay ��z�lmesin? sa?lar.
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
