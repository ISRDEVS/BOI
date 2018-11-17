#pragma checksum "C:\EX\BOIMVC\Views\BOIReSubmit\BirtCanCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa35ff0c6a7eff91d87c3b8247f506ff0efffa94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BOIReSubmit_BirtCanCreate), @"mvc.1.0.view", @"/Views/BOIReSubmit/BirtCanCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BOIReSubmit/BirtCanCreate.cshtml", typeof(AspNetCore.Views_BOIReSubmit_BirtCanCreate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa35ff0c6a7eff91d87c3b8247f506ff0efffa94", @"/Views/BOIReSubmit/BirtCanCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_BOIReSubmit_BirtCanCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\BOIReSubmit\BirtCanCreate.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 3619, true);
            WriteLiteral(@"
<div class=""content-wrapper"">

	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title""><i class=""fa fa-pencil-square-o""></i><b> BirtCan Create</b></h3>
						<button type=""submit"" class=""btn btn-sm btn-success pull-right"" style=""margin-left: 5px"">Save</button>
						<button type=""submit"" class=""btn btn-sm btn-primary pull-right"" style=""margin-left: 5px"">EXCEL</button>
						<button type=""submit"" class=""btn btn-sm btn-warning pull-right"" style=""margin-left: 5px"">Apply</button>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-3 pull-right"">
							<input [(ngModel)]=""invoiceinfo.docno"" required name=""hawbno"" type=""text"" class=""form-control-sm pull-right"" id=""docno"" placeholder=""Doc No, APP No"">
						</div>
					</div>
					<!-- form start -->
					<div class=""box-body"">
						<div class=""b");
            WriteLiteral(@"ox-info with-border"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th style=""width: 40px;text-align: center"">
											<input type=""checkbox"" id=""chkall"">
										</th>
										<th>Project Code</th>
										<th>Doc No</th>
										<th>APP No</th>
										<th>APP Date</th>
										<th>Invoice No</th>
										<th>Type Of Goods</th>
										<th>Total Line</th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 30px;text-align: center""></td>
										<td style=""width: 120px;text-align: center"">M6000311</td>
										<td style=""width: 120px;text-align: center"">00032736</td>
										<td style=""text-align: center"">นร1306R601200038539</td>
										<td style=""width: 120px;text-align: center"">12/21/2017</td>
										<td style=""width: 120px;text-align: center"">7717059278</td>
							");
            WriteLiteral(@"			<td style=""width: 120px;text-align: center"">A</td>
										<td style=""width: 100px;text-align: center"">15</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">View</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Remove</button>
										</td>
									</tr>
								</tbody>
							</table>
						</div>
						<div class=""box-info with-border"">
							<table id=""tbl2"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Project Code</th>
										<th>Doc No</th>
										<th>APP No</th>
										<th>Reason</th>
										<th>Internal Note</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 120px;text-align: center"">M6000311<");
            WriteLiteral(@"/td>
										<td style=""width: 70px;text-align: center"">00022937</td>
										<td style=""width: 170px;text-align: center"">นร1306R601200038539</td>
										<td style=""width: 300px"">
											<input type=""text"" class=""form-control"" id=""reason"" style=""width: 100%"">
										</td>
										<td>
											<input type=""text"" class=""form-control"" id=""note"" style=""width: 100%"">
										</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

</div>


");
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
