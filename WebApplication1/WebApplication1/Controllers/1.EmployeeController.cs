using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]


    public class EmployeeController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            // Sample data for demonstration purposes
            var employee = new
            {
                Id = id,
                Name = "John Doe",
                Position = "Software Developer"
            };
            return Ok(employee);
        }
    }
}
