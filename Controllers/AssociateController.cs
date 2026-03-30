using DBFirst.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateController : ControllerBase
    {
        private readonly IAssociateRepository _associateRepository;
        public AssociateController(IAssociateRepository associate)
        {
            this._associateRepository = associate;
        }

        [HttpGet("GetAllAssociates")]
        public async Task<IActionResult> GetAllAssociates()
        {
            var associates = await this._associateRepository.GetAllAssociatesAsync();
            if(associates==null || associates.Count()==0)
            {
                return NotFound("No associates found.");
            }
            return Ok(associates);
        }
    }
}
