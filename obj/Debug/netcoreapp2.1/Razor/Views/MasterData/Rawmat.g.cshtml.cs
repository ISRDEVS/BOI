#pragma checksum "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd89c3bec7ae71bab11bec1f626aae6129f512a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_Rawmat), @"mvc.1.0.view", @"/Views/MasterData/Rawmat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/Rawmat.cshtml", typeof(AspNetCore.Views_MasterData_Rawmat))]
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
#line 1 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd89c3bec7ae71bab11bec1f626aae6129f512a1", @"/Views/MasterData/Rawmat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_Rawmat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fromaddrawmat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
  
	Layout = "_HOmes";
	int num = 1;

#line default
#line hidden
            BeginContext(83, 1124, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Raw Material</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Raw Material List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div class=""tab-content"">
						<div class=""active tab-pane"" id=""shipperlist"">
							<table id=""rawmattable"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>ชื่อรอง</th>
										<th>รายการที่</th>
										<th>หน่วย</th>
										<th>คำอธิบาย</th>
										<th>พิกัด</th>
										<th>พิกัด</th>
										<th>หน่วยงานใบอนุญาต</th>
										<th>Number</th>
										<th>รหัสสถิติ</th>
										<th>ประเภทสิ่งของที่ต้องมีใบอนุญาต");
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t\t\t<th></th>\r\n\t\t\t\t\t\t\t\t\t\t<th></th>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t\t\t<tbody>\r\n");
            EndContext();
#line 41 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                     foreach (DataRow rows in Model.Rows)
									{

#line default
#line hidden
            BeginContext(1267, 117, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr *ngFor=\"let item of rawmatlist; let i = index\">\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 50px;text-align: center\">");
            EndContext();
            BeginContext(1385, 3, false);
#line 44 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                                                                  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 62, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 150px;text-align: center\">");
            EndContext();
            BeginContext(1451, 14, false);
#line 45 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                                                                   Write(rows["byname"]);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1488, 13, false);
#line 46 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["items"]);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1524, 12, false);
#line 47 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["unit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1536, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1559, 22, false);
#line 48 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["description_TH"]);

#line default
#line hidden
            EndContext();
            BeginContext(1581, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1604, 20, false);
#line 49 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["coordinates1"]);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1647, 20, false);
#line 50 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["coordinates2"]);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1690, 21, false);
#line 51 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["licenseagency"]);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1734, 14, false);
#line 52 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["number"]);

#line default
#line hidden
            EndContext();
            BeginContext(1748, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1771, 17, false);
#line 53 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["statistic"]);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1811, 20, false);
#line 54 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
                                           Write(rows["typeslicense"]);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 607, true);
            WriteLiteral(@"</td>
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
");
            EndContext();
#line 65 "C:\EX\BOIMVC\Views\MasterData\Rawmat.cshtml"
										num++;

									}

#line default
#line hidden
            BeginContext(2470, 128, true);
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- /.tab-pane -->\r\n\r\n\t\t\t\t\t\t<div class=\"tab-pane\" id=\"newitem\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2598, 3281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b630e3e9539b4b1b9b852c94714627a6", async() => {
                BeginContext(2647, 3225, true);
                WriteLiteral(@"
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">ชื่อรอง</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""byname"" id=""byname"" placeholder=""ชื่อรอง"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">รายการที่</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""items"" id=""items"" placeholder=""รายการที่"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">หน่วย</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""unit"" id=""unit"" placeholder=""หน่วย"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">คำอธิบาย</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form");
                WriteLiteral(@"-control"" name=""description_TH"" id=""description_TH"" placeholder=""คำอธิบาย"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">พิกัด</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""coordinates1"" id=""coordinates1"" placeholder=""พิกัด"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">พิกัด</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""coordinates2"" id=""coordinates2"" placeholder=""พิกัด"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">หน่วยงานใบอนุญาต</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""licenseagency"" id=""licenseagency"" placeholder=""หน่วยงานใบอนุญาต"">
									</div>
								</div>
								<div class=""form-g");
                WriteLiteral(@"roup"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Number</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""number"" id=""number"" placeholder=""Number"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">รหัสสถิติ</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""statistic"" id=""statistic"" placeholder=""รหัสสถิติ"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">ประเภทสิ่งของที่ต้องมีใบอนุญาต</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""typeslicense"" id=""typeslicense"" placeholder=""ประเภทสิ่งของที่ต้องมีใบอนุญาต"">
									</div>
								</div>

								<div class=""col-sm-2""></div>
								<div class=""form-group"">
									<div class=""col-sm-offset-2 col-sm-10"">
										<button ty");
                WriteLiteral("pe=\"button\" onclick=\"SaveData(\'fromaddrawmat\',\'MasterData\',\'SaveRawmat\')\" class=\"btn btn-success\">Save</button>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5879, 560, true);
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
				<h4 class=""modal-title"">Update Raw Mat Terial  List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(6439, 2595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f91439b7ba8423cbde257d8e8fd0fdc", async() => {
                BeginContext(6469, 2558, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">ชื่อรอง</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""ชื่อรอง"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">รายการที่</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""รายการที่"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">หน่วย</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""หน่วย"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">คำอธิบาย</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""คำอธิบาย"">
						</div>
					</div>
					<div class=""form-gr");
                WriteLiteral(@"oup"">
						<label for=""inputName"" class=""col-sm-2 control-label"">พิกัด</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""พิกัด"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">พิกัด</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""พิกัด"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">หน่วยงานใบอนุญาต</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""หน่วยงานใบอนุญาต"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Number</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Number"">
						</div>
					</div>
					<div class=""form-group"">
						<label ");
                WriteLiteral(@"for=""inputName"" class=""col-sm-2 control-label"">รหัสสถิติ</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""รหัสสถิติ"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">ประเภทสิ่งของที่ต้องมีใบอนุญาต</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""ประเภทสิ่งของที่ต้องมีใบอนุญาต"">
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
            BeginContext(9034, 310, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
