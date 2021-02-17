using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Primitives;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Validation;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Controllers
{
    public class ApiController : Controller
    {
        [Authorize(AuthenticationSchemes = OpenIddictValidationDefaults.AuthenticationScheme), HttpGet("~/api/test")]
        public IActionResult GetMessage()
        {
            return Json(new
            {
                Subject = User.GetClaim(OpenIdConnectConstants.Claims.Subject),
                Name = User.Identity.Name
            });
        }
    }
}
