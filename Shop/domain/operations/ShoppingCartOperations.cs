using Shop.domain.models;
using static Shop.domain.models.ShoppingCart;

namespace Shop.domain.operations
{
    public static class ShoppingCartOperations
    {
        public static IShoppingCart ValidateShoppingCart(UnvalidatedShoppingCart ShoppingCart)
        {
            List<ValidatedProduct> ValidProducts = new();
            Contact? ValidContact = null;
            bool IsValid = true;
            String InvalidReason = String.Empty;

            foreach (var UnvalidatedProduct in ShoppingCart.Products)
            {
                if (!Product.TryParse(UnvalidatedProduct.Code, UnvalidatedProduct.Quantity, out var ParsedProduct))
                {
                    InvalidReason = $"Invalid Product format: ({UnvalidatedProduct.Code}, {UnvalidatedProduct.Quantity})";
                    Console.WriteLine(InvalidReason);
                    IsValid = false;
                    break;
                }

                ValidatedProduct ValidProduct = new ValidatedProduct(ParsedProduct.ResultCode, ParsedProduct.ResultQuantity);
                ValidProducts.Add(ValidProduct);
            }
            if (!Contact.TryParse(ShoppingCart.Contact.FirstName ?? String.Empty,
             ShoppingCart.Contact.LastName ?? String.Empty,
             ShoppingCart.Contact.TelephoneNumber ?? String.Empty,
             ShoppingCart.Contact.Address ?? String.Empty,
             out Contact? ParsedContact))
            {
                InvalidReason = $"Invalid Contact format: ({ShoppingCart.Contact.FirstName}, {ShoppingCart.Contact.LastName}, {ShoppingCart.Contact.TelephoneNumber}, {ShoppingCart.Contact.Address})";
                Console.WriteLine(InvalidReason);
                IsValid = false;
            }

            ValidContact = ParsedContact;

            if (IsValid)
            {
                return new ValidShoppingCart(ValidProducts, ValidContact!);
            }
            else
            {
                return new InvalidShoppingCart(ShoppingCart.Products, ShoppingCart.Contact, InvalidReason);
            }
        }

        // public static CalculateFinalPrice CalculateFinalPrice(ValidShoppingCart ShoppingCart)
        // {
        //     int FinalPrice = 0;
        //     foreach (ValidatedProduct Product in ShoppingCart.Products)
        //     {
        //         FinalPrice += Product.Price * Product.Quantity;
        //     }
        //     return new CalculatedShoppingCart(ShoppingCart.Products, FinalPrice);
        // }

        // public static IShoppingCart FinishOrder(ValidShoppingCart ValidShoppingCart)
        // {

        // }
    }
}