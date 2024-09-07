using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/ConsultingDefinition2_Archive/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/ConsultingDefinition2_Archive/[action]")]
    [Route("api/ConsultingDefinition2_Archive/[action]")]
    [Produces("application/json")]
    public class ConsultingDefinition2_ArchiveController : BaseFormController<ConsultingDefinition2_Archive>
    {
        public ConsultingDefinition2_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "ConsultingDefinition2_Archive API Controller is ok";            
        }
    }
}