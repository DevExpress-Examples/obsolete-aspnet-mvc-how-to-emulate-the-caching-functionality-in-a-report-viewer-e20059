Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Web.Mvc
Imports DevExpress.XtraPrinting.InternalAccess
Imports DevExpress.XtraReports.UI
Imports DevExpressMvcApplication1.Models
Imports DevExpressMvcApplication1.Reports
Imports System.Linq

Namespace DevExpressMvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Public Class TestModel
			Private privateReport As XtraReport
			Public Property Report() As XtraReport
				Get
					Return privateReport
				End Get
				Set(ByVal value As XtraReport)
					privateReport = value
				End Set
			End Property
		End Class

		Public Function Index() As ActionResult
			Dim model As New TestModel()
			model.Report = GetReport()
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
			Return View(model)
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			Dim model As New TestModel()
			model.Report = GetReport()
			Return PartialView("DocumentViewerPartial", model)
		End Function

		Public Function ExportDocumentViewerPartial() As ActionResult
			Return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(GetReport())
		End Function

		Private ms As MemoryStream
		Private Function GetReport() As XtraReport
			Dim report As New XtraReport1()
			AddHandler report.DataSourceDemanded, Function(s, e) AnonymousMethod1(s, e)

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
		
		Private Function AnonymousMethod1(ByVal s As Object, ByVal e As Object) As Boolean
			CType(s, XtraReport).DataSource = New NorthwindEntities().Products
			Return True
		End Function
	End Class
End Namespace
