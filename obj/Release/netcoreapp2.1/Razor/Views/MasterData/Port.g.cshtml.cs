#pragma checksum "C:\EX\BOIMVC\Views\MasterData\Port.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6082f8cdf7388c25e298f119c9a8f3cc70bc9844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_Port), @"mvc.1.0.view", @"/Views/MasterData/Port.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/Port.cshtml", typeof(AspNetCore.Views_MasterData_Port))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6082f8cdf7388c25e298f119c9a8f3cc70bc9844", @"/Views/MasterData/Port.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_Port : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\EX\BOIMVC\Views\MasterData\Port.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 1896, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Port</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Port List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div class=""tab-content"">
						<div class=""active tab-pane"" id=""shipperlist"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>Value_Data</th>
										<th>Thai_Label</th>
										<th>English_Label</th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr *ngFor=""let item of portlist; let i =index"">
										<td style=""width: 50px;text-align: center"">{{i+1}}</td>
										<");
            WriteLiteral(@"td style=""width: 150px;text-align: center"">{{item.value_Data}}</td>
										<td>{{item.thai_Label}}</td>
										<td>{{item.english_Label}}</td>

										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">Delete</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button type=""button"" class=""btn btn-link font-weight-danger"" style=""padding: 0pt"" data-toggle=""modal"" data-target=""#modal-default"">
												Update
											</button>
											<!--  <button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Update</button> -->
										</td>
									</tr>
								</tbody>
							</table>
						</div>
						<!-- /.tab-pane -->

						<div class=""tab-pane"" id=""newitem"">
							");
            EndContext();
            BeginContext(1926, 1104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "398925f12ebc4d71a350bb3b9baaa823", async() => {
                BeginContext(1956, 1067, true);
                WriteLiteral(@"
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Value_Data</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Value_Data"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputEmail"" class=""col-sm-2 control-label"">Thai_Label</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""description"" placeholder=""Thai_Label"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">English_Label</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""English_Label"">
									</div>
								</div>

								<div class=""col-sm-2""></div>
								<div class=""form-group"">
									<div class=""col-sm-offset-2 col-sm-10"">
										<button type=""submit"" class=""btn btn-success"">Save</button");
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t");
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
            BeginContext(3030, 550, true);
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
				<h4 class=""modal-title"">Update Port  List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(3580, 823, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b237f9ea6a4062a0c0e2068aa8df36", async() => {
                BeginContext(3610, 786, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Value_Data</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Value_Data"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputEmail"" class=""col-sm-2 control-label"">Thai_Label</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""description"" placeholder=""Thai_Label"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">English_Label</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""English_Label"">
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
            BeginContext(4403, 310, true);
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
