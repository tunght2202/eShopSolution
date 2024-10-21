﻿using eShopSolution.Application.System.Users;
using eShopSolution.ViewModels.Catelog.Product;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authentication([FromBody] LoginRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.Authencate(request);
            if(string.IsNullOrEmpty(result.ResultObj))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.Register(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Update(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // http://localhost//api/users/paging?pageIndex=1&pageSieze=10&keyword=10
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetUserPagingRequest request)
        {
            var products = await _userService.GetUsersPaging(request);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userService.GetById(id);
            return Ok(user);
        }
    }
}
