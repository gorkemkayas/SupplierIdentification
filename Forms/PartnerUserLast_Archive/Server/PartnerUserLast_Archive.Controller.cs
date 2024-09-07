using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/PartnerUserLast_Archive/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/PartnerUserLast_Archive/[action]")]
    [Route("api/PartnerUserLast_Archive/[action]")]
    [Produces("application/json")]
    public class PartnerUserLast_ArchiveController : BaseFormController<PartnerUserLast_Archive>
    {
        public PartnerUserLast_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PartnerUserLast_Archive API Controller is ok";            
        }
    }
}