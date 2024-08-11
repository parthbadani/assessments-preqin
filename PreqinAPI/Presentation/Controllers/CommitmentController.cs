using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommitmentController : ControllerBase
    {
        private readonly ICommitmentService _commitmentService;

        public CommitmentController(ICommitmentService commitmentService)
        {
            _commitmentService = commitmentService;
        }

        [HttpGet("by-investor/{investorId}")]
        public async Task<ActionResult<List<Commitment>>> GetCommitmentsByInvestor(int investorId)
        {
            return await _commitmentService.GetCommitmentsByInvestor(investorId);
        }
    }
}
