using Common.Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    public class CommitmentService : ICommitmentService
    {
        private readonly ICommitmentRepository _commitmentRepository;

        public CommitmentService(ICommitmentRepository commitmentRepository)
        {
            _commitmentRepository = commitmentRepository;
        }

        public async Task<List<Commitment>> GetCommitmentsByInvestor(int investorId)
        {
            return await _commitmentRepository.GetCommitmentsByInvestorId(investorId);
        }
    }
}
