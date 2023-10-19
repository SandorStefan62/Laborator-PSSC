using Shop.domain.exceptions;
using static Shop.domain.models.Quantity;

namespace Shop.domain.models
{
    public record Product
    {
        public String? Code { get; init; }
        public IQuantity? Quantity { get; init; }

        public Product(String Code, IQuantity Quantity)
        {
            this.Code = Code;
            this.Quantity = Quantity;
        }

        public static bool TryParse(String CodeString, String QuantityString, out (String ResultCode, IQuantity ResultQuantity) result)
        {
            bool IsValid = false;
            result = (String.Empty, new Undefined(String.Empty));

            if (!CodeString.Any(char.IsLetter))
            {
                IQuantity ParsedQuantity;
                if (!QuantityString.Any(char.IsLetter))
                {
                    if (int.TryParse(QuantityString, out int NumericQuantity))
                    {
                        ParsedQuantity = new Units(NumericQuantity);
                    }
                    else
                    {
                        ParsedQuantity = new Undefined(QuantityString);
                    }
                    result = (CodeString, ParsedQuantity);
                    IsValid = true;
                }
            }

            return IsValid;
        }
    }
}