@Code
    ViewBag.Title = "Home Page"
End Code

<h2>@ViewBag.Message</h2>
<p>
    To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/" title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>

@Html.DevExpress().ReportToolbar( _
    Sub(settings)
        settings.Name = "ReportToolbar"
            settings.Width = System.Web.UI.WebControls.Unit.Pixel(800)
        settings.ReportViewerName = "reportViewer1"
    End Sub).GetHtml()

@Html.Partial("ReportViewerPartial")
