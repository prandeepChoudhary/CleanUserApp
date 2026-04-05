using CleanUserApp.Application.Interfaces;
using CleanUserApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanUserApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UsersController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _repo.GetAllAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            var id = await _repo.AddAsync(user);
            return Ok(new { Id = id });
        }
    }
}