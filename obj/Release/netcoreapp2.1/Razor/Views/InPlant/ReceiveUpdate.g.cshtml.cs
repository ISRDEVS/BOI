#pragma checksum "C:\EX\BOIMVC\Views\InPlant\ReceiveUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ad38401ebee16b458292ca3e0a15facb0a6762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InPlant_ReceiveUpdate), @"mvc.1.0.view", @"/Views/InPlant/ReceiveUpdate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InPlant/ReceiveUpdate.cshtml", typeof(AspNetCore.Views_InPlant_ReceiveUpdate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ad38401ebee16b458292ca3e0a15facb0a6762", @"/Views/InPlant/ReceiveUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_InPlant_ReceiveUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\InPlant\ReceiveUpdate.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 4580, true);
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
							<b> Update Bill</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-info pull-right"" style=""margin-left: 5px"" data-toggle=""modal"" data-target=""#modal-upload"">Upload</button>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-2 pull-right"">
							<input type=""text"" class=""form-control pull-right"" placeholder=""DOC NO"">
						</div>
						<div class=""col-md-3 pull-right"">
							<div class=""input-group"">
								<div class=""input-group-addon"">
									<i class=""fa fa-calendar""></i>
								</div>
								<input type=""text"" class=""form-control pull-right"" id=""reservation"">
							</div>
						</div>
					</div>
					<!-- form start ");
            WriteLiteral(@"-->
					<div class=""box-body"">
						<div class=""box-info with-border"">
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
										<th></th>
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
");
            WriteLiteral(@"										<td class=""text-center"" style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
										</td>
									</tr>
									<tr>
										<td>RHE06-900/17</td>
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
										<td class=""text-center"" style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
										</td>
									</tr>
									<tr>
										<td>RHE06-901/17</td>
										<td>07/01/17</td>
										<td>TWD</td>
										<td>1.2</td>
										<td>ADVANCED</td>
										<td>EXW</td>
										");
            WriteLiteral(@"<td>SUB</td>
										<td>TW</td>
										<td>TPE</td>
										<td>2</td>
										<td>20.00</td>
										<td></td>
										<td>RPL</td>
										<td>07/12/17</td>
										<td class=""text-center"" style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
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

	<div class=""modal fade bd-example-modal-lg"" id=""modal-upload"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog modal-lg"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Update Bill</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>");
            WriteLiteral(@"
				<div class=""modal-body"">
					<div class=""col-sm-4"">
						<div class=""box box-info box-solid"">
							<div class=""box-header with-border"">
								<h3 class=""box-title"">Job Infomation</h3>
								<div class=""box-tools"">
									<button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
										<i class=""fa fa-minus""></i>
									</button>
								</div>
							</div>
							<!-- /.box-header -->
							<div class=""box-body no-padding"">
								");
            EndContext();
            BeginContext(4610, 2700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc542d1e35f2414d8824bb4a9f8abc72", async() => {
                BeginContext(4616, 2687, true);
                WriteLiteral(@"
									<table cellspacing=""0"" cellpadding=""3"" width=""95%"">
										<thead class=""invisible"">
											<tr>
												<th style=""width: 50%"">Item</th>
												<th></th>
											</tr>
										</thead>
										<tr>
											<td style=""padding-left: 5px"" class=""pull-left"">Job No.</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Inplant</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Currency</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Exch. Rate</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Shipper</td>
											<td><in");
                WriteLiteral(@"put type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Ship Term</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Country</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Port</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Carton</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Receive Bill</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Bill To F/N</td>
			");
                WriteLiteral(@"								<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
										<tr>
											<td style=""padding-left: 5px"">Remark</td>
											<td><input type=""text"" class=""form-control pull-right text-right""></td>
										</tr>
									</table>
									<!---->
									<div style=""padding-right: 15px; padding-top:10px; padding-bottom: 5px"">
										<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
										<button type=""submit"" class=""btn btn-sm btn-default pull-right"" style=""margin-right: 5px"">Clear</button>
									</div>
									<br>...
								");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7310, 4465, true);
            WriteLiteral(@"
							</div>
							<!-- /.box-body -->
						</div>
					</div>
					<div class=""col-sm-8"" style=""padding-top:10px"">
						<table cellspacing=""5"" cellpadding=""5"" class=""col-sm-12"">
							<thead>
								<tr class=""text-center text-light"">
									<td></td>
									<td></td>
									<td>Min</td>
									<td>kg</td>
									<td>USD</td>
									<td>Baht</td>
									<td></td>
									<td>Bath</td>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td class=""text-center"" styl=""width:20px"">
										<input type=""checkbox"">
									</td>
									<td styl=""width:60px"">Freight</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%");
            WriteLiteral(@""">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td styl=""width:60px text-right""> D/O</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
								</tr>
								<tr>
									<td class=""text-center"" styl=""width:20px"">
										<input type=""checkbox"">
									</td>
									<td styl=""width:60px"">Export</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" s");
            WriteLiteral(@"tyle=""width:100%"">
									</td>
									<td styl=""width:60px text-right""> Duty</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
								</tr>
								<tr>
									<td class=""text-center"" styl=""width:20px"">
										<input type=""checkbox"">
									</td>
									<td styl=""width:60px"">Pickup</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td styl=""width:60px text-right""> Amend</td>
									<td style=""width:8");
            WriteLiteral(@"0px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
								</tr>
								<tr>
									<td class=""text-center"" styl=""width:20px"">
										<input type=""checkbox"">
									</td>
									<td styl=""width:60px"">Port</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
									<td styl=""width:60px text-right""> O/T</td>
									<td style=""width:80px"">
										<input type=""text"" class=""form-control-sm text-right"" style=""width:100%"">
									</td>
								</tr>");
            WriteLiteral(@"
							</tbody>
						</table>
					</div>
					<div class=""modal-footer"" style=""padding-top:35px"">
						<div>-</div>
						<button type=""button"" class=""btn btn-sm btn-secondary"" data-dismiss=""modal"">Close</button>
						<button type=""button"" class=""btn btn-sm btn-primary"">Apply</button>
					</div>
				</div>
			</div>
		</div>
		<!---->
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
