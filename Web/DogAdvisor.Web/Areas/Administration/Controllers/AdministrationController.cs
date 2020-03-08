namespace DogAdvisor.Web.Areas.Administration.Controllers
{
    using DogAdvisor.Common;
    using DogAdvisor.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
