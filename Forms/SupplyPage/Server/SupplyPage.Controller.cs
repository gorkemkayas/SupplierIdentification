using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/SupplyPage/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/SupplyPage/[action]")]
    [Route("api/SupplyPage/[action]")]
    [Produces("application/json")]
    public class SupplyPageController : BaseFormController<SupplyPage>
    {
        public SupplyPageController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "SupplyPage API Controller is ok";            
        }
    }
}