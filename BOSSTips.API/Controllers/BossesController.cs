using System;
using System.Threading.Tasks;
using BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss;
using BOSSTips.Application.Models.RequestModels.QueryRequestModels.Boss;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BOSSTips.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BossesController : ControllerBase
    {
        private readonly IMediator mediator;

        public BossesController(IMediator mediator) => this.mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllBossesRequestModel requestModel)
        {
            try
            {
                var responseModel = await mediator.Send(requestModel);

                return Ok(responseModel);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetBossByIdRequestModel requestModel)
        {
            try
            {
                var responseModel = await mediator.Send(requestModel);

                return Ok(responseModel);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddBossRequestModel requestModel)
        {
            try
            {
                var responseModel = await mediator.Send(requestModel);

                return Ok($"Boss created successfully\nId: {responseModel.Id}");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateBossRequestModel requestModel)
        {
            try
            {
                await mediator.Send(requestModel);

                return Ok("Boss updated successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteBossRequestModel requestModel)
        {
            try
            {
                await mediator.Send(requestModel);

                return Ok("Boss deleted successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
