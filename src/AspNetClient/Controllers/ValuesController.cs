using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace AspNetClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public ValuesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(
                _invoiceService.GetAll()
            );
        }
    }
}
