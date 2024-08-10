namespace Common.Models
{
    public class Investor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUpdated { get; set; }
        public double TotalCommitment { get; set; }
        public string Currency { get; set; }
    }
}
