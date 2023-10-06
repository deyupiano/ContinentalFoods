﻿using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
    }
}
