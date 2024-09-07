using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.Web.Attributes;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SupplierIdentification.Report
{
	[EnableCors]
    [DontWrapResultFilter]
    [ApiExplorerSettings(IgnoreApi = true)]
	[Route("apps/SupplierIdentification/latest/api/ReportViewer")]
	[Route("api/ReportViewer")]
	[Route("apps/SupplierIdentification/{v:int:min(1)}/api/ReportViewer")]
    public class ReportViewerController : BaseReportController
    {
        public ReportViewerController(IWebDocumentViewerMvcControllerService controllerService, IocManager iocManager) : base(controllerService, iocManager)
        {
        }
    }
}