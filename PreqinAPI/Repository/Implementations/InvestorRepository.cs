using Common;
using Common.Models;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class InvestorRepository : IInvestorRepository
    {
        public async Task<List<Investor>> GetInvestors()
        {
            return await Task.FromResult(HardcodedData._investors);
        }
    }
}
