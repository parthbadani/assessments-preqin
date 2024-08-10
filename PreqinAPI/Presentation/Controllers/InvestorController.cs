using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private readonly IInvestorService _investorService;

        public InvestorController(IInvestorService investorService)
        {
            _investorService = investorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Investor>>> GetInvestors()
        {
            return await _investorService.GetInvestors();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Investor>> GetInvestor(int id)
        {
            var investor = await _investorService.GetInvestor(id);
            if (investor == null)
            {
                return NotFound();
            }

            return investor;
        }
    }
}
