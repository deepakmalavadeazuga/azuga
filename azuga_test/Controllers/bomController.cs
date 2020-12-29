using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using azuga_test.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace azuga_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bomController : ControllerBase
    {
        private IBOMService _iBOMService = null;
        public bomController(IBOMService iBOMService)
        {
            _iBOMService = iBOMService;
        }

        [HttpPost]
        public BOM GetBOM([FromBody] List<Commodity> commodities)
        {
            return _iBOMService.GetBOM(commodities);
        }
    }
}
