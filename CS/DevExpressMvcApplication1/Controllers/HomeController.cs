using System.IO;
using System.Web.Mvc;
using DevExpress.XtraPrinting.InternalAccess;
using DevExpress.XtraReports.UI;
using DevExpressMvcApplication1.Models;
using DevExpressMvcApplication1.Reports;
using System.Linq;
// ...

namespace DevExpressMvcApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }

        public ActionResult ReportViewerPartial() {
            ViewData["Report"] = GetReport();
            return PartialView("ReportViewerPartial");
        }

        public ActionResult ExportReportViewerPartial() {
            return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(GetReport());
        }

        MemoryStream ms;
        XtraReport GetReport() {
            XtraReport1 report = new XtraReport1();
            report.DataSourceDemanded += (s, e) => {
                ((XtraReport)s).DataSource = new NorthwindEntities().Products;
            };

            if (Session["ReportCache"] == null) {
                report.CreateDocument();
                ms = new MemoryStream();
                PrintingSystemAccessor.SaveIndependentPages(report.PrintingSystem, ms);
                Session["ReportCache"] = ms;
            } else {
                ms = (MemoryStream)Session["ReportCache"];
                PrintingSystemAccessor.LoadVirtualDocument(report.PrintingSystem, ms);
            }
            return report;
        }
    }
}
