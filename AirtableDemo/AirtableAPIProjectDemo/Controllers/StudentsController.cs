using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirtableAPIProjectDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private DbContext _dbContext;
        public StudentsController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
