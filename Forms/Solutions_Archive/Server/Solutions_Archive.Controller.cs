using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/Solutions_Archive/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/Solutions_Archive/[action]")]
    [Route("api/Solutions_Archive/[action]")]
    [Produces("application/json")]
    public class Solutions_ArchiveController : BaseFormController<Solutions_Archive>
    {
        public Solutions_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Solutions_Archive API Controller is ok";            
        }
    }
}