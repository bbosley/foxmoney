using FoxMoney.Server.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoxMoney.Server.Controllers.api {
    //[Authorize]
    [ServiceFilter(typeof (ApiExceptionFilter))]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class BaseController : Controller {
        public BaseController() { }
    }
}