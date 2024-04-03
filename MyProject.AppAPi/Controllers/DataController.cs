using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Business;

namespace MyProject.AppAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly Data _data;

        public DataController(Data data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_data.GetData());
        }
    }
}
