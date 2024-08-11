using Common.Models;

namespace Service.Interfaces
{
    public interface ICommitmentService
    {
        public Task<List<Commitment>> GetCommitmentsByInvestor(int investorId);
    }
}
