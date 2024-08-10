using Common.Models;

namespace Service.Interfaces
{
    public interface ICommitmentService
    {
        public Task<List<Commitment>> GetCommitmentsByAssetClass(string assetClass);

        public Task<List<Commitment>> GetCommitmentsByInvestor(int investorId);
    }
}
