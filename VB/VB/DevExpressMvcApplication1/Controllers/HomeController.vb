Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Web.Mvc
Imports DevExpress.XtraPrinting.InternalAccess
Imports DevExpress.XtraReports.UI
Imports DevExpressMvcApplication1.Reports
Imports System.Linq
Imports System
Imports NorthwindModel

' ...

Namespace DevExpressMvcApplication1.Controllers
    Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            Return View()
        End Function

        Public Function ReportViewerPartial() As ActionResult
            ViewData("Report") = GetReport()
            Return PartialView("ReportViewerPartial")
        End Function

        Public Function ExportReportViewerPartial() As ActionResult
            Return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(GetReport())
        End Function

        Private ms As MemoryStream
        Private Function GetReport() As XtraReport
            Dim report As New XtraReport1()
            AddHandler report.DataSourceDemanded, AddressOf DataSourceDemandedEventHandler
            If Session("ReportCache") Is Nothing Then
                report.CreateDocument()
                ms = New MemoryStream()
                PrintingSystemAccessor.SaveIndependentPages(report.PrintingSystem, ms)
                Session("ReportCache") = ms
            Else
                ms = CType(Session("ReportCache"), MemoryStream)
                PrintingSystemAccessor.LoadVirtualDocument(report.PrintingSystem, ms)
            End If
            Return report
        End Function

        Private Sub DataSourceDemandedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
            CType(sender, XtraReport).DataSource = New NorthwindEntities().Products
        End Sub
    End Class
End Namespace