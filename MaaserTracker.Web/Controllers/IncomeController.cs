using MaaserTracker.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaaserTracker.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly string _connectionString;
        public IncomeController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [HttpPost("addsource")]
        public void AddSource(IncomeSource source)
        {
            var repo = new IncomeRepo(_connectionString);
            repo.AddSource(source);
        }

        [HttpGet("getallsources")]
        public List<IncomeSource> GetSources()
        {
            var repo = new IncomeRepo(_connectionString);
            return repo.GetSources();
        }
    }
}
