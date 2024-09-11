using System.ComponentModel.DataAnnotations;

namespace NewsCenter.Models
{
    //haber eklerken kategori seçerken pozitif değere sahip bir seçeneği seçerek gönderilebilmesi için bu özel attributeyi yazdım. projeyi test etme aşamasında karşılaştığım bir sorun üzerine buna ihtiyac duydum ve chatgptden bu yöntemi öğrendim.
    public class PositiveNumberAttribute : ValidationAttribute
    {
            public override bool IsValid(object value)
            {
                if (value is int intValue)
                {
                    return intValue > 0;
                }
                return false;
            }
        }
}
