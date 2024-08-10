using Common.Models;

namespace Service.Interfaces
{
    public interface IInvestorService
    {
        public Task<List<Investor>> GetInvestors();

        public Task<Investor> GetInvestor(int id);
    }
}
