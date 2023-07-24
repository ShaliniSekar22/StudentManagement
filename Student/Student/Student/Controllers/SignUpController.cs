using Microsoft.AspNetCore.Mvc;
using Student.Context;

namespace Student.Controllers
{
  [ApiController]
  public class SignUpController : Controller
  {
    private readonly AppDbContext _dbContext;
    public SignUpController(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }
 
  }
}
