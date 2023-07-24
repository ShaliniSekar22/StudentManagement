using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studentwebapi.database;
using Studentwebapi.Models;

namespace Studentwebapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StudentController : ControllerBase
  {
    private readonly StudentDBContext StudentDBContext;
    public StudentController(StudentDBContext studentDBcontext)
    {
      this.StudentDBContext = studentDBcontext;
    }
    [HttpPost]
    public async Task<IActionResult> CreateStudent([FromBody]Students stu)
    {
      stu.Id = new Guid();
      await StudentDBContext.Student.AddAsync(stu);
      await StudentDBContext.SaveChangesAsync();
      return Ok(stu);
      
    }
  }
}
