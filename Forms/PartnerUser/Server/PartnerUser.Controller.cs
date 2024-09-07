using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/PartnerUser/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/PartnerUser/[action]")]
    [Route("api/PartnerUser/[action]")]
    [Produces("application/json")]
    public class PartnerUserController : BaseFormController<PartnerUser>
    {
        public PartnerUserController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PartnerUser API Controller is ok";            
        }
    }
}