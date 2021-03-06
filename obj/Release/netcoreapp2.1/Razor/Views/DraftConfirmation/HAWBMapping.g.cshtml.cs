#pragma checksum "C:\EX\BOIMVC\Views\DraftConfirmation\HAWBMapping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27d7c9741db1cc4ee86933fc50f5179e4e1999b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DraftConfirmation_HAWBMapping), @"mvc.1.0.view", @"/Views/DraftConfirmation/HAWBMapping.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DraftConfirmation/HAWBMapping.cshtml", typeof(AspNetCore.Views_DraftConfirmation_HAWBMapping))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d7c9741db1cc4ee86933fc50f5179e4e1999b4", @"/Views/DraftConfirmation/HAWBMapping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_DraftConfirmation_HAWBMapping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\DraftConfirmation\HAWBMapping.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 7029, true);
            WriteLiteral(@"<div class=""content-wrapper"">
	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title"">
							<i class=""fa fa-reply-all""></i>
							<b> HAWB Mapping</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-success pull-right"" style=""margin-left: 5px"">Apply</button>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-3 pull-right"">
							<input [(ngModel)]=""invoiceinfo.invoiceno"" required name=""invoiceno"" type=""text"" class=""form-control-sm pull-right""
								   id=""invoiceno"" placeholder=""HAWB Number"">
						</div>
					</div>
					<!-- form start -->
					<div class=""row"">
						<div class=""col-md-3"">
							<div class=""box-body"">
								<div class=""box-info with-border"">
									<div class=""col-12"">
										<input type=""text"" placeholder=""HAWB Number"" class=""pull-left"">
");
            WriteLiteral(@"										<button type=""submit"" class=""btn btn-sm btn-default pull-right"" style=""margin-right: 5px"">Insert</button>
									</div>
									<table id=""tbl1"" class=""table table-bordered table-hover"">
										<thead class=""p-3 mb-2 bg-info text-white text-center"">
											<tr>
												<th>HAWB Number</th>
												<th style=""width:60px""></th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td style=""width: 150px;text-align: left"">HAWB00000001</td>
												<th class=""text-center""><button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Select</button></th>
											</tr>
											<tr>
												<td style=""width: 150px;text-align: left"">HAWB00000002</td>
												<th class=""text-center""><button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Select</button></th>
											</tr>
											<tr>
												<td style=""width: 150px;text-align: left"">HAWB00000003</td>
												<th class=""text-center""><button ");
            WriteLiteral(@"class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Select</button></th>
											</tr>
											<tr>
												<td style=""width: 150px;text-align: left"">HAWB00000004</td>
												<th class=""text-center""><button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Select</button></th>
											</tr>
											<tr>
												<td style=""width: 150px;text-align: left"">HAWB00000005</td>
												<th class=""text-center""><button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Select</button></th>
											</tr>
										</tbody>
									</table>
								</div>
							</div>
						</div>
						<div class=""col-md-9"">
							<div class=""box-body"">
								<div class=""box-info with-border"">
									<table id=""tbl1"" class=""table table-bordered table-hover"">
										<thead class=""p-3 mb-2 bg-info text-white text-center"">
											<tr>
												<th class=""text-center"" style=""width:20px""></th>
												<th>Invoice Number</th>
												");
            WriteLiteral(@"<th>Invoice Date</th>
												<th>Shipper</th>
												<th>Approve No</th>
												<th>Status</th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td><input type=""checkbox""></td>
												<td style=""width: 150px;text-align: left"">2017-MTH-09-G178</td>
												<td style=""width: 150px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center"">นร1306R601000099099</td>
												<td class=""text-center"">Submited</td>
												<!-- <td class=""text-center"" style=""width: 60px;text-align: center"">
														<button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">View</button>
													  </td>
													  <td class=""text-center"" style=""width: 60px;text-align: center"">
														<button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Save</button>
													  </td> -->
											</tr>
											<tr>
												<td><input type=""checkbox""></td>
										");
            WriteLiteral(@"		<td style=""width: 100px;text-align: left"">2017-MTH-09-G179</td>
												<td style=""width: 100px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center"">นร1306R601000099099</td>
												<td class=""text-center"">Submited</td>
											</tr>
											<tr>
												<td><input type=""checkbox""></td>
												<td style=""width: 100px;text-align: left"">2017-MTH-09-G180</td>
												<td style=""width: 100px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center"">นร1306R601000099099</td>
												<td class=""text-center"">Submited</td>
											</tr>
											<tr>
												<td><input type=""checkbox""></td>
												<td style=""width: 100px;text-align: left"">2017-MTH-09-G181</td>
												<td style=""width: 100px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center"">นร1306R601000099099</td>
												<td class=""text-center"">Submited</t");
            WriteLiteral(@"d>
											</tr>
											<tr>
												<td><input type=""checkbox""></td>
												<td style=""width: 100px;text-align: left"">2017-MTH-09-G182</td>
												<td style=""width: 100px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center""></td>
												<td class=""text-center"">New Item</td>
											</tr>
											<tr>
												<td><input type=""checkbox""></td>
												<td style=""width: 100px;text-align: left"">2017-MTH-09-G183</td>
												<td style=""width: 100px;text-align: center"">08/21/2017</td>
												<td>SHINKO</td>
												<td class=""text-center""></td>
												<td class=""text-center"">BirthImp Create</td>
											</tr>
										</tbody>
									</table>
								</div>
							</div>
						</div>
					</div>


				</div>
			</div>
		</div>
	</section>
	<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class");
            WriteLiteral(@"=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Upload BOI Approval EXCEL File</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					<div class=""input-group"">
						<div class=""custom-file"">
							<input type=""file"" class=""custom-file-input"" id=""inputGroupFile04"">
							<label class=""custom-file-label"" for=""inputGroupFile04"">Choose file</label>
						</div>
					</div>
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
					<button type=""button"" class=""btn btn-primary"">Import</button>
				</div>
			</div>
		</div>
	</div>

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
