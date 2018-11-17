#pragma checksum "C:\EX\BOIMVC\Views\InPlant\ReceiveBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8dcfeb9f63381238cbbaa87679d1cd3bd3db26f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InPlant_ReceiveBill), @"mvc.1.0.view", @"/Views/InPlant/ReceiveBill.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InPlant/ReceiveBill.cshtml", typeof(AspNetCore.Views_InPlant_ReceiveBill))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8dcfeb9f63381238cbbaa87679d1cd3bd3db26f", @"/Views/InPlant/ReceiveBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_InPlant_ReceiveBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\InPlant\ReceiveBill.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 5629, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title"">
							<i class=""fa 	fa fa-pencil-square-o""></i>
							<b> Receive Bill</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-info pull-right"" style=""margin-left: 5px"" data-toggle=""modal"" data-target=""#modal-upload"">Upload</button>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-3 pull-right"">
							<!-- <input  type=""text"" class=""form-control-sm pull-right"" placeholder=""DOC NO""> -->
							<div class=""input-group"">
								<div class=""input-group-addon"">
									<i class=""fa fa-calendar""></i>
								</div>
								<input type=""text"" class=""form-control pull-right"" id=""reservation"">
							</div>
						</div>
					</div>
					<!-- form start -->
					<div class=""box-body"">
						<");
            WriteLiteral(@"div class=""box-info with-border"">
							<table id=""tbl2"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Job No</th>
										<th>Inplant</th>
										<th>Cur</th>
										<th>Exc Rate</th>
										<th>Shipper</th>
										<th>Term</th>
										<th>Type</th>
										<th>CT</th>
										<th>Port</th>
										<th>Ctn</th>
										<th>Wt</th>
										<th>Pack</th>
										<th>FWD</th>
										<th>Received</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td>RHE06-899/17</td>
										<td>07/01/17</td>
										<td>TWD</td>
										<td>1.2</td>
										<td>ADVANCED</td>
										<td>EXW</td>
										<td>FI (TEST)</td>
										<td>TW</td>
										<td>TPE</td>
										<td>1</td>
										<td>241.00</td>
										<td></td>
										<td>RPL</td>
										<td></td>
									</tr>
									<tr>
										<td>RHE06-900/17</td>");
            WriteLiteral(@"
										<td>07/01/17</td>
										<td>TWD</td>
										<td>1.2</td>
										<td>LINGSEN</td>
										<td>EXW</td>
										<td>SUB</td>
										<td>TW</td>
										<td>TPE</td>
										<td>1</td>
										<td>91.00</td>
										<td></td>
										<td>RPL</td>
										<td></td>
									</tr>
									<tr>
										<td>RHE06-901/17</td>
										<td>07/01/17</td>
										<td>TWD</td>
										<td>1.2</td>
										<td>ADVANCED</td>
										<td>EXW</td>
										<td>SUB</td>
										<td>TW</td>
										<td>TPE</td>
										<td>2</td>
										<td>20.00</td>
										<td></td>
										<td>RPL</td>
										<td>07/12/17</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<div class=""modal fade"" id=""modal-upload"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-co");
            WriteLiteral(@"ntent"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Upload Delivery Shipment Plan</h5>
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
	<!---->
	<div class=""modal fade"" id=""modal-email"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content");
            WriteLiteral(@""">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Email to STORE</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">

					<div class=""col-md-12"">
						<div class=""box box-primary"">
							<!-- /.box-header -->
							<div class=""box-body"">
								<div class=""form-group"">
									<input class=""form-control"" placeholder=""To:"">
								</div>
								<div class=""form-group"">
									<input class=""form-control"" placeholder=""Subject:"">
								</div>
								<div class=""form-group"">
									<textarea id=""compose-textarea"" class=""form-control"" style=""height: 300px"">

                              </textarea>
								</div>
								<div class=""form-group"">
									<div class=""btn btn-default btn-file"">
										<i class=""fa fa-paperclip""></i> Attachment
										<input type=""file"" name=""attachment"">
									</");
            WriteLiteral(@"div>
									<p class=""help-block"">Max. 32MB</p>
								</div>
							</div>
						</div>
						<!-- /. box -->
					</div>
					<!-- /.col -->
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
					<button type=""button"" class=""btn btn-primary"">Import</button>
					<button type=""submit"" class=""btn btn-primary""><i class=""fa fa-envelope-o""></i> Send</button>
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