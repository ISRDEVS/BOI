#pragma checksum "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\ProjectMaster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95f83191b3e0a6d6cc4de291d43817120eb89a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_ProjectMaster), @"mvc.1.0.view", @"/Views/MasterData/ProjectMaster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/ProjectMaster.cshtml", typeof(AspNetCore.Views_MasterData_ProjectMaster))]
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
#line 1 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\_ViewImports.cshtml"
using BOIMVC;

#line default
#line hidden
#line 2 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\_ViewImports.cshtml"
using BOIMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95f83191b3e0a6d6cc4de291d43817120eb89a7", @"/Views/MasterData/ProjectMaster.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_ProjectMaster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\ProjectMaster.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 6506, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Project Master</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<!--  <button type=""button"" class=""btn btn-default"" data-toggle=""modal"" data-target=""#modal-default"">
							  Launch Default Modal
							</button> -->
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Project Master List</a></li>
						<li><a href=""#CCMYL"" data-toggle=""tab"">Certificate Capacity (MU/YEAR) List</a></li>
						<li><a href=""#CITL"" data-toggle=""tab"">CIT Capacity (THB) List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div style=""overflow-x: scroll; scrollbar-arrow-color:blue; scrollbar-face-color: #e7e7e7; scrollbar-3dlight-color: #a0a0a0; scrollbar-darkshadow-color:#888888"" class=""tab-content"">
						<div class=""active tab-pane"" id=""shippe");
            WriteLiteral(@"rlist"">
							<table id=""tblist"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th style=""display: none""></th>
										<th style=""display: none""></th>
										<th>Item</th>
										<th>MTHAI</th>
										<th>MMT</th>
										<th>Category</th>
										<th>Certificate No</th>
										<th>Date Of Certificate Approved</th>
										<th>Date Of Promotion Certificate</th>
										<th>Production Start Date</th>
										<th>The Date Of 1ST Income</th>
										<th>Length Of Income Tax Exemption</th>
										<th>Full Commencement Due Date Submitted</th>
										<th>Full Commencement Date Approved</th>
										<th>Expiration Date Of Import Machine</th>
										<th>Expiration Date Of Exemption Income</th>
										<th>Certificate Capacity (MU/YEAR)</th>
										<th>Working Time/Working Day (Hrs:day:Day)</th>
										<th>Fist Income Date</th>
										<th>Capacity  Status</th>
			");
            WriteLiteral(@"							<th>Closed Project</th>
										<th>CIT Capacity (THB)</th>
										<th>Annoucement</th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 50px;text-align: center"">1</td>
										<td style=""width: 150px;text-align: center"">08/21/2017</td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td></td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">Delete</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button ");
            WriteLiteral(@"type=""button"" class=""btn btn-link font-weight-danger"" style=""padding: 0pt"" data-toggle=""modal"" data-target=""#modal-default"">
												Update
											</button>
											<!--  <button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Update</button> -->
										</td>
									</tr>
								</tbody>
							</table>
						</div>

						<!-- /.tab-pane -->
						<div class=""tab-pane"" id=""CCMYL"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>Subject</th>
										<th>MU/YEAR</th>
										<th></th>
										<th></th>

									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 50px;text-align: center"">1</td>
										<td style=""width: 150px;text-align: center"">08/21/2017</td>
										<td></td>

										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn");
            WriteLiteral(@" btn-link font-weight-light"" style=""padding: 0pt"">Delete</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button type=""button"" class=""btn btn-link font-weight-danger"" style=""padding: 0pt"" data-toggle=""modal"" data-target=""#modal-defaultccmy"">
												Update
											</button>
											<!--  <button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Update</button> -->
										</td>
									</tr>
								</tbody>
							</table>
						</div>
						<div class="" tab-pane"" id=""CITL"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>Year</th>
										<th>THB</th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td style=""width: 50px;text-align: center"">1</td>
										<td style=""width: 150px;text-align: center"">");
            WriteLiteral(@"08/21/2017</td>
										<td></td>

										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button class=""btn btn-link font-weight-light"" style=""padding: 0pt"">Delete</button>
										</td>
										<td class=""text-center"" style=""width: 60px;text-align: center"">
											<button type=""button"" class=""btn btn-link font-weight-danger"" style=""padding: 0pt"" data-toggle=""modal"" data-target=""#modal-defaultcit"">
												Update
											</button>
											<!--  <button class=""btn btn-link font-weight-danger"" style=""padding: 0pt"">Update</button> -->
										</td>
									</tr>
								</tbody>
							</table>
						</div>
						<div class=""tab-pane"" id=""newitem"">
							<div class=""nav-tabs-custom"">
								<ul class=""nav nav-tabs"">
									<!--  <button type=""button"" class=""btn btn-default"" data-toggle=""modal"" data-target=""#modal-default"">
										  Launch Default Modal
										</button> -->
									<li class=""active""><a href=""#newitemproject"" d");
            WriteLiteral(@"ata-toggle=""tab"">Project Master</a></li>
									<li><a href=""#muyear"" data-toggle=""tab"">Certificate Capacity (MU/YEAR)</a></li>
									<li><a href=""#CIT"" data-toggle=""tab"">CIT Capacity (THB)</a></li>
								</ul>

								<div class=""tab-content"">
									<!-- /.tab-pane -->

									<div class="" active tab-pane"" id=""newitemproject"">
										");
            EndContext();
            BeginContext(6536, 6591, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4de3441080141308ae82287115144de", async() => {
                BeginContext(6566, 6554, true);
                WriteLiteral(@"
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">MTHAI</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MTHAI"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">MMT</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MMT"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Category</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Category"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Certificate No</label>
												<div class=""col-sm-8"">
													<");
                WriteLiteral(@"input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Certificate No"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Date Of Certificate Approved</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Date Of Certificate Approved"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Date Of Promotion Certificate</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Date Of Promotion Certificate"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Production Start Date</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholde");
                WriteLiteral(@"r=""Production Start Date"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">The Date Of 1ST Income</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""The Date Of 1ST Income"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Length Of Income Tax Exemption</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Length Of Income Tax Exemption"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Full Commencement Due Date Submitted</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Full Commencement Due Date Submitted"">
							");
                WriteLiteral(@"					</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Full Commencement Date Approved</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Full Commencement Date Approved"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Expiration Date Of Import Machine</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Expiration Date Of Import Machine"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Expiration Date Of Exemption Income</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Expiration Date Of Exemption Income"">
												</div>
");
                WriteLiteral(@"											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Certificate Capacity (MU/YEAR)</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Certificate Capacity (MU/YEAR)"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Working Time/Working Day (Hrs:day:Day)</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Working Time/Working Day (Hrs:day:Day)"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Fist Income Date</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Fist Income Date"">
												</div>
											</div>
											<div class=""f");
                WriteLiteral(@"orm-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Capacity  Status</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Capacity  Status"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Closed Project</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Closed Project"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">CIT Capacity (THB)</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""CIT Capacity (THB)"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Annoucement</label>
												<di");
                WriteLiteral(@"v class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Annoucement"">
												</div>
											</div>

											<div class=""col-sm-2""></div>
											<div class=""form-group"">
												<div class=""col-sm-offset-2 col-sm-10"">
													<button type=""submit"" class=""btn btn-success"">Save</button>
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
            BeginContext(13127, 74, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"tab-pane\" id=\"muyear\">\r\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(13201, 867, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec0259afd469404c8d601e7fe8fee71e", async() => {
                BeginContext(13231, 830, true);
                WriteLiteral(@"
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Subject</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Subject"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">MU/YEAR</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MU/YEAR"">
												</div>
											</div>


											<div class=""col-sm-2""></div>
											<div class=""form-group"">
												<div class=""col-sm-offset-2 col-sm-10"">
													<button type=""submit"" class=""btn btn-success"">Save</button>
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
            BeginContext(14068, 71, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"tab-pane\" id=\"CIT\">\r\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(14139, 856, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2467877ddf684d5aabc5e671f5a669dc", async() => {
                BeginContext(14169, 819, true);
                WriteLiteral(@"
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">Year</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Year"">
												</div>
											</div>
											<div class=""form-group"">
												<label for=""inputName"" class=""col-sm-2 control-label"">THB</label>
												<div class=""col-sm-8"">
													<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MU/THB"">
												</div>
											</div>


											<div class=""col-sm-2""></div>
											<div class=""form-group"">
												<div class=""col-sm-offset-2 col-sm-10"">
													<button type=""submit"" class=""btn btn-success"">Save</button>
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
            BeginContext(14995, 660, true);
            WriteLiteral(@"
									</div>
									<!-- /.tab-pane -->
								</div>
								<!-- /.tab-content -->
							</div>
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
				<h4 class=""modal-title"">Project Master List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(15655, 5623, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c660c6344d4653aa83fb556d163731", async() => {
                BeginContext(15685, 5586, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">MTHAI</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MTHAI"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">MMT</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MMT"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Category</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Category"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Certificate No</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Certificate No"">
						</div>
					</div>
					<div class=""form-");
                WriteLiteral(@"group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Date Of Certificate Approved</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Date Of Certificate Approved"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Date Of Promotion Certificate</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Date Of Promotion Certificate"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Production Start Date</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Production Start Date"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">The Date Of 1ST Income</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=");
                WriteLiteral(@"""form-control"" id=""shipper"" placeholder=""The Date Of 1ST Income"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Length Of Income Tax Exemption</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Length Of Income Tax Exemption"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Full Commencement Due Date Submitted</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Full Commencement Due Date Submitted"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Full Commencement Date Approved</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Full Commencement Date Approved"">
						</div>
					</div>
					<div class=""form-group"">
");
                WriteLiteral(@"						<label for=""inputName"" class=""col-sm-2 control-label"">Expiration Date Of Import Machine</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Expiration Date Of Import Machine"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Expiration Date Of Exemption Income</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Expiration Date Of Exemption Income"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Certificate Capacity (MU/YEAR)</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Certificate Capacity (MU/YEAR)"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Working Time/Working Day (Hrs:day:Day)</label>
						<div clas");
                WriteLiteral(@"s=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Working Time/Working Day (Hrs:day:Day)"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Fist Income Date</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Fist Income Date"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Capacity  Status</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Capacity  Status"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Closed Project</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Closed Project"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col");
                WriteLiteral(@"-sm-2 control-label"">CIT Capacity (THB)</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""CIT Capacity (THB)"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Annoucement</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Annoucement"">
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
            BeginContext(21278, 707, true);
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
<!-- /.modal -->

<div class=""modal fade"" id=""modal-defaultccmy"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				<h4 class=""modal-title"">Project Master List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(21985, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "961a8ccd400745259dc7aa2c82aed63e", async() => {
                BeginContext(22015, 510, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Subject</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Subject"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">MU/YEAR</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MU/YEAR"">
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
            BeginContext(22532, 706, true);
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
<!-- /.modal -->

<div class=""modal fade"" id=""modal-defaultcit"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				<h4 class=""modal-title"">Project Master List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(23238, 536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996c8ce59a4940b4852055b4f28cd5cb", async() => {
                BeginContext(23268, 499, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Year</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Year"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">THB</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""MU/THB"">
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
            BeginContext(23774, 324, true);
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
<!-- /.modal -->
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
