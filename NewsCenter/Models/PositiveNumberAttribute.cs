using System.ComponentModel.DataAnnotations;

namespace NewsCenter.Models
{
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
