namespace Shop.domain.models
{
    public record Order
    {
        public Contact? Contact { get; init; }
        public List<Product> Products { get; init; } = new List<Product>();
    }
}