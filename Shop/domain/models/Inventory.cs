using System.Text;

namespace Shop.domain.models
{
    public record Inventory
    {
        public Inventory(List<Product> Products)
        {
            this.Products = Products;
        }
        public override string ToString()
        {
            StringBuilder Builder = new StringBuilder();
            foreach (Product Product in this.Products)
            {
                Builder.Append($"[{Product.Code} {Product.Quantity}]\n");
            }
            return Builder.ToString();
        }
        public bool CheckProductAvailability(Product Product)
        {
            foreach (Product product in this.Products)
            {
                if (product.Code!.Equals(Product.Code))
                {
                    return true;
                }
            }
            return false;
        }
        public void CheckProductQuantity(String Code)
        {
            foreach (Product Product in this.Products)
            {
                if (Product.Code!.Equals(Code))
                {
                    Console.WriteLine(Product.Quantity!.ToString());
                }
            }
        }
        public List<Product> Products { get; init; }
    }
}