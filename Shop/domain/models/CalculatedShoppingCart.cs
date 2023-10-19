namespace Shop.domain.models
{
    public record CalculatedShoppingCart(List<ValidatedProduct> Products, int TotalPrice);
}