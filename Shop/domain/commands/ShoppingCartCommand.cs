using Shop.domain.models;

namespace Shop.domain.commands
{
    public record ShoppingCartCommand
    {
        public ShoppingCartCommand(List<UnvalidatedProduct> UnvalidatedProducts, Contact Contact)
        {
            this.UnvalidatedProducts = UnvalidatedProducts;
            this.Contact = Contact;
        }

        public List<UnvalidatedProduct> UnvalidatedProducts { get; init; }
        public Contact Contact { get; init; }
    }
}