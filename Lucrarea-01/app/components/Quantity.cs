using CSharp.Choices;

namespace app.components
{
    [AsChoice]
    public static class Quantity
    {
        public interface IQuantity { };
        public record Units(int number) : IQuantity;
        public record Kilograms(double numberOfKg) : IQuantity;
        public record Undefined(string undefined) : IQuantity;
    }
}