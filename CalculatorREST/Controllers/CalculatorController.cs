using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogicDll;

namespace CalculatorREST.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpPost]
        [Route("api/calculator/{neshto}")]
        public HttpResponseMessage PostNeshto(string neshto, [FromUri] string drugoNehsto, [FromBody] DataObject obj)
        {
            return Request.CreateResponse(HttpStatusCode.OK, obj);
        }
    }

    public class DataObject
    {
        public int Number { get; set; }
    }
}
