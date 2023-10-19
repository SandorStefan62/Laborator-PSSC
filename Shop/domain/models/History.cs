using static Shop.domain.models.ShoppingCart;

namespace Shop.domain.models
{
    public record History
    {
        public History(List<PaidShoppingCart> PaidShoppingCarts)
        {
            this.PaidShoppingCarts = PaidShoppingCarts;
        }
        public void AddCheckedOutOrder(PaidShoppingCart PaidShoppingCart)
        {
            this.PaidShoppingCarts!.Add(PaidShoppingCart);
        }
        public List<PaidShoppingCart>? PaidShoppingCarts { get; init; }
    };
}