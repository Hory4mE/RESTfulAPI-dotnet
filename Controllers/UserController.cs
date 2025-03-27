using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        var user = new { Id = id, Name = "John Doe", Email = "john@example.com" };
        return Ok(user);
    }
}
