using Common.Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    public class InvestorService : IInvestorService
    {
        private readonly IInvestorRepository _investorRepository;

        public InvestorService(IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }

        public async Task<List<Investor>> GetInvestors()
        {
            return await _investorRepository.GetInvestors();
        }
    }
}
