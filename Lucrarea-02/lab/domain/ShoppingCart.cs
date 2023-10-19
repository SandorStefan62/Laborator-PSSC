using CSharp.Choices;

namespace lab.domain
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart { }

        public record EmptyShoppingCart(List<Product> Products) : IShoppingCart;
        public record InvalidShoppingCart(List<Product> Products) : IShoppingCart;
        public record ValidShoppingCart(List<Product> Products) : IShoppingCart;
        public record PayedShoppingCart(List<Product> Products) : IShoppingCart;


    }
}