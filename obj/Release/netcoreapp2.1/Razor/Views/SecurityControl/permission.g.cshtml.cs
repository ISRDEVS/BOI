#pragma checksum "C:\EX\BOIMVC\Views\SecurityControl\permission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b72dcf3130df83b414161151f4e918be4cb0ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SecurityControl_permission), @"mvc.1.0.view", @"/Views/SecurityControl/permission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SecurityControl/permission.cshtml", typeof(AspNetCore.Views_SecurityControl_permission))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b72dcf3130df83b414161151f4e918be4cb0ae4", @"/Views/SecurityControl/permission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_SecurityControl_permission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\SecurityControl\permission.cshtml"
  
Layout = "_Homes";

#line default
#line hidden
            BeginContext(29, 2139, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title"">
							<i class=""fa fa-reply-all""></i>
							<b> Permission Setting</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-success pull-right"" style=""margin-left: 5px"">Apply</button>
					</div>
					<!-- form start -->
					<div class=""row"">
						<div class=""col-md-5"">
							<table class=""table table-hover table-bordered"">
								<thead>
									<tr>
										<th>User Group</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td>Administrator</td>
									</tr>
									<tr>
										<td>Invoice Entry</td>
									</tr>
									<tr>
										<td>Project</td>
									</tr>
									<tr>
										<td>BOI</td>
									</tr>
									<tr>
										<td>Store</td>
									</tr>
								</tbody>
			");
            WriteLiteral(@"				</table>
						</div>
						<div class=""col-md-7"">
							<table class=""table table-hover table-bordered"">
								<thead>
									<tr>
										<th></th>
										<th>Menu List</th>
									</tr>
								</thead>
								<tbody>

									<tr>
										<td class=""text-center"" style=""width: 40px""><input type=""checkbox""></td>
										<td>Invoice List</td>
									</tr>
									<tr>
										<td class=""text-center"" style=""width: 40px""><input type=""checkbox""></td>
										<td>Dash Board Over All</td>
									</tr>
									<tr>
										<td class=""text-center"" style=""width: 40px""><input type=""checkbox""></td>
										<td>Project</td>
									</tr>
									<tr>
										<td class=""text-center"" style=""width: 40px""><input type=""checkbox""></td>
										<td>Project List</td>
									</tr>
									<tr>
										<td class=""text-center"" style=""width: 40px""><input type=""checkbox""></td>
										<td>Projet Control</td>
									</tr>
								</tbody>
							</ta");
            WriteLiteral("ble>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n</div>\r\n\r\n\r\n");
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
