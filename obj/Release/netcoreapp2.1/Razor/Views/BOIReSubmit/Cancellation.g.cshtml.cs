#pragma checksum "C:\EX\BOIMVC\Views\BOIReSubmit\Cancellation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05b6966a864f563c6d711911458135ba3015030a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BOIReSubmit_Cancellation), @"mvc.1.0.view", @"/Views/BOIReSubmit/Cancellation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BOIReSubmit/Cancellation.cshtml", typeof(AspNetCore.Views_BOIReSubmit_Cancellation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\EX\BOIMVC\Views\_ViewImports.cshtml"
using BOIMVC;

#line default
#line hidden
#line 2 "C:\EX\BOIMVC\Views\_ViewImports.cshtml"
using BOIMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b6966a864f563c6d711911458135ba3015030a", @"/Views/BOIReSubmit/Cancellation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_BOIReSubmit_Cancellation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\BOIReSubmit\Cancellation.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 2282, true);
            WriteLiteral(@"
<div class=""content-wrapper"">

	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title""><i class=""fa fa-exclamation-triangle""></i><b> Cancellation</b></h3>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-3 pull-right"">
							<input [(ngModel)]=""invoiceinfo.docno"" required name=""hawbno"" type=""text"" class=""form-control-sm pull-right"" id=""docno"" placeholder=""Doc No, APP No"">
						</div>
					</div>
					<!-- form start -->
					<div class=""box-body"">
						<div class=""box-info with-border"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>PROJ_CODE</th>
										<th>DOC_NO</th>
										<th>APP_NO</th>
										<th>APP_DATE</th>
										<th>TYPE</th>
										<th>REASON<");
            WriteLiteral(@"/th>
										<th></th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 100px;text-align: center"">M6000311</td>
										<td style=""width: 100px;text-align: center"">00032736</td>
										<td style=""width: 150px;text-align: center"">นร1306R601200038539</td>
										<td style=""width: 100px;text-align: center"">12/21/2017</td>
										<td style=""width: 50px;text-align: center"">I</td>
										<td>ยกเลิกยื่นใหม่งวด32862 เนื่องจากยื่นรายการสินค้าผิด</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">View</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">EXCEL</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button");
            WriteLiteral(" class=\"btn btn-link font-weight-danger\" style=\"padding: 0pt\">Submit</button>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
