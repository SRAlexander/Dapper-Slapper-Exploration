using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Services.Services;

namespace Appa_Exploration.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Values controller
    /// </summary>
    [RoutePrefix("api/log")]
    public class LogController : ApiController
    {
        private readonly ILoggingService _loggingService;

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="loggingService"></param>
        public LogController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        /// <summary>
        /// Testing Swagger comments
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            _loggingService.Log();
            return StatusCode(HttpStatusCode.NoContent);
        }


    }
}
