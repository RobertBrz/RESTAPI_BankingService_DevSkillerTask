using InternetBankingRESTfulService.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace InternetBankingRESTfulService.Web.Controllers
{
    [Route("bank")]
    [ApiController]
    public class BankController : ControllerBase
    {
        IInternetBankingApi _internetBankingApi;

        public BankController()
        {
            _internetBankingApi = new InternetBankingApi();
        }

        [HttpGet]
        [Route("api/calc/MD5/{param}")]
        [Route("api/calc/{param}/MD5")]
        public IActionResult GetHash([FromRoute] string param)
        {
            return Ok(_internetBankingApi.CalculateMD5(param));
        }

        [HttpGet]
        [Route("api/version")]
        [Route("api-version")]
        public IActionResult GetVersion()
        {
            return Ok(_internetBankingApi.GetApiVersion());
        }

        [HttpGet]
        [Route("api/password/strong/{password}")]
        [Route("api/is-password-strong/{password}")]
        public IActionResult CheckPasswordStrong([FromRoute] string password)
        {
            return Ok(_internetBankingApi.IsPasswordStrong(password));
        }
    }
}
