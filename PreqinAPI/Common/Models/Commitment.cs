namespace Common.Models
{
    public class Commitment
    {
        public int Id { get; set; }
        public string AssetClass { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }

        public int InvestorId { get; set; }
    }
}
