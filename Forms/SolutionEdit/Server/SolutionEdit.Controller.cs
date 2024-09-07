using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/SolutionEdit/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/SolutionEdit/[action]")]
    [Route("api/SolutionEdit/[action]")]
    [Produces("application/json")]
    public class SolutionEditController : BaseFormController<SolutionEdit>
    {
        public SolutionEditController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "SolutionEdit API Controller is ok";            
        }
    }
}