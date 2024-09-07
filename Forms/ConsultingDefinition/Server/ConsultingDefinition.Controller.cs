using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/ConsultingDefinition/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/ConsultingDefinition/[action]")]
    [Route("api/ConsultingDefinition/[action]")]
    [Produces("application/json")]
    public class ConsultingDefinitionController : BaseFormController<ConsultingDefinition>
    {
        public ConsultingDefinitionController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "ConsultingDefinition API Controller is ok";            
        }
    }
}