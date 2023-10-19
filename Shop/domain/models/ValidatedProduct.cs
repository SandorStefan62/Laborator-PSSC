using static Shop.domain.models.Quantity;

namespace Shop.domain.models
{
    public record ValidatedProduct(String Code, IQuantity Quantity);
}