#pragma checksum "C:\EX\BOIMVC\Views\DraftConfirmation\DraftConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dda62a31615e28fed02b76b554c530a822cd3a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DraftConfirmation_DraftConfirmation), @"mvc.1.0.view", @"/Views/DraftConfirmation/DraftConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DraftConfirmation/DraftConfirmation.cshtml", typeof(AspNetCore.Views_DraftConfirmation_DraftConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dda62a31615e28fed02b76b554c530a822cd3a0", @"/Views/DraftConfirmation/DraftConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe2f4f5b927e04f0a6ace7eeb415a735a12918", @"/Views/_ViewImports.cshtml")]
    public class Views_DraftConfirmation_DraftConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\EX\BOIMVC\Views\DraftConfirmation\DraftConfirmation.cshtml"
  
	Layout = "_Homes";

#line default
#line hidden
            BeginContext(30, 574, true);
            WriteLiteral(@"<div class=""content-wrapper"">
	<div class=""col-md-12"">

		<section class=""content"">
			<div class=""row"">
				<div class=""col-md-3"">
					<div class=""box box-solid"">
						<div class=""box-header with-border"">
							<h3 class=""box-title"">Shipping</h3>
							<div class=""box-tools"">
								<button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
									<i class=""fa fa-minus""></i>
								</button>
							</div>
						</div>
						<div class=""box-body no-padding"">
							<select class=""form-control select2"" style=""width: 100%;"">
								");
            EndContext();
            BeginContext(604, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4eebc1c193432991021d3fc31fc6c7", async() => {
                BeginContext(612, 8, true);
                WriteLiteral("DIGI-KEY");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(629, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(639, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579e782367ca4c3394758a04a99e6d47", async() => {
                BeginContext(647, 6, true);
                WriteLiteral("MOUSER");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(662, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(672, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77c6da385e494d04a49ddf1d576f3844", async() => {
                BeginContext(680, 7, true);
                WriteLiteral("ON SEMI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(696, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(706, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232db2e9c78547d396d2dd800027e6d5", async() => {
                BeginContext(714, 8, true);
                WriteLiteral("SANSHINE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(731, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(741, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23dff86cf4af47c0ad9d28c264c01dd6", async() => {
                BeginContext(749, 8, true);
                WriteLiteral("SPECTRUM");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(766, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(776, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0c387665e04f9f99dbcaffd94e5569", async() => {
                BeginContext(784, 9, true);
                WriteLiteral("UNISEM MY");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(802, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(812, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4160ae0f372a418e9960efbc55a89ab5", async() => {
                BeginContext(820, 6, true);
                WriteLiteral("HI-REL");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(835, 532, true);
            WriteLiteral(@"
							</select>
						</div>
					</div>
					<!-- /. box -->
					<div class=""box box-solid"">
						<div class=""box-header with-border"">
							<h3 class=""box-title"">Job No</h3>
							<div class=""box-tools"">
								<button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
									<i class=""fa fa-minus""></i>
								</button>
							</div>
						</div>
						<!-- /.box-header -->
						<div class=""box-body no-padding"">
							<select class=""form-control select2"" style=""width: 100%;"">
								");
            EndContext();
            BeginContext(1367, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7631eb133abd4b0495de84fac03fe1f3", async() => {
                BeginContext(1375, 11, true);
                WriteLiteral("J1808-00001");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1395, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1405, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab30e021b384245ac8372c5c675789d", async() => {
                BeginContext(1413, 11, true);
                WriteLiteral("J1808-00002");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1433, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1443, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462cb2258eb44ed19cf93d26a9d2ba9c", async() => {
                BeginContext(1451, 11, true);
                WriteLiteral("J1808-00003");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1471, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1481, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40dc5e089c7c4e6baa649812bbe329a6", async() => {
                BeginContext(1489, 11, true);
                WriteLiteral("J1808-00004");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1509, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1519, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfbb216f07142f1b91b670f864ee5bf", async() => {
                BeginContext(1527, 11, true);
                WriteLiteral("J1808-00005");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1547, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1557, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb4ceaddc9e48ee9148af5223e4cab7", async() => {
                BeginContext(1565, 11, true);
                WriteLiteral("J1808-00006");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1585, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1595, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ea14b93c294c8d8f4f1474dc800b91", async() => {
                BeginContext(1603, 11, true);
                WriteLiteral("J1808-00007");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 1719, true);
            WriteLiteral(@"
							</select>
						</div>
					</div>
					<!-- /. box -->
					<div class=""box box-danger collapsed-box  box-solid"">
						<div class=""box-header with-border"">
							<h3 class=""box-title"">Incorrect Item</h3>
							<div class=""box-tools"">
								<button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
									<i class=""fa fa-plus""></i>
								</button>
							</div>
						</div>
						<!-- /.box-header -->
						<div class=""box-body no-padding"">
							<table class=""table"">
								<thead class=""invisible"">
									<tr>
										<th class=""text-center"" style=""width:20px""></th>
									</tr>
								</thead>
								<tr>
									<td><input type=""checkbox""></td>
									<td class=""text-left font-light"">Missing shipping mark</td>
								</tr>
								<tr>
									<td><input type=""checkbox""></td>
									<td class=""text-left font-light"">Wrong consignee</td>
								</tr>
								<tr>
									<td><input type=""checkbox""></td>
									<td class=""text-");
            WriteLiteral(@"left font-light"">Wrong invoice no.</td>
								</tr>
								<tr>
									<td><input type=""checkbox""></td>
									<td class=""text-left font-light"">Wrong BOI License Date</td>
								</tr>
							</table>
						</div>
					</div>
					<!-- /.box-body -->
					<div class=""box box-info collapsed-box box-solid"">
						<div class=""box-header with-border"">
							<h3 class=""box-title"">CIF Calculation</h3>
							<div class=""box-tools"">
								<button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
									<i class=""fa fa-plus""></i>
								</button>
							</div>
						</div>
						<!-- /.box-header -->
						<div class=""box-body no-padding"">
							");
            EndContext();
            BeginContext(3342, 2383, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82c5274d08a249ba821ed32da87c9f47", async() => {
                BeginContext(3348, 2370, true);
                WriteLiteral(@"
								<table cellspacing=""0"" cellpadding=""3"" width=""95%"">
									<thead class=""invisible"">
										<tr>
											<th style=""width: 50%"">Item</th>
											<th></th>
										</tr>
									</thead>
									<tr>
										<td style=""padding-left: 5px"" class=""pull-left"">Invoice Value</td>
										<td><input type=""text"" class=""form-control pull-right text-right""></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">Insurance</td>
										<td><input type=""text"" class=""form-control pull-right text-right""></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">Freight Paid</td>
										<td><input type=""text"" class=""form-control pull-right text-right""></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">Total CIF</td>
										<td><input type=""text"" class=""form-control pull-right text-right"" readonly=true></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">% Duty Rate</td>
										<td>");
                WriteLiteral(@"<input type=""text"" class=""form-control pull-right text-right""></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">Duty Charge</td>
										<td><input type=""text"" class=""form-control pull-right text-right"" readonly=true></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">CIF+Duty</td>
										<td><input type=""text"" class=""form-control pull-right text-right"" readonly=true></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">%VAT</td>
										<td><input type=""text"" class=""form-control pull-right text-right""></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">VAT Charge</td>
										<td><input type=""text"" class=""form-control pull-right text-right"" readonly=true></td>
									</tr>
									<tr>
										<td style=""padding-left: 5px"">Total</td>
										<td><input type=""text"" class=""form-control pull-right text-right"" readonly=true></td>
									</tr>
								</table>
								<!---->
					");
                WriteLiteral(@"			<div style=""padding-right: 15px; padding-top:10px; padding-bottom: 5px"">
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
            BeginContext(5725, 1478, true);
            WriteLiteral(@"
						</div>
						<!-- /.box-body -->
					</div>
					<!-- /.box -->
				</div>
				<!-- /.col -->
				<div class=""col-md-9"">
					<div class=""box box-primary"">
						<div class=""box-header with-border"">
							<h3 class=""box-title"">Draft Confirmation</h3>
						</div>
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
								</div>
								<p class=""help-block"">Max. 32MB</p>
							</div>
						</div>
						<!-- /.box-body -->
		");
            WriteLiteral(@"				<div class=""box-footer"">
							<div class=""pull-right"">
								<button type=""button"" class=""btn btn-default""><i class=""fa fa-pencil""></i> Draft</button>
								<button type=""submit"" class=""btn btn-primary""><i class=""fa fa-envelope-o""></i> Send</button>
							</div>
						</div>
						<!-- /.box-footer -->
					</div>
					<!-- /. box -->
				</div>
				<!-- /.col -->
			</div>
			<!-- /.row -->
		</section>
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
