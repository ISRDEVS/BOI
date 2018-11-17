#pragma checksum "C:\EX\BOIMVC\Views\BOIDefinition\BOIDefinitionRequestList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5de6530563ad03cb4ae1aba2bbdd1ce97621c67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BOIDefinition_BOIDefinitionRequestList), @"mvc.1.0.view", @"/Views/BOIDefinition/BOIDefinitionRequestList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BOIDefinition/BOIDefinitionRequestList.cshtml", typeof(AspNetCore.Views_BOIDefinition_BOIDefinitionRequestList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5de6530563ad03cb4ae1aba2bbdd1ce97621c67", @"/Views/BOIDefinition/BOIDefinitionRequestList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_BOIDefinition_BOIDefinitionRequestList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\EX\BOIMVC\Views\BOIDefinition\BOIDefinitionRequestList.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 3563, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<!-- Main content -->
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""box box-info"">
					<div class=""box-header with-border"">
						<h3 class=""box-title"">
							<i class=""fa fa-folder-open-o""></i>
							<b> BOI Definition Request List</b>
						</h3>
						<button type=""submit"" class=""btn btn-sm btn-default pull-right"">Export</button>
					</div>
					<!-- form start -->
					<div class=""box-body"">
						<div class=""box-info with-border"">
							<table id=""example1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Date</th>
										<th>BOI Type</th>
										<th>Description</th>
										<th>Requestor</th>
										<th>Remark</th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 100px;text-align: center"">09/09/18</td>
										<td style=""width: 100px;tex");
            WriteLiteral(@"t-align: center"">Machine</td>
										<td>
											เป็นเครื่องทำความร้อนให้กับชิ้นงานหรือบริเวณเฉพาะ
											โดยจะมีท่อต่อออกจากตัวเครื่องแล้วนำหัวทำความร้อนไปจ่อที่ตัวงานหรือบริเวณที่ต้องการเพิ่มอุณหภูมิ
										</td>
										<td>Woottipong</td>
										<td></td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"" data-toggle=""modal""
													data-target=""#exampleModal"" aria-expanded=""true"" aria-controls=""collapseOne"">
												Update
											</button>
										</td>
									</tr>
									<tr>
										<td style=""width: 100px;text-align: center"">09/09/18</td>
										<td style=""width: 80px;text-align: center"">Spare Part</td>
										<td>แกนโลหะสำหรับยึดเครื่องทดสอบกับอุปกรณ์สำหรับตรวจสอบความแบนราบของระนาบของเครื่องจักรเข้าด้วยกัน</td>
										<td>Sakol</td>
										<td></td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
					");
            WriteLiteral(@"						<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"" data-toggle=""modal""
													data-target=""#exampleModal"" aria-expanded=""true"" aria-controls=""collapseOne"">
												Update
											</button>
										</td>
									</tr>
									<tr>
										<td style=""width: 100px;text-align: center"">10/09/18</td>
										<td style=""width: 80px;text-align: center"">Spare Part</td>
										<td>เป็นชิ้นส่วนตัวพยุงลดแรงกระแทกของชุดรับชิ้นงานลงสู่จุดทดสอบ ทำจากพลาสติก/โลหะ</td>
										<td>Salok</td>
										<td></td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"" data-toggle=""modal""
													data-target=""#exampleModal"" aria-expanded=""true"" aria-controls=""collapseOne"">
												Update
											</button>
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
	<div class=""");
            WriteLiteral(@"modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">BOI Definition</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					");
            EndContext();
            BeginContext(3593, 1670, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e54060494e4155aa408bac07bdfc96", async() => {
                BeginContext(3599, 1657, true);
                WriteLiteral(@"
						<div class=""form-group"">
							<label class=""col-sm-3 form-label"">BOI Type : </label>
							<fieldset id=""boitype"">
								<input type=""radio"" class=""minimal-red"" name=""boitype"">
								<label class=""custom-control-label-sm"" style=""margin-left:7px;margin-right:15px;font-weight: normal""
									   for=""boitype"">Spare Part</label>
								<input type=""radio"" class=""minimal-red"" name=""boitype"">
								<label class=""custom-control-label-sm"" style=""margin-left:7px;margin-right:15px;font-weight: normal""
									   for=""boitype"">Machine</label>
							</fieldset>
						</div>
						<div class=""form-group"">
							<label class=""col-form-label"">Baan/BOI No :</label>
							<input type=""text"" class=""form-control"" id=""boino"" placeholder=""Baan/BOI No"">
						</div>
						<!--def thai-->
						<div class=""form-group"">
							<label class=""col-form-label"">Definition (Thai) :</label>
							<input type=""text"" class=""form-control"" id=""defthai"" placeholder=""Definition (Thai)"">
						</div>
	");
                WriteLiteral(@"					<!--def eng-->
						<div class=""form-group"">
							<label class=""col-form-label"">Definition (Eng) :</label>
							<input type=""text"" class=""form-control"" id=""defeng"" placeholder=""Definition (Eng)"">
						</div>
						<!--def-->
						<div class=""form-group"">
							<label class=""col-form-label"">Description :</label>
							<input type=""text"" class=""form-control"" id=""des"" placeholder=""description"">
						</div>
						<!--Unit-->
						<div class=""form-group"">
							<label class=""col-form-label"">Unit :</label>
							<input type=""text"" class=""form-control"" id=""unit"" placeholder=""Unit"">
						</div>
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
            BeginContext(5263, 258, true);
            WriteLiteral(@"
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
					<button type=""button"" class=""btn btn-primary"">Update</button>
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
