using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/SupplyPageLast2_Archive/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/SupplyPageLast2_Archive/[action]")]
    [Route("api/SupplyPageLast2_Archive/[action]")]
    [Produces("application/json")]
    public class SupplyPageLast2_ArchiveController : BaseFormController<SupplyPageLast2_Archive>
    {
        public SupplyPageLast2_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "SupplyPageLast2_Archive API Controller is ok";            
        }
    }
}