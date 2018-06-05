namespace CSharpReview
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}