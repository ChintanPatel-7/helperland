#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff1e650af2c15d4b381bace47fc8406872e54ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ServiceRequests), @"mvc.1.0.view", @"/Views/Admin/ServiceRequests.cshtml")]
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
#nullable restore
#line 1 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff1e650af2c15d4b381bace47fc8406872e54ae", @"/Views/Admin/ServiceRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ServiceRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
  
    ViewData["Title"] = "Service Requests";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex"">
    <h2 class=""page-title mt-auto mb-auto"">Service Requests</h2>
</div>
<div class=""user-search-box"">

    <input type=""text"" class=""form-control input-element width-110"" id=""ServiceRequestId"" placeholder=""Service Id"">

    <input type=""text"" class=""form-control input-element width-152"" id=""CustomerName"" placeholder=""Customer Name"" />

    <input type=""text"" class=""form-control input-element width-205"" id=""ServiceProviderName"" placeholder=""Service Provider Name"" />

");
            WriteLiteral("\r\n    <select class=\"form-select input-element width-120\" id=\"Status\" aria-label=\"User role\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae6560", async() => {
                WriteLiteral("Status");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae8038", async() => {
                WriteLiteral("New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae9202", async() => {
                WriteLiteral("Pending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae10370", async() => {
                WriteLiteral("Cancelled");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae11541", async() => {
                WriteLiteral("Completed");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </select>

    <input type=""text"" id=""txtFromDate"" placeholder=""From Date"" onfocus=""(this.type='date')"" class=""calender-icon form-control input-element width-135"">
    <!-- <input type=""date"" class=""form-control input-element width-135"" id=""""> -->

    <input type=""text"" id=""txtToDate"" placeholder=""To Date"" class=""calender-icon form-control input-element width-135"" onfocus=""(this.type='date')"">
    <!-- <input type=""date"" class=""form-control input-element width-135"" id=""""> -->

    <button class=""btn btn-Search width-84"" onclick=""SearchUser()"">Search</button>

    <button class=""btn width-84 btn-clear"" type=""reset"" onclick=""ResetSearchData()"">Clear</button>

</div>

<div class=""data-table"">
    <table id=""tblServiceRequests"">
        <thead>
            <tr>
                <th>Service ID<img class=""sort-img""");
            BeginWriteAttribute("alt", " alt=\"", 2407, "\"", 2413, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>Service Date<img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 2475, "\"", 2481, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>Customer details<img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 2547, "\"", 2553, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>Service provider<img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 2619, "\"", 2625, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>Status<img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 2681, "\"", 2687, 0);
            EndWriteAttribute();
            WriteLiteral(@"></th>
                <th>Actions</th>
            </tr>
        </thead>
    </table>
</div>

<!-- Address Modal -->
<div class=""modal"" id=""EditServiceRequestModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""mb-3 mt-1"">
                    Edit Service Request
                    <input type=""hidden"" id=""HiddenServiceRequestId"" />
                </h3>
                <div id=""ErrorMessageEditServiceRequestModel""></div>
                <div class=""row"">
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Date</label>
                        <input type=""date"" id=""ServiceDate"" placeholder=""Service Date"" class=""calender-icon form-cont");
            WriteLiteral(@"rol input-element"">
                        <span id=""ErrorMessageServiceDate"" class=""text-danger""></span>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Time</label>
                        <select class=""form-select m-0"" id=""ServiceTime"" name=""ServiceTime"">
");
#nullable restore
#line 87 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
                             for (double i = 8; i <= 18; i = i + 0.5)
                            {
                                string[] number = i.ToString().Split(".");

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff1e650af2c15d4b381bace47fc8406872e54ae16435", async() => {
                WriteLiteral(" ");
#nullable restore
#line 90 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
                                               Write(number[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 90 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
                                                           Write(number.Length == 2? "30" : "00");

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\ServiceRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-md-12 mb-1"">
                        <label class=""fw-bold"">Service Address</label>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Street name</label>
                        <input type=""text"" class=""form-control"" placeholder=""Street name"" id=""StreetName"" name=""StreetName"">
                        <span id=""ErrorMessageStreetName"" class=""text-danger""></span>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">House number</label>
                        <input type=""text"" class=""form-control"" placeholder=""House number"" id=""HouseNumber"" name=""HouseNumber"">
                        <span id=""ErrorMessageHouseNumber"" class=""text-danger""></span>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
     ");
            WriteLiteral(@"                   <label class=""form-label"">Postal code</label>
                        <input type=""text"" class=""form-control"" placeholder=""Postal code"" id=""PostalCode"" name=""PostalCode"">
                        <span id=""ErrorMessagePostalCode"" class=""text-danger""></span>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">City</label>
                        <select class=""form-select m-0"" id=""City"" name=""City"">
                        </select>
");
            WriteLiteral(@"                    </div>
                    <div class=""col-sm-12 col-md-12 mb-3"">
                        <label class=""form-label"">Why do you want to reschedule service request?</label>
                        <textarea class=""form-control"" id=""Reason"" placeholder=""Why do you want to reschedule service request?"" rows=""3""></textarea>
                        <span id=""ErrorMessageReason"" class=""text-danger""></span>
                    </div>
                    <div class=""col-md-12"">
                        <button class=""button-lightBlue w-100"" onclick=""UpdateServiceRequest()"">
                            Update
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

            $('#tblServiceRequests').on('draw.dt', function () { //every time ajax call, this code execute
                $("".spRating"").rating({
                    min: 0,
                    max: 5,
                    step: 0.1,
                    size: ""xs"",
                    stars: ""5"",
                    showClear: false,
                    readonly: true,
                    starCaptions: function (val) {
                        return val;
                    },
                    starCaptionClasses: function () {
                        return ""rating-count"";
                    },
                });
            });

            $('#tblServiceRequests').DataTable({
                paging: true,
                processing: true,
                serverSide: true,
                filter: true,
                ordering: true,
                searching: false,
                info: true,
");
                WriteLiteral(@"                ajax: {
                    url: ""/Admin/GetServiceRequestList"",
                    type: ""POST"",
                    datatype: ""json"",
                    dataSrc: 'data',
                    ""data"": function (d) {
                        d.searchServiceRequestId = $(""#ServiceRequestId"").val();
                        d.searchCustomerName = $(""#CustomerName"").val();
                        d.searchServiceProviderName = $(""#ServiceProviderName"").val();
                        d.searchStatus = $(""#Status"").val();
                        d.searchServiceStartDate = $(""#txtFromDate"").val();
                        d.searchServiceEndDate = $(""#txtToDate"").val();
                    }
                },
                oLanguage: {
                    sInfo: ""Total Records: _TOTAL_"",
                    sProcessing: ""<div id='preloader'><div id='loader'></div></div>""
                },
                ""columnDefs"": [
                    { ""orderable"": false, ""targets"": 5 }
     ");
                WriteLiteral(@"           ],
                columns: [
                    {
                        data: 'serviceRequestId',
                        name: 'ServiceRequestId',
                    },
                    {
                        name: 'ServiceStartDate',
                        render: function (data, type, row) {
                            return ""<img src='../img/admin-panel/calendar2.png' alt='calender' class='me-1'><span> "" +
                                DateFormatDDMMYYYY(row.serviceStartDate) + ""</span><br/>"" +
                                ""<img src='../img/admin-panel/layer-14.png' alt='clock' class='me-1'> "" +
                                ServiceTime(row.serviceStartDate, 0) + "" - "" + ServiceTime(row.serviceStartDate, row.serviceHours);
                        }
                    },
                    {
                        name: 'Customer',
                        render: function (data, type, row) {
                            return ""<div class='align-items-cent");
                WriteLiteral(@"er d-flex'><img src='../img/admin-panel/layer-15.png' class='me-2'><div>"" +
                                row.user.firstName + "" "" + row.user.lastName + ""<br>"" + row.serviceRequestAddresses[0].addressLine1 + "" "" +
                                row.serviceRequestAddresses[0].addressLine2 + ""<br>"" + row.serviceRequestAddresses[0].postalCode + "" "" +
                                row.serviceRequestAddresses[0].city + ""</div></div>"";
                        }
                    },
                    {
                        name: 'ServiceProvider',
                        render: function (data, type, row) {
                            console.log(row);
                            if (row.serviceProvider == null) {
                                return """";
                            }
                            else {
                                var totalRating = 0;
                                var spRating = 0;
                                var count = 0;

                  ");
                WriteLiteral(@"              row.serviceProvider.ratingRatingToNavigations.forEach(function (element) {
                                    totalRating = totalRating + element.ratings;
                                    count = count + 1;
                                });

                                if (count == 0) {
                                    return ""<div><img src='"" + row.serviceProvider.userProfilePicture + ""' class='cap-img float-start' alt='cap image'> "" +
                                        ""<div class='name-rating'> <label>"" + row.serviceProvider.firstName + "" "" + row.serviceProvider.lastName + ""</label> <div> "" + ""Not Rated"";
                                }

                                spRating = (totalRating / count);

                                var spRatingRounded = Math.round(spRating * 10) / 10;

                                return ""<div><img src='"" + row.serviceProvider.userProfilePicture + ""' class='cap-img float-start' alt='cap image'> "" +
                    ");
                WriteLiteral(@"                ""<div class='name-rating'> <label>"" + row.serviceProvider.firstName + "" "" + row.serviceProvider.lastName + ""</label> <div> "" +
                                    ""<input id='sprating_"" + row.serviceProvider.userId + ""_"" + row.serviceRequestId + ""' class='spRating' value='"" + spRatingRounded + ""' type='text' title='' hidden>"";
                            }
                        }
                    },
                    {
                        name: 'Status',
                        render: function (data, type, row) {
                            var htmlContent = """";

                            switch (row.status) {
                                case 1: htmlContent = htmlContent + ""<label class='lbl-btn lbl-yellow'>New</label>"";
                                    break;
                                case 2: htmlContent = htmlContent + ""<label class='lbl-btn lbl-lightBlue'>Pending</label>"";
                                    break;
                                ca");
                WriteLiteral(@"se 3: htmlContent = htmlContent + ""<label class='lbl-btn lbl-danger'>Cancelled</label>"";
                                    break;
                                case 4: htmlContent = htmlContent + ""<label class='lbl-btn lbl-success'>Completed</label>"";
                                    break;
                            }
                            return htmlContent;
                        }
                    },
                    {
                        render: function (data, type, row) {
                            var htmlContent = """";

                            htmlContent = ""<div class='dropdown'><button class='btn dropdown-toggle' type='button' id='dropdownMenuButton1' "" +
                                "" data-bs-toggle='dropdown' aria-expanded='false'><img src='../img/admin-panel/group-38.png' alt='dots' "" +
                                "" class='position-relative'></button><ul class='dropdown-menu' aria-labelledby='dropdownMenuButton1'>"";

                           ");
                WriteLiteral(@" if (row.status == '1' || row.status == '2') {
                                htmlContent = htmlContent + ""<li><a class='dropdown-item' onclick='EditServiceRequest("" + row.serviceRequestId + "")' >Edit & Reschedule</a></li>"";
                            }

                            htmlContent = htmlContent + ""<li><a class='dropdown-item' >History Log</a></li>"";

                            return htmlContent;
                        }
                    },
                ],
                dom: '<""top"">rt<""bottom""lip><""clear"">',
                responsive: true,
                order: [[0, ""desc""]]
            });

            $(""#txtFromDate"").change(function () {
                $(""#txtToDate"").attr(""min"", $(""#txtFromDate"").val());
            });

            $(""#txtToDate"").change(function () {
                $(""#txtFromDate"").attr(""max"", $(""#txtToDate"").val());
            });

        });

        function SearchUser() {
            $('#tblServiceRequests').DataTable().aj");
                WriteLiteral(@"ax.reload();
        }

        function ResetSearchData() {
            $(""#ServiceRequestId"").val("""");
            $(""#CustomerName"").val("""");
            $(""#ServiceProviderName"").val("""");
            $(""#Status"").val("""");
            $(""#txtFromDate"").val("""");
            $(""#txtToDate"").val("""");
            $('#tblServiceRequests').DataTable().ajax.reload();
        }

        function EditServiceRequest(serviceRequestId) {

            $(""#ErrorMessageServiceDate"").html("""");
            $(""#ErrorMessageStreetName"").html("""");
            $(""#ErrorMessageHouseNumber"").html("""");
            $(""#ErrorMessagePostalCode"").html("""");
            $(""#ErrorMessageReason"").html("""");
            $(""#Reason"").val("""");

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Admin/GetServiceRequest',
                type: 'post',
                dataType: 'json',
                data: { ""serviceRequestId"": serviceRequestId },
                success");
                WriteLiteral(@": function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $(""#HiddenServiceRequestId"").val(resp.result.serviceRequestId);
                    
                    $(""#ServiceDate"").val(DateFormateYYYYMMDD(resp.result.serviceStartDate));

                    var currentDate = new Date();
                    $(""#ServiceDate"").attr(""min"", DateFormateYYYYMMDD(currentDate));

                    var d = new Date(resp.result.serviceStartDate);
                    var time = d.getHours() + (d.getMinutes() / 60);

                    $(""#StreetName"").val(resp.result.serviceRequestAddresses[0].addressLine1);
                    $(""#HouseNumber"").val(resp.result.serviceRequestAddresses[0].addressLine2);
                    $(""#PostalCode"").val(resp.result.serviceRequestAddresses[0].postalCode);

                    FillCityInModel(resp.result.serviceRequestAddresses[0].postalCode, resp.result.serviceRequestAddresses[0].city)

                    $(""#ServiceTim");
                WriteLiteral(@"e"").val(time);
                    $('#EditServiceRequestModel').modal({
                        backdrop: 'static',
                        keyboard: false
                    });
                    $('#EditServiceRequestModel').modal('show');

                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function UpdateServiceRequest() {
            var RegExpressPostalCode = new RegExp(""^[1-9][0-9]{5}$"");

            if ($(""#ServiceDate"").val() == """") {
                $(""#ErrorMessageServiceDate"").html(""Please Select Service Date"");
            }
            else {
                $(""#ErrorMessageServiceDate"").html("""");
            }

            if ($(""#StreetName"").val() == """") {
                $(""#ErrorMessageStreetName"").html(""Please Enter Street Number"");
            }
            else {
                $(""#ErrorMessageStreetName"").html("""");
            }

            if ($(""#Hous");
                WriteLiteral(@"eNumber"").val() == """") {
                $(""#ErrorMessageHouseNumber"").html(""Please Enter House number"");
            }
            else {
                $(""#ErrorMessageHouseNumber"").html("""");
            }

            if ($(""#PostalCode"").val() == """") {
                $(""#ErrorMessagePostalCode"").html(""Please Enter Postal Code"");
            }
            else if (!RegExpressPostalCode.test($(""#PostalCode"").val())) {
                $('#ErrorMessagePostalCode').html(""Please Enter Valid Postal Code."");
            }
            else if ($('#City option').length == 0) {
                $('#ErrorMessagePostalCode').html(""Please Enter different Postal Code."");
            }
            else {
                $(""#ErrorMessagePostalCode"").html("""");
            }

            if ($(""#Reason"").val() == """") {
                $(""#ErrorMessageReason"").html(""Please Enter Reason for Reschedule Service"");
            }
            else {
                $(""#ErrorMessageReason"").html("""");
     ");
                WriteLiteral(@"       }

            if ($(""#ErrorMessageServiceDate"").html() != """" || $(""#ErrorMessageStreetName"").html() != """" ||
                $(""#ErrorMessageHouseNumber"").html() != """" || $(""#ErrorMessagePostalCode"").html() != """" ||
                $(""#ErrorMessageReason"").html() != """") {
                return;
            }
            
            var serviceRequest = {};

            serviceRequest.serviceRequestId = $(""#HiddenServiceRequestId"").val();
            serviceRequest.serviceStartDate = $(""#ServiceDate"").val();
            serviceRequest.serviceStartTime = $(""#ServiceTime option:selected"").text();
            serviceRequest.streetName = $(""#StreetName"").val();
            serviceRequest.houseNumber = $(""#HouseNumber"").val();
            serviceRequest.postalCode = $(""#PostalCode"").val();
            serviceRequest.city = $(""#City"").val();
            serviceRequest.reason = $(""#Reason"").val();

            $('#preloader').removeClass(""d-none"");

            $.ajax({
               ");
                WriteLiteral(@" url: '/Admin/UpdateServiceRequest',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(serviceRequest),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    if (resp.status == ""ok"") {
                        $('#EditServiceRequestModel').modal('hide');
                        $('#tblServiceRequests').DataTable().ajax.reload();
                    }
                    else if (resp.status == ""Error"") {
                        BootstrapAlert(""ErrorMessageEditServiceRequestModel"", resp.errorMessage, ""danger"");
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function DateFormateYYYYMMDD(inputDate) {
            var d = new Date(inputDate);
            return d.getFullYear() + ""-"" + AppendZero((d.getMo");
                WriteLiteral(@"nth() + 1).toString()) + ""-"" + AppendZero(d.getDate().toString());
        }

        function FillCityInModel(postalCode, selectedCity) {

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Admin/GetCitiesByPostalCode',
                type: 'post',
                dataType: 'json',
                data: { ""postalCode"": postalCode },
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $('#City').empty();
                    resp.forEach((city) => {
                        $('#City').append($(""<option></option>"").val(city.cityName).html(city.cityName));
                    });

                    if (selectedCity != """") {
                        $('#City').val(selectedCity);
                    }
                    else {
                        $(""#City"").val($(""#City option:first"").val());
                    }
                },
                error: function (err");
                WriteLiteral(") {\r\n                    console.log(err);\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
