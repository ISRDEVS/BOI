#pragma checksum "C:\EX\BOIMVC\Views\Project\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d042457b32a8d666ed282cfa9d6aaea62466bda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Project), @"mvc.1.0.view", @"/Views/Project/Project.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Project.cshtml", typeof(AspNetCore.Views_Project_Project))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d042457b32a8d666ed282cfa9d6aaea62466bda2", @"/Views/Project/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\EX\BOIMVC\Views\Project\Project.cshtml"
  
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
							<b> Project</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-info pull-right"" style=""margin-left: 5px"" data-toggle=""modal"" data-target=""#modal-upload"">New Project</button>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Search</button>
						<div class=""col-md-2 pull-right"">
							<input type=""text"" class=""form-control pull-right"">
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
					<!-- form start -->
					<div class");
            WriteLiteral(@"=""box-body"">
						<div class=""box-info with-border"">
							<table id=""tbl2"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr class=""text-center"">
										<th class=""text-center"">MMT</th>
										<th class=""text-center"">MTAI</th>
										<th class=""text-center"">Certificate No</th>
										<th class=""text-center"">Dated</th>
										<th class=""text-center"">Project Code</th>
										<th class=""text-center"">Stock1</th>
										<th class=""text-center"">Stock2</th>
										<th class=""text-center"">Stock3</th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td class=""text-center""></td>
										<td class=""text-center"">1</td>
										<td class=""text-center"">1679/2538</td>
										<td class=""text-center"">01/09/95</td>
										<td class=""text-center"">Terminated</td>
										<td></td>
										<td></td>
										<td></td>
										<td class=""text-center"" ");
            WriteLiteral(@"style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
										</td>
									</tr>
									<tr>
										<td></td>
										<td class=""text-center"">2</td>
										<td class=""text-center"">1029/2542</td>
										<td class=""text-center"">01/08/99</td>
										<td class=""text-center"">Terminated</td>
										<td></td>
										<td></td>
										<td></td>
										<td class=""text-center"" style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
										</td>
									</tr>
									<tr>
										<td></td>
										<td class=""text-center"">3</td>
										<td class=""text-center"">1484(6)/2548</td>
										<td class=""text-center"">20/01/14</td>
										<td class=""text-center"">570052</td>
										<td class=""text-center"">M5701111</td>
										<td></t");
            WriteLiteral(@"d>
										<td></td>
										<td class=""text-center"" style=""width:45px"">
											<button type=""submit"" class=""btn btn-sm btn-warning"" style=""padding:0px"" data-toggle=""modal"" data-target=""#modal-upload"">Update</button>
										</td>
									</tr>
									<tr>
										<td></td>
										<td class=""text-center"">4</td>
										<td class=""text-center"">1484(6)/2549</td>
										<td class=""text-center"">20/01/18</td>
										<td class=""text-center"">570052</td>
										<td class=""text-center"">M5701111</td>
										<td class=""text-center"">M6000311</td>
										<td class=""text-center"">M6100811</td>
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

	<div class=""modal fade bd-example-modal""");
            WriteLiteral(@" id=""modal-upload"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Project Management</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					");
            EndContext();
            BeginContext(4610, 2153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbb00eab05a46a8895a3f3f2211e5fb", async() => {
                BeginContext(4640, 2116, true);
                WriteLiteral(@"
						<div class=""form-group"">
							<label for=""inputName"" class=""col-sm-3 control-label"">MMT</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""shipper"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">MTAI</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">Certificate No</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">Dated</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-");
                WriteLiteral(@"3 control-label"">Project Code</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">Stock1</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">Stock2</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""form-group"">
							<label for=""inputEmail"" class=""col-sm-3 control-label"">Stock3</label>
							<div class=""col-sm-8"">
								<input type=""text"" class=""form-control"" id=""description"">
							</div>
						</div>
						<div class=""col-sm-12""></div>
						<div class=""form-group"">
							<div class=""col-sm-12 pull-right"">
								<button type=""submit"" class");
                WriteLiteral("=\"btn btn-success\">Save</button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
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
            BeginContext(6763, 64, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<!---->\r\n</div>\r\n\r\n");
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
