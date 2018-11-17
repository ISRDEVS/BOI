#pragma checksum "C:\EX\BOIMVC\Views\MasterData\Calcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d6b7759759842e28a3dede47ed639b0d3c0be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_Calcel), @"mvc.1.0.view", @"/Views/MasterData/Calcel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/Calcel.cshtml", typeof(AspNetCore.Views_MasterData_Calcel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d6b7759759842e28a3dede47ed639b0d3c0be1", @"/Views/MasterData/Calcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_Calcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\EX\BOIMVC\Views\MasterData\Calcel.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 1902, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Cancel Reason</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Cancel Reason List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div class=""tab-content"">
						<div class=""active tab-pane"" id=""shipperlist"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>Code</th>
										<th>Incorrect</th>
										<th>ขอยกเลิกเนื่องจาก</th>

										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr *ngFor=""let item of cancellist; let i =index"">
										<td style=""width: 50px;text-align: center"">{{i+1}");
            WriteLiteral(@"}</td>
										<td style=""width: 150px;text-align: center"">{{item.code}}</td>
										<td>{{item.incorrect}}</td>
										<td>{{item.remark}}</td>

										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">Delete</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button type=""button"" class=""btn btn-link font-weight-danger"" style=""padding: 0pt"" data-toggle=""modal"" data-target=""#modal-default"">
												Update
											</button>
											<!--   <button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Update</button> -->
										</td>
									</tr>
								</tbody>
							</table>
						</div>
						<!-- /.tab-pane -->

						<div class=""tab-pane"" id=""newitem"">
							");
            EndContext();
            BeginContext(1932, 1098, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c90fc2fcf34fc6ae2c276ac2a18c92", async() => {
                BeginContext(1962, 1061, true);
                WriteLiteral(@"
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Code</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Code"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputEmail"" class=""col-sm-2 control-label"">Incorrect</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""description"" placeholder=""Incorrect"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">ขอยกเลิกเนื่องจาก</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""ขอยกเลิกเนื่องจาก"">
									</div>
								</div>

								<div class=""col-sm-2""></div>
								<div class=""form-group"">
									<div class=""col-sm-offset-2 col-sm-10"">
										<button type=""submit"" class=""btn btn-success"">Save</button>
			");
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3030, 559, true);
            WriteLiteral(@"
						</div>
						<!-- /.tab-pane -->
					</div>
					<!-- /.tab-content -->
				</div>
				<!-- /.nav-tabs-custom -->
			</div>
		</div>
	</section>

</div>

<div class=""modal fade"" id=""modal-default"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				<h4 class=""modal-title"">Update Cancel Reason  List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(3589, 817, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee91d50d81014fdaa050ca73cacecb77", async() => {
                BeginContext(3619, 780, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Code</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Code"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputEmail"" class=""col-sm-2 control-label"">Incorrect</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""description"" placeholder=""Incorrect"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">ขอยกเลิกเนื่องจาก</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""ขอยกเลิกเนื่องจาก"">
						</div>
					</div>


				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4406, 308, true);
            WriteLiteral(@"
			</div>
			<div class=""modal-footer"">
				<button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Close</button>
				<button type=""button"" class=""btn btn-primary"">Save changes</button>
			</div>
		</div>
		<!-- /.modal-content -->
	</div>
	<!-- /.modal-dialog -->
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
