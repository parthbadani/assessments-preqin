
using Common.Models;

namespace Repository.Interfaces
{
    public interface ICommitmentRepository
    {
        public Task<List<Commitment>> GetCommitmentsByInvestorId(int investorId);
    }
}
