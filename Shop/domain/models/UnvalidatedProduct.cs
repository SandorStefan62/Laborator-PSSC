using static Shop.domain.models.Quantity;

namespace Shop.domain.models
{
    public record UnvalidatedProduct(String Code, String Quantity);
}