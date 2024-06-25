<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DevExpressMvcApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DevExpressMvcApplication1/Controllers/HomeController.vb))
* [XtraReport1.cs](./CS/DevExpressMvcApplication1/Reports/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/DevExpressMvcApplication1/Reports/XtraReport1.vb))
* [Index.cshtml](./CS/DevExpressMvcApplication1/Views/Home/Index.cshtml)
* [ReportViewerPartial.cshtml](./CS/DevExpressMvcApplication1/Views/Home/ReportViewerPartial.cshtml)
<!-- default file list end -->
# OBSOLETE - ASP.NET MVC - How to emulate the caching functionality in a report viewer extension


<p>Between individual postbacks performed by the server, the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument10009">DocumentViewer</a> control can keep information about its intermediate state on the client.</p>
<p>This example illustrates how to avoid triggering repeated document generation on the server by navigating between report pages.</p>
<p>For a solution to a similar task that applies to a Web Forms application, see <a href="http://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E1946"><u>How to use the caching functionality of the Document Viewer</u></a>.</p>
<p><br /><strong>NOTE: The approach demonstrated in this code example is obsolete starting with version v2013 vol 2 (v13.2).</strong> <br />That's because the new DocumentViewer MVC extension was released in that version, and this extension supports caching out-of-the-box. Please refer to the following code example to learn how to use the built-in DocumentViewer caching functionality: <a href="https://www.devexpress.com/Support/Center/p/T191577">How to use the built-in caching functionality of the ASP.NET MVC Document Viewer</a></p>

<br/>


