using Shop.domain.commands;
using Shop.domain.models;
using Shop.domain.workflows;
using static Shop.domain.models.Quantity;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var OrderProducts = new List<UnvalidatedProduct> {
                new UnvalidatedProduct("123", "12"),
                new UnvalidatedProduct("124", "11")
            };
            var Products = new List<Product> {
                new Product("111", new Units(int.Parse("100"))),
                new Product("222", new Units(int.Parse("200")))
            };
            Contact Contact = new Contact("abc", "abc", "1234567891", "abcasdasd");
            ShoppingCartCommand Command = new ShoppingCartCommand(OrderProducts, Contact);
            Inventory Inventory = new Inventory(Products);

            ShoppingCartWorkflow Workflow = new ShoppingCartWorkflow();
            Workflow.Execute(Command);

            //verificarea produsului dupa cod
            Product Product = new Product("111", new Units(int.Parse("100")));
            bool check = Inventory.CheckProductAvailability(Product);

            //verificarea stocului
            Inventory.CheckProductQuantity("222");

            //verificarea adresei de livrare
            Contact.CheckAddress();

            //CALCULAREA PRETULUI am uitat sa adaug campul pret la produs; mi-am adus aminte chiar la final si nu am mai vrut sa modific intreg codul; am scris intr-un comentariu cum arata functia
        }
    }
}