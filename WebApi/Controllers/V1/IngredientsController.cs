using ContinentalFoods.Application.Ingredients.Commands;
using ContinentalFoods.Application.Ingredients.Queries;
using ContinentalFoods.WebApi.Contracts.Ingredients.Requests;
using ContinentalFoods.WebApi.Contracts.Ingredients.Responses;
using Microsoft.VisualBasic;
using System.IO;
using HttpStatusCodeEnum = System.Net.HttpStatusCode;

namespace ContinentalFoods.WebApi.Controllers.V1
{
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class IngredientsController : BaseController
    {
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IngredientResponse), 200)]
        public async Task<IActionResult> GetAllIngredients(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllIngredients(), cancellationToken);
            //var mapped = _mapper.Map<List<IngredientResponse>>(result.Payload);
            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors): new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }

        [HttpGet]
        [Route(ApiRoutes.Ingredients.IdRoute)]
        [ValidateGuid("id")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IngredientResponse), 200)]
        public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
        {
            var idIngredient = Guid.Parse(id);
            var query = new GetIngredientById() { IdIngredient = idIngredient };
            var result = await _mediator.Send(query, cancellationToken);
            //var mapped = _mapper.Map<IngredientResponse>(result.Payload);

            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors) : new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }
        
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IngredientResponse), 200)]
        [ValidateModel]
        public async Task<IActionResult> CreateIngredient([FromBody] IngredientCreate newIngredient, CancellationToken cancellationToken)
        {

            var command = new CreateIngredient()
            {
                StrIngredient = newIngredient.StrIngredient,
                StrDescription = newIngredient.StrDescription,
            };

            var result = await _mediator.Send(command, cancellationToken);
            //var mapped = _mapper.Map<IngredientResponse>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : CreatedAtAction(nameof(GetById), new { id = result.Payload.IdIngredient }, (int)HttpStatusCodeEnum.OK);
            //return result.IsError ? HandleErrorResponse(result.Errors)
             //   : CreatedAtAction(nameof(GetById), new { id = result.Payload.IdIngredient }, mapped);
        }

        [HttpPatch]
        [Route(ApiRoutes.Ingredients.UpateIngredient)]
        [ValidateGuid("id")]
        [ValidateModel]
        public async Task<IActionResult> UpdateIngredient([FromBody] IngredientUpdate updatedIngredient, string id, CancellationToken cancellationToken)
        {

            var command = new UpdateIngredient()
            {
                StrIngredient = updatedIngredient.StrIngredient,
                StrDescription = updatedIngredient.StrDescription,
                IdIngredient = Guid.Parse(id),
            };
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        }
        
    }
}
