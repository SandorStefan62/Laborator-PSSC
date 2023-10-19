using CSharp.Choices;

namespace Shop.domain.models
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart { }
        public record EmptyShoppingCart : IShoppingCart
        {
            public EmptyShoppingCart()
            {
            }

            public EmptyShoppingCart(List<Product> Products, Contact Contact)
            {
                this.Products = new List<Product>();
                this.Contact = Contact;
            }
            public List<Product>? Products { get; init; }
            public Contact? Contact { get; init; }
        };
        public record UnvalidatedShoppingCart : IShoppingCart
        {
            public UnvalidatedShoppingCart(List<UnvalidatedProduct> Products, Contact Contact)
            {
                this.Products = Products;
                this.Contact = Contact;
            }
            public List<UnvalidatedProduct> Products { get; init; }
            public Contact Contact { get; init; }
        };
        public record InvalidShoppingCart : IShoppingCart
        {
            public InvalidShoppingCart(List<UnvalidatedProduct> Products, Contact Contact, String Reason)
            {
                this.Products = Products;
                this.Contact = Contact;
                this.Reason = Reason;
            }
            public List<UnvalidatedProduct> Products { get; init; }
            public Contact Contact { get; init; }
            public String Reason { get; init; }
        };
        public record ValidShoppingCart : IShoppingCart
        {
            public ValidShoppingCart(List<ValidatedProduct> Products, Contact Contact)
            {
                this.Products = Products;
                this.Contact = Contact;
            }
            public List<ValidatedProduct> Products { get; init; }
            public Contact Contact { get; init; }
        };
        public record PaidShoppingCart : IShoppingCart
        {
            public PaidShoppingCart(List<ValidatedProduct> Products, Contact Contact, DateTime CheckoutDate)
            {
                this.Products = Products;
                this.Contact = Contact;
                this.CheckoutDate = CheckoutDate;
            }
            public List<ValidatedProduct> Products { get; init; }
            public Contact Contact { get; init; }
            public DateTime CheckoutDate { get; init; }
        };
    }
}