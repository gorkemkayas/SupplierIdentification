using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/PartnerMainMenu/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/PartnerMainMenu/[action]")]
    [Route("api/PartnerMainMenu/[action]")]
    [Produces("application/json")]
    public class PartnerMainMenuController : BaseFormController<PartnerMainMenu>
    {
        public PartnerMainMenuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PartnerMainMenu API Controller is ok";            
        }
    }
}