#pragma checksum "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c6f8c36f29eae2040aeeacf92b3482b0989c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_Shipto), @"mvc.1.0.view", @"/Views/MasterData/Shipto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/Shipto.cshtml", typeof(AspNetCore.Views_MasterData_Shipto))]
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
#line 1 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c6f8c36f29eae2040aeeacf92b3482b0989c2a", @"/Views/MasterData/Shipto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_Shipto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addshiptolistfrom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
  
	Layout = "_Homes";
	int num = 1;

#line default
#line hidden
            BeginContext(64, 1024, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Ship To</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Ship To List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div class=""tab-content"">
						<div class=""active tab-pane"" id=""shipperlist"">
							<table id=""tbl1"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th>Item</th>
										<th>Ship to</th>
										<th>Company</th>
										<th>Address</th>
										<th>TAX ID</th>
										<th>Full Company</th>
										<th>Full Address</th>
										<th>TEL</th>
										<th>FAX</th>

										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
");
            EndContext();
#line 39 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                     foreach (DataRow rows in Model.Rows)
									{

#line default
#line hidden
            BeginContext(1148, 70, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 50px;text-align: center\">");
            EndContext();
            BeginContext(1219, 3, false);
#line 42 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                                                                  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 62, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 150px;text-align: center\">");
            EndContext();
            BeginContext(1285, 14, false);
#line 43 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                                                                   Write(rows["shipto"]);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1322, 15, false);
#line 44 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["company"]);

#line default
#line hidden
            EndContext();
            BeginContext(1337, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1360, 15, false);
#line 45 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["address"]);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1398, 13, false);
#line 46 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["taxid"]);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1434, 19, false);
#line 47 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["fullCompany"]);

#line default
#line hidden
            EndContext();
            BeginContext(1453, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1476, 19, false);
#line 48 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["fullAddress"]);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1518, 11, false);
#line 49 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["tel"]);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1552, 11, false);
#line 50 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
                                           Write(rows["fax"]);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 609, true);
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
#line 62 "C:\EX\BOIMVC\Views\MasterData\Shipto.cshtml"
										num++;

									}

#line default
#line hidden
            BeginContext(2204, 128, true);
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- /.tab-pane -->\r\n\r\n\t\t\t\t\t\t<div class=\"tab-pane\" id=\"newitem\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2332, 2621, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c11b6c5f8584224a1d4165b20db8a0b", async() => {
                BeginContext(2385, 2561, true);
                WriteLiteral(@"
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Ship to</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""Shipto"" id=""Shipto"" placeholder=""Ship to"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputEmail"" class=""col-sm-2 control-label"">Company</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""Company"" id=""Company"" placeholder=""Company"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Address</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""Address"" id=""Address"" placeholder=""Address"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">TAX ID</label>
									<div class=""col-sm-8"">
										<input type=""text"" cl");
                WriteLiteral(@"ass=""form-control"" name=""TAXID"" id=""TAXID"" placeholder=""TAX ID"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Full Companys</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""FullCompany"" id=""FullCompany"" placeholder=""Full Company"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Full Address</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""FullAddress"" id=""FullAddress"" placeholder=""FullAddress"">
									</div>
								</div>

								<div class=""form-group"">

									<label for=""inputName"" class=""col-sm-2 control-label"">TEL</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""TEL"" id=""TEL"" placeholder=""TEL"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""");
                WriteLiteral(@"inputName"" class=""col-sm-2 control-label"">FAX</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""FAX"" id=""FAX"" placeholder=""FAX"">
									</div>
								</div>

								<div class=""col-sm-2""></div>
								<div class=""form-group"">
									<div class=""col-sm-offset-2 col-sm-10"">
										<button type=""button"" onclick=""SaveData('addshiptolistfrom','ShipTo','SavesShipTolist')"" class=""btn btn-success"">Save</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4953, 551, true);
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
				<h4 class=""modal-title"">Update Ship To  List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(5504, 2042, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b3c1e613a4f059ac016643d6559c4", async() => {
                BeginContext(5534, 2005, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Ship to</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Ship to"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputEmail"" class=""col-sm-2 control-label"">Company</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""description"" placeholder=""Company"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Address</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Address"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">TAX ID</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""TAX ID"">
						</div>
					</div>
					<div class=""form-g");
                WriteLiteral(@"roup"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Full Company</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Country Code"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Full Address</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Zip code"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">TEL</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""TEL"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">FAX</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""FAX"">
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
            BeginContext(7546, 324, true);
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