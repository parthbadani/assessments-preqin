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
            var investors = await _investorService.GetInvestors();
            if (investors == null || investors.Count == 0)
            {
                return NotFound();
            }

            return Ok(investors);
        }
    }
}
