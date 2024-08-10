using Common.Models;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class CommitmentRepository : ICommitmentRepository
    {
        List<Commitment> _hardcodedCommitments = new List<Commitment>
            {
                new Commitment { Id = 12138, AssetClass = "Hedge Funds", Currency = "INR", Amount = 9.3, InvestorId = 332 },
                new Commitment { Id = 15358, AssetClass = "Private Equity", Currency = "INR", Amount = 10.5, InvestorId = 332 },
                new Commitment { Id = 27817, AssetClass = "Infrastructure", Currency = "USD", Amount = 3.7, InvestorId = 2670 },
                new Commitment { Id = 29147, AssetClass = "Real Estate", Currency = "USD", Amount = 2.4, InvestorId = 2670 },
                new Commitment { Id = 29771, AssetClass = "Natural Resources", Currency = "GBP", Amount = 3.9, InvestorId = 2792 },
                new Commitment { Id = 34300, AssetClass = "Infrastructure", Currency = "GBP", Amount = 3.1, InvestorId = 3611 }
            };

        public async Task<List<Commitment>> GetCommitmentsByInvestorId(int investorId)
        {
            return await Task.FromResult(_hardcodedCommitments.Where(c => c.InvestorId == investorId).ToList());
        }

        public async Task<List<Commitment>> GetCommitmentsByAssetClass(string assetClass)
        {
            return await Task.FromResult(_hardcodedCommitments.Where(c => c.AssetClass.Equals(assetClass, StringComparison.OrdinalIgnoreCase)).ToList());
        }
    }
}
