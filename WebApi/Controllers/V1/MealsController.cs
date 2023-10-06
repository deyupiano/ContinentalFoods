using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.WebApi.Contracts.Meals.Requests;
using ContinentalFoods.WebApi.Contracts.Meals.Responses;
using Microsoft.VisualBasic;
using System.IO;
using HttpStatusCodeEnum = System.Net.HttpStatusCode;

namespace ContinentalFoods.WebApi.Controllers.V1
{
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class MealsController: BaseController
    {
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        public async Task<IActionResult> GetAllMeals(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllMeals(), cancellationToken);
            //var mapped = _mapper.Map<List<MealResponse>>(result.Payload);
            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors): new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        [Route(ApiRoutes.Meals.Random)]
        public async Task<IActionResult> GetRandomMeals(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetRandomMeals(), cancellationToken);
            //var mapped = _mapper.Map<List<MealResponse>>(result.Payload);
            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors) : new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };

        }
        [HttpGet]
        [Route(ApiRoutes.Meals.IdRoute)]
        [ValidateGuid("id")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
        {
            var idMeal = Guid.Parse(id);
            var query = new GetMealById() { IdMeal = idMeal };
            var result = await _mediator.Send(query, cancellationToken);
            //var mapped = _mapper.Map<MealResponse>(result.Payload);

            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors) : new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }
        [HttpGet]
        [Route(ApiRoutes.Meals.Letter)]
        //[ValidateGuid("letter")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        public async Task<IActionResult> GetMealsByFirstLetter(string letter, CancellationToken cancellationToken)
        {
            var query = new GetMealsByFirstLetter() { Letter = letter };
            var result = await _mediator.Send(query, cancellationToken);
            //var mapped = _mapper.Map<MealResponse>(result.Payload);

            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors) : new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }
        [HttpGet]
        [Route(ApiRoutes.Meals.Ingredient)]
        //[ValidateGuid("ingredient")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        public async Task<IActionResult> GetMealsByIngredient(string ingredient, CancellationToken cancellationToken)
        {
            var query = new GetMealsByIngredient() { Ingredient = ingredient };
            var result = await _mediator.Send(query, cancellationToken);
            //var mapped = _mapper.Map<MealResponse>(result.Payload);

            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok(mapped);
            return result.IsError ? HandleErrorResponse(result.Errors) : new JsonResult(result.Payload) { StatusCode = (int)HttpStatusCodeEnum.OK };
        }
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MealResponse), 200)]
        [ValidateModel]
        public async Task<IActionResult> CreateMeal([FromBody] MealCreate newMeal, CancellationToken cancellationToken)
        {
            var identityId = HttpContext.GetIdentityIdClaimValue();

            var command = new CreateMeal()
            {
                IdentityId = identityId.ToString(),
                StrMeal = newMeal.StrMeal,
                StrCategory = newMeal.StrCategory,
                StrArea = newMeal.StrArea,
                StrInstructions = newMeal.StrInstructions,
                StrMealThumb = newMeal.StrMealThumb,
                StrTags = newMeal.StrTags,
                StrYoutube = newMeal.StrYoutube,
                StrIngredient1 = newMeal.StrIngredient1,
                StrIngredient2 = newMeal.StrIngredient2,
                StrIngredient3 = newMeal.StrIngredient3,
                StrIngredient4 = newMeal.StrIngredient4,
                StrIngredient5 = newMeal.StrIngredient5,
                StrIngredient6 = newMeal.StrIngredient6,
                StrIngredient7 = newMeal.StrIngredient7,
                StrIngredient8 = newMeal.StrIngredient8,
                StrIngredient9 = newMeal.StrIngredient9,
                StrIngredient10 = newMeal.StrIngredient10,
                StrIngredient11 = newMeal.StrIngredient11,
                StrIngredient12 = newMeal.StrIngredient12,
                StrIngredient13 = newMeal.StrIngredient13,
                StrIngredient14 = newMeal.StrIngredient14,
                StrIngredient15 = newMeal.StrIngredient15,
                StrIngredient16 = newMeal.StrIngredient16,
                StrIngredient17 = newMeal.StrIngredient17,
                StrIngredient18 = newMeal.StrIngredient18,
                StrIngredient19 = newMeal.StrIngredient19,
                StrIngredient20 = newMeal.StrIngredient20,
                StrIngredient21 = newMeal.StrIngredient21,
                StrIngredient22 = newMeal.StrIngredient22,
                StrIngredient23 = newMeal.StrIngredient23,
                StrIngredient24 = newMeal.StrIngredient24,
                StrIngredient25 = newMeal.StrIngredient25,
                StrIngredient26 = newMeal.StrIngredient26,
                StrIngredient27 = newMeal.StrIngredient27,
                StrIngredient28 = newMeal.StrIngredient28,
                StrIngredient29 = newMeal.StrIngredient29,
                StrIngredient30 = newMeal.StrIngredient30,
                StrMeasure1 = newMeal.StrMeasure1,
                StrMeasure2 = newMeal.StrMeasure2,
                StrMeasure3 = newMeal.StrMeasure3,
                StrMeasure4 = newMeal.StrMeasure4,
                StrMeasure5 = newMeal.StrMeasure5,
                StrMeasure6 = newMeal.StrMeasure6,
                StrMeasure7 = newMeal.StrMeasure7,
                StrMeasure8 = newMeal.StrMeasure8,
                StrMeasure9 = newMeal.StrMeasure9,
                StrMeasure10 = newMeal.StrMeasure10,
                StrMeasure11 = newMeal.StrMeasure11,
                StrMeasure12 = newMeal.StrMeasure12,
                StrMeasure13 = newMeal.StrMeasure13,
                StrMeasure14 = newMeal.StrMeasure14,
                StrMeasure15 = newMeal.StrMeasure15,
                StrMeasure16 = newMeal.StrMeasure16,
                StrMeasure17 = newMeal.StrMeasure17,
                StrMeasure18 = newMeal.StrMeasure18,
                StrMeasure19 = newMeal.StrMeasure19,
                StrMeasure20 = newMeal.StrMeasure20,
                StrMeasure21 = newMeal.StrMeasure21,
                StrMeasure22 = newMeal.StrMeasure22,
                StrMeasure23 = newMeal.StrMeasure23,
                StrMeasure24 = newMeal.StrMeasure24,
                StrMeasure25 = newMeal.StrMeasure25,
                StrMeasure26 = newMeal.StrMeasure26,
                StrMeasure27 = newMeal.StrMeasure27,
                StrMeasure28 = newMeal.StrMeasure28,
                StrMeasure29 = newMeal.StrMeasure29,
                StrMeasure30 = newMeal.StrMeasure30
            };

            var result = await _mediator.Send(command, cancellationToken);
            //var mapped = _mapper.Map<MealResponse>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : CreatedAtAction(nameof(GetById), new { id = result.Payload.IdMeal }, (int)HttpStatusCodeEnum.OK);
            //return result.IsError ? HandleErrorResponse(result.Errors)
             //   : CreatedAtAction(nameof(GetById), new { id = result.Payload.IdMeal }, mapped);
        }

        [HttpPatch]
        [Route(ApiRoutes.Meals.UpateInstruction)]
        [ValidateGuid("id")]
        [ValidateModel]
        public async Task<IActionResult> UpdateMealInstruction([FromBody] MealInstructionUpdate updatedMeal, string id, CancellationToken cancellationToken)
        {
            var identityId = HttpContext.GetIdentityIdClaimValue();

            var command = new UpdateMealInstruction()
            {
                Instructions = updatedMeal.Instructions,
                IdMeal = Guid.Parse(id),
                IdentityId = identityId.ToString()
            };
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        }
        [HttpPatch]
        [Route(ApiRoutes.Meals.UpateMealBasicInfo)]
        [ValidateGuid("id")]
        [ValidateModel]
        public async Task<IActionResult> UpdateMealBasicInfo([FromBody] MealBasicInfoUpdate updatedMeal, string id, CancellationToken cancellationToken)
        {
            var identityId = HttpContext.GetIdentityIdClaimValue();

            var command = new UpdateMealBasicInfo()
            {
                StrMeal = updatedMeal.StrMeal,
                StrArea = updatedMeal.StrArea,
                StrCategory = updatedMeal.StrCategory,
                StrTags = updatedMeal.StrTags,
                IdMeal = Guid.Parse(id),
                IdentityId = identityId.ToString()
            };
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        }

        [HttpPatch]
        [Route(ApiRoutes.Meals.UpateIngredient)]
        [ValidateGuid("id")]
        [ValidateModel]
        public async Task<IActionResult> UpdateMealIngredients([FromBody] MealIngredientUpdate updatedMeal, string id, CancellationToken cancellationToken)
        {
            var identityId = HttpContext.GetIdentityIdClaimValue();

            var command = new UpdateMealIngrdients()
            {
                StrIngredient1 = updatedMeal.StrIngredient1,
                StrIngredient2 = updatedMeal.StrIngredient2,
                StrIngredient3 = updatedMeal.StrIngredient3,
                StrIngredient4 = updatedMeal.StrIngredient4,
                StrIngredient5 = updatedMeal.StrIngredient5,
                StrIngredient6 = updatedMeal.StrIngredient6,
                StrIngredient7 = updatedMeal.StrIngredient7,
                StrIngredient8 = updatedMeal.StrIngredient8,
                StrIngredient9 = updatedMeal.StrIngredient9,
                StrIngredient10 = updatedMeal.StrIngredient10,
                StrIngredient11 = updatedMeal.StrIngredient11,
                StrIngredient12 = updatedMeal.StrIngredient12,
                StrIngredient13 = updatedMeal.StrIngredient13,
                StrIngredient14 = updatedMeal.StrIngredient14,
                StrIngredient15 = updatedMeal.StrIngredient15,
                StrIngredient16 = updatedMeal.StrIngredient16,
                StrIngredient17 = updatedMeal.StrIngredient17,
                StrIngredient18 = updatedMeal.StrIngredient18,
                StrIngredient19 = updatedMeal.StrIngredient19,
                StrIngredient20 = updatedMeal.StrIngredient20,
                StrIngredient21 = updatedMeal.StrIngredient21,
                StrIngredient22 = updatedMeal.StrIngredient22,
                StrIngredient23 = updatedMeal.StrIngredient23,
                StrIngredient24 = updatedMeal.StrIngredient24,
                StrIngredient25 = updatedMeal.StrIngredient25,
                StrIngredient26 = updatedMeal.StrIngredient26,
                StrIngredient27 = updatedMeal.StrIngredient27,
                StrIngredient28 = updatedMeal.StrIngredient28,
                StrIngredient29 = updatedMeal.StrIngredient29,
                StrIngredient30 = updatedMeal.StrIngredient30,
                IdMeal = Guid.Parse(id),
                IdentityId = identityId.ToString()
            };
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        }

        [HttpPatch]
        [Route(ApiRoutes.Meals.UpateIngredientMeasure)]
        [ValidateGuid("id")]
        [ValidateModel]
        public async Task<IActionResult> UpdateMealIngredientMeasure([FromBody] MealIngredientMeasureUpdate updatedMeal, string id, CancellationToken cancellationToken)
        {
            var identityId = HttpContext.GetIdentityIdClaimValue();

            var command = new UpdateMealIngredientMeasure()
            {
                StrMeasure1 = updatedMeal.StrMeasure1,
                StrMeasure2 = updatedMeal.StrMeasure2,
                StrMeasure3 = updatedMeal.StrMeasure3,
                StrMeasure4 = updatedMeal.StrMeasure4,
                StrMeasure5 = updatedMeal.StrMeasure5,
                StrMeasure6 = updatedMeal.StrMeasure6,
                StrMeasure7 = updatedMeal.StrMeasure7,
                StrMeasure8 = updatedMeal.StrMeasure8,
                StrMeasure9 = updatedMeal.StrMeasure9,
                StrMeasure10 = updatedMeal.StrMeasure10,
                StrMeasure11 = updatedMeal.StrMeasure11,
                StrMeasure12 = updatedMeal.StrMeasure12,
                StrMeasure13 = updatedMeal.StrMeasure13,
                StrMeasure14 = updatedMeal.StrMeasure14,
                StrMeasure15 = updatedMeal.StrMeasure15,
                StrMeasure16 = updatedMeal.StrMeasure16,
                StrMeasure17 = updatedMeal.StrMeasure17,
                StrMeasure18 = updatedMeal.StrMeasure18,
                StrMeasure19 = updatedMeal.StrMeasure19,
                StrMeasure20 = updatedMeal.StrMeasure20,
                StrMeasure21 = updatedMeal.StrMeasure21,
                StrMeasure22 = updatedMeal.StrMeasure22,
                StrMeasure23 = updatedMeal.StrMeasure23,
                StrMeasure24 = updatedMeal.StrMeasure24,
                StrMeasure25 = updatedMeal.StrMeasure25,
                StrMeasure26 = updatedMeal.StrMeasure26,
                StrMeasure27 = updatedMeal.StrMeasure27,
                StrMeasure28 = updatedMeal.StrMeasure28,
                StrMeasure29 = updatedMeal.StrMeasure29,
                StrMeasure30 = updatedMeal.StrMeasure30,
                IdMeal = Guid.Parse(id),
                IdentityId = identityId.ToString()
            };
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        }
       
        
        
        
        
        
        //[HttpDelete]
        //[Route(ApiRoutes.Posts.IdRoute)]
        //[ValidateGuid("id")]
        //public async Task<IActionResult> DeletePost(string id, CancellationToken cancellationToken)
        //{
        //    var userProfileId = HttpContext.GetUserProfileIdClaimValue();
        //    var command = new DeletePost() { PostId = Guid.Parse(id), UserProfileId = userProfileId };
        //    var result = await _mediator.Send(command, cancellationToken);

        //    return result.IsError ? HandleErrorResponse(result.Errors) : NoContent();
        //}

        //[HttpGet]
        //[Route(ApiRoutes.Posts.PostComments)]
        //[ValidateGuid("postId")]
        //public async Task<IActionResult> GetCommentsByPostId(string postId, CancellationToken cancellationToken)
        //{
        //    var query = new GetPostComments() { PostId = Guid.Parse(postId) };
        //    var result = await _mediator.Send(query, cancellationToken);

        //    if (result.IsError) HandleErrorResponse(result.Errors);

        //    var comments = _mapper.Map<List<PostCommentResponse>>(result.Payload);
        //    return Ok(comments);
        //}
    }
}
