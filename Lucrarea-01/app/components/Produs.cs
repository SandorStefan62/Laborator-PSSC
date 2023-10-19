using static app.components.Quantity;

namespace app.components
{
    public record Produs
    {
        public String? Cod { get; init; }
        public IQuantity? Cantitate { get; init; }
    }
}