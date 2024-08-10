using Common.Models;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class InvestorRepository : IInvestorRepository
    {
        public List<Investor> _hardcodedInvestors = new List<Investor>
        {
            new Investor { Id = 332, Name = "Parah Parikg fund", Type = "Wealth Manager", DateAdded = new DateTime(2002, 5, 29), Address = "11 Kasturba Road, Bangalore", TotalCommitment = 19.8, Currency = "INR" },
            new Investor { Id = 2670, Name = "Goldmas Sachn", Type = "Bank", DateAdded = new DateTime(2010, 6, 8), Address = "60 E 42nd Street, New York", TotalCommitment = 6.1, Currency = "USD" },
            new Investor { Id = 2792, Name = "Ibx Skywalker ltd", Type = "Asset Manager", DateAdded = new DateTime(1997, 7, 21), Address = "10 Bressenden Place, London", TotalCommitment = 3.9, Currency = "GBP" },
            new Investor { Id = 3611, Name = "Ioo Gryffindor fund", Type = "Fund Manager", DateAdded = new DateTime(2000, 7, 6), Address = "2 Colmore Square, Birmingham", TotalCommitment = 3.1 , Currency = "GBP" }
        };

        public async Task<List<Investor>> GetInvestors()
        {
            return await Task.FromResult(_hardcodedInvestors);
        }

        public async Task<Investor> GetInvestor(int id)
        {
            Investor investor = _hardcodedInvestors.FirstOrDefault(i => i.Id == id);
            return await Task.FromResult(investor);
        }
    }
}
