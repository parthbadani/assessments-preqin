using Common.Models;

namespace Common
{
    public static class HardcodedData
    {
        public static List<Commitment> _commitments = new List<Commitment>
            {
                new Commitment { Id = 12138, AssetClass = "Hedge Funds", Currency = "INR", Amount = 9.3, InvestorId = 332 },
                new Commitment { Id = 15358, AssetClass = "Private Equity", Currency = "INR", Amount = 10.5, InvestorId = 332 },
                new Commitment { Id = 27817, AssetClass = "Infrastructure", Currency = "USD", Amount = 3.7, InvestorId = 2670 },
                new Commitment { Id = 29147, AssetClass = "Real Estate", Currency = "USD", Amount = 2.4, InvestorId = 2670 },
                new Commitment { Id = 29771, AssetClass = "Natural Resources", Currency = "GBP", Amount = 3.9, InvestorId = 2792 },
                new Commitment { Id = 34300, AssetClass = "Infrastructure", Currency = "GBP", Amount = 3.1, InvestorId = 3611 }
            };

        public static List<Investor> _investors = new List<Investor>
        {
            new Investor { Id = 332, Name = "Parah Parikg fund", Type = "Wealth Manager", DateAdded = new DateTime(2002, 5, 29), Address = "11 Kasturba Road, Bangalore", TotalCommitment = 19.8, Currency = "INR" },
            new Investor { Id = 2670, Name = "Goldmas Sachn", Type = "Bank", DateAdded = new DateTime(2010, 6, 8), Address = "60 E 42nd Street, New York", TotalCommitment = 6.1, Currency = "USD" },
            new Investor { Id = 2792, Name = "Ibx Skywalker ltd", Type = "Asset Manager", DateAdded = new DateTime(1997, 7, 21), Address = "10 Bressenden Place, London", TotalCommitment = 3.9, Currency = "GBP" },
            new Investor { Id = 3611, Name = "Ioo Gryffindor fund", Type = "Fund Manager", DateAdded = new DateTime(2000, 7, 6), Address = "2 Colmore Square, Birmingham", TotalCommitment = 3.1 , Currency = "GBP" }
        };

    }
}
