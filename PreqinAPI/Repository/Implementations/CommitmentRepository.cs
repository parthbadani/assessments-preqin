using Common;
using Common.Models;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class CommitmentRepository : ICommitmentRepository
    {
        public async Task<List<Commitment>> GetCommitmentsByInvestorId(int investorId)
        {
            return await Task.FromResult(HardcodedData._commitments.Where(c => c.InvestorId == investorId).ToList());
        }
    }
}
