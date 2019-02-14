namespace GENERICS
{
    // where T : IComparable
    // where T : Product
    // where T : Struct
    // where T : Class
    // where T : new()

    public class DiscountCalculate<TProdut > where TProdut : Product
    {
        public float CalculateDiscount(TProdut produt)
        {
          
           return produt.Price;
        }
    }
}

