using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/PartnerUserLast2_Archive/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/PartnerUserLast2_Archive/[action]")]
    [Route("api/PartnerUserLast2_Archive/[action]")]
    [Produces("application/json")]
    public class PartnerUserLast2_ArchiveController : BaseFormController<PartnerUserLast2_Archive>
    {
        public PartnerUserLast2_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PartnerUserLast2_Archive API Controller is ok";            
        }
    }
}