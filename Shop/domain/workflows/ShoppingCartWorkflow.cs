using Shop.domain.commands;

// using CSharp.Choices;
using static Shop.domain.models.ShoppingCart;
using static Shop.domain.operations.ShoppingCartOperations;

namespace Shop.domain.workflows
{
    public class ShoppingCartWorkflow
    {
        public void Execute(ShoppingCartCommand Command)
        {
            UnvalidatedShoppingCart UnvalidatedShoppingCart = new UnvalidatedShoppingCart(Command.UnvalidatedProducts, Command.Contact);
            IShoppingCart ShoppingCart = ValidateShoppingCart(UnvalidatedShoppingCart);
            Console.WriteLine(ShoppingCart.GetType());

            //cod final de verificare comanda valida sau nu... foarte pe scurt
            // if (ShoppingCart.GetType().ToString().Equals("Shop.domain.models.ShoppingCart+ValidShoppingCart"))
            // {
            //     Console.WriteLine("yes");
            // }
            // else
            // {
            //     Console.WriteLine("no");
            // }
        }
    }
}