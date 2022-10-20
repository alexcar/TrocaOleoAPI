namespace Shared.RequestFeatures
{
    public class ProductParameters : RequestParameters
    {
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string SearchTerm { get; set; }

        public bool ValidPriceRange()
        {
            if (MaxPrice < MinPrice)
                return false;
            else
                return true;
        }
    }
}
