#pragma checksum "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a29f78c8b116b3687a81d53fdcb23a5c27f38d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterData_Delivery), @"mvc.1.0.view", @"/Views/MasterData/Delivery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterData/Delivery.cshtml", typeof(AspNetCore.Views_MasterData_Delivery))]
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
#line 1 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a29f78c8b116b3687a81d53fdcb23a5c27f38d83", @"/Views/MasterData/Delivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterData_Delivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("adddeliverylistfrom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
  
	Layout = "_Homes";
	int num = 1;

#line default
#line hidden
            BeginContext(83, 1023, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
	<section class=""content-header"">
		<h1><i class=""fa fa-handshake-o""></i> Delivery</h1>
	</section>
	<section class=""content"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""nav-tabs-custom"">
					<ul class=""nav nav-tabs"">
						<li class=""active""><a href=""#shipperlist"" data-toggle=""tab"">Delivery List</a></li>
						<li><a href=""#newitem"" data-toggle=""tab"">New Item</a></li>
					</ul>
					<div class=""tab-content"">
						<div class=""active tab-pane"" id=""shipperlist"">
							<table id=""tblist"" class=""table table-bordered table-hover"">
								<thead class=""p-3 mb-2 bg-info text-white text-center"">
									<tr>
										<th style=""display: none""></th>
										<th style=""display: none""></th>
										<th>Item</th>
										<th>Delivery Term</th>
										<th>Meaning</th>
										<th>AIR</th>
										<th>SEA</th>
										<th>TRUCK</th>
										<th></th>
										<th></th>
									</tr>
								</thead>
								<tbody>
");
            EndContext();
#line 38 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                     foreach (DataRow rows in Model.Rows)
									{

#line default
#line hidden
            BeginContext(1166, 53, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"display: none\">");
            EndContext();
            BeginContext(1220, 7, false);
#line 41 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                                                 Write(rows[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 111, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"display: none\">tbname</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 50px;text-align: center\">");
            EndContext();
            BeginContext(1339, 3, false);
#line 43 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                                                                  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 62, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"width: 150px;text-align: center\">");
            EndContext();
            BeginContext(1405, 20, false);
#line 44 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                                                                   Write(rows["deliveryterm"]);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1448, 15, false);
#line 45 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                           Write(rows["meaning"]);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1486, 11, false);
#line 46 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                           Write(rows["air"]);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1520, 11, false);
#line 47 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                           Write(rows["sea"]);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1554, 13, false);
#line 48 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"
                                           Write(rows["truck"]);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 611, true);
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
#line 61 "C:\Users\Yut\Desktop\AllFile\BOIMVCtest\BOI\Views\MasterData\Delivery.cshtml"

									   num++;
									}

#line default
#line hidden
            BeginContext(2212, 132, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- /.tab-pane -->\r\n\r\n\r\n\t\t\t\t\t\t<div class=\"tab-pane\" id=\"newitem\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2344, 1765, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1505d3c905c4404f8e0137680ef51e6a", async() => {
                BeginContext(2399, 1703, true);
                WriteLiteral(@"
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">Delivery Term</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""Deliveryterm"" id=""Deliveryterm"" placeholder=""Delivery Term"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputEmail"" class=""col-sm-2 control-label"">Meaning</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""Meaning"" id=""Meaning"" placeholder=""Meaning"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">AIR</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""AIR"" id=""AIR"" placeholder=""AIR"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">SEA</label>
									<div class=""col-sm-8"">
										<input type=""tex");
                WriteLiteral(@"t"" class=""form-control"" name=""SEA"" id=""SEA"" placeholder=""SEA"">
									</div>
								</div>
								<div class=""form-group"">
									<label for=""inputName"" class=""col-sm-2 control-label"">TRUCK</label>
									<div class=""col-sm-8"">
										<input type=""text"" class=""form-control"" name=""TRUCK"" id=""TRUCK"" placeholder=""TRUCK"">
									</div>
								</div>

								<div class=""col-sm-2""></div>
								<div class=""form-group"">
									<div class=""col-sm-offset-2 col-sm-10"">
										<button type=""button"" onclick=""SaveData('adddeliverylistfrom','Delivery','SavesDeliverylist')"" class=""btn btn-success"">Save</button>
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
            BeginContext(4109, 552, true);
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
				<h4 class=""modal-title"">Update Delivery  List</h4>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(4661, 1289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e65359c0cb542ca95f978e2e4b2f9e2", async() => {
                BeginContext(4691, 1252, true);
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">Delivery Term</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""Delivery Term"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputEmail"" class=""col-sm-2 control-label"">Meaning</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""description"" placeholder=""Meaning"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">AIR</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""AIR"">
						</div>
					</div>
					<div class=""form-group"">
						<label for=""inputName"" class=""col-sm-2 control-label"">SEA</label>
						<div class=""col-sm-8"">
							<input type=""text"" class=""form-control"" id=""shipper"" placeholder=""SEA"">
						</div>
					</div>
					<div class=""form-gro");
                WriteLiteral("up\">\r\n\t\t\t\t\t\t<label for=\"inputName\" class=\"col-sm-2 control-label\">TRUCK</label>\r\n\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"shipper\" placeholder=\"TRUCK\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t");
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
            BeginContext(5950, 310, true);
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
