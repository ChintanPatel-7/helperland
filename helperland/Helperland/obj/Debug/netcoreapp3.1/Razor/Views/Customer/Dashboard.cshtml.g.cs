#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025fe5d136aa8d9e38e514786591229609eb616f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Dashboard), @"mvc.1.0.view", @"/Views/Customer/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025fe5d136aa8d9e38e514786591229609eb616f", @"/Views/Customer/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("export-btn text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Service-history List -->\r\n<div class=\"d-flex justify-content-between align-items-center\">\r\n    <h2 class=\"title\">Current Service Requests</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025fe5d136aa8d9e38e514786591229609eb616f5683", async() => {
                WriteLiteral("Add New Service Request");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"div-table\">\r\n    <table class=\"table card-view-small-screen\" id=\"tblCurrentServiceRequest\">\r\n        <thead>\r\n            <tr>\r\n                <td>Service Id <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 574, "\"", 580, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>Service Details <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 646, "\"", 652, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                <td>Service Provider <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 720, "\"", 726, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                <td>Payment <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 785, "\"", 791, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                <td>Action</td>
            </tr>
        </thead>
    </table>
</div>

<!-- Reschedule Service request Modal -->
<div class=""modal"" id=""RescheduleServiceRequestModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered "">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""mb-3 mt-1"">Reschedule Service Request</h3>
                <div id=""divRescheduleServiceRequestErrorMessage""></div>
                <div class=""row"">
                    <div class=""col-md-12"">Select New Date a Time</div>
                    <div class=""col-md-6 col-sm-12 pe-2 ps-2 pt-2"">
                        <input id=""RescheduleServiceDate"" type=""date"" class=""form-control"" />
                        <span id=""ErrorMessageServiceDate"" class=""text-danger""></");
            WriteLiteral("span>\r\n                    </div>\r\n                    <div class=\"col-md-6 col-sm-12 pe-2 ps-2 pt-2\">\r\n                        <select class=\"form-select\" id=\"RescheduleServiceTime\">\r\n");
#nullable restore
#line 43 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
                             for (double i = 8; i <= 18; i = i + 0.5)
                            {
                                string[] number = i.ToString().Split(".");

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025fe5d136aa8d9e38e514786591229609eb616f9823", async() => {
                WriteLiteral(" ");
#nullable restore
#line 46 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
                                               Write(number[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 46 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
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
#line 46 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
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
#line 47 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-md-12 mt-4"">
                        <button class=""btn rounded-pill button-primary w-100"" onclick=""UpdateRescheduleServiceRequest()"">Update</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<input type=""hidden"" id=""hiddenServiceRequestIdModal"" />

<!-- Cancel Service request Modal -->
<div class=""modal"" id=""CancelServiceRequestModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered "">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""mb-3 mt-1"">Cancel Service Request</h3>
                <div class=""row"">
                    <div class=""col-md-12"">Why you want to cancel the service request");
            WriteLiteral(@"?</div>
                    <div class=""col-md-12 pe-2 ps-2 pt-2"">
                        <textarea id=""txtCancelServiceRequest"" class=""form-control"" rows=""3""></textarea>
                        <span id=""txtCancelServiceRequestErrorMessage"" class=""text-danger""></span>
                    </div>
                    <div class=""col-md-12 mt-4"">
                        <button class=""btn rounded-pill button-primary w-100"" onclick=""CancelServiceRequestModel()"">Cancel Now</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("UserLayoutScripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#tblCurrentServiceRequest').on('draw.dt', function () { //every time ajax call, this code execute
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
                        return ""fs-16"";
                    },
                });
            });

            var table = $('#tblCurrentServiceRequest').DataTable({
                paging: true,
                pagingType: ""full_numbers"",
                processing: true,
                serverSide: true,
                filter: true,
                // bFilter: false,
   ");
                WriteLiteral(@"             ordering: true,
                searching: false,
                ajax: {
                    url: ""/Customer/GetCurrentServiceRequestList"",
                    type: ""POST"",
                    datatype: ""json"",
                    dataSrc: 'data'
                },
                oLanguage: {
                    sInfo: ""Total Records: _TOTAL_"",
                    sProcessing: ""<div id='preloader'><div id='loader'></div></div>""
                },
                columnDefs: [
                    { ""orderable"": false, ""targets"": 4 }
                ],
                columns: [
                    {
                        data: 'serviceRequestId',
                        name: 'ServiceRequestId',
                    },
                    {
                        name: 'ServiceDateTime',
                        render: function (data, type, row) {

                            return ""<img src='../img/admin-panel/calendar2.png' class='me-1' alt='calenderIcon'><span> "" +");
                WriteLiteral(@"
                                ServiceStartDate(row.serviceStartDate) + ""</span ><br> "" +
                                ""<img src='../img/admin-panel/layer-14.png' class='me-1' alt='clockIcon'>"" +
                                ServiceTime(row.serviceStartDate, 0) + "" - "" +
                                ServiceTime(row.serviceStartDate, row.serviceHours);
                        }
                    },
                    {
                        name: 'ServiceProvider',
                        render: function (data, type, row) {
                            console.log(row)
                            if (row.serviceProvider == null) {
                                return """";
                            }
                            else if (row.status == 2) {
                                var totalRating = 0;
                                var spRating = 0;
                                var count = 0;

                                row.ratings.forEach(function (element) ");
                WriteLiteral(@"{
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
                                    ""<div class='name-rating'> <label>"" + row.serviceProvider.firstName +");
                WriteLiteral(@" "" "" + row.serviceProvider.lastName + ""</label> <div> "" +
                                    ""<input id='sprating_"" + row.serviceProvider.userId + ""_"" + row.serviceRequestId + ""' class='spRating' value='"" + spRatingRounded + ""' type='text' title='' hidden>"";
                            }
                            else {
                                return """";
                            }
                        }
                    },
                    {
                        name: 'TotalCost',
                        render: function (data, type, row) {
                            return ""<span class='money'>"" + row.totalCost + ""$</span>"";
                        }
                    },
                    {
                        render: function (data, type, row) {
                            var htmlComtent = """";
                            var currentDate = new Date();
                            var serviceDate = new Date(row.serviceStartDate);

                        ");
                WriteLiteral(@"    if (serviceDate > currentDate) {
                                htmlComtent = ""<button class='btn rounded-pill button-primary p-1 fs-14' onclick='OpenRescheduleServiceRequestModel("" + row.serviceRequestId + "", false)'>Reschedule</button>"";
                            }

                            htmlComtent = htmlComtent + ""<button class='btn rounded-pill button-danger p-1 ms-1 fs-14' onclick='OpenCancelServiceRequestModel("" + row.serviceRequestId + "", false)'>Cancel</button>"";

                            return htmlComtent;
                                
                        }
                    },
                ],
                info: true,
                dom: '<""top"">rt<""bottom""lip><""clear"">',
                responsive: true,
                order: [[0, ""desc""]]
            });
            
            //click on row column
            $('#tblCurrentServiceRequest tbody').on('click', 'td', function () {
                
                if ($(this).index() == 4) { // p");
                WriteLiteral(@"revent click on 4th column
                    return;
                }

                var rowData = table.row(this).data();
                
                $('#preloader').removeClass(""d-none"");

                $.ajax({
                    url: '/Customer/GetServiceRequest',
                    type: 'post',
                    dataType: 'json',
                    data: { ""serviceRequestId"": rowData.serviceRequestId },
                    success: function (resp) {

                        $('#preloader').addClass(""d-none"");

                        $(""#lblServiceRequestDateTime"").html(""<b>"" + ServiceStartDate(resp.data.serviceStartDate) + ""</b> "" +
                            ""<b>"" + ServiceTime(resp.data.serviceStartDate, 0) + ""-"" +
                            ServiceTime(resp.data.serviceStartDate, resp.data.serviceHours) + ""</b>"");
                        $(""#lblDuration"").text(resp.data.serviceHours);
                        $(""#lblServiceRequestId"").text(resp.data.serviceRequ");
                WriteLiteral(@"estId);
                        $(""#lblExtraServices"").text(resp.extraServiceRequest);
                        $(""#lblTotalAmount"").html(""<b>"" + resp.data.totalCost + "" $</b>"");

                        var serviceAddress = resp.data.serviceRequestAddresses[0];
                        
                        $(""#lblServiceAddress"").text(serviceAddress.addressLine1 + "" "" + serviceAddress.addressLine2 + "", "" + serviceAddress.postalCode + "" "" + serviceAddress.city)
                        $(""#lblPhone"").text(serviceAddress.mobile);   // User Or ServiceAddress
                        $(""#lblEmail"").text(serviceAddress.email);

                        $(""#lblComments"").text(resp.data.comments);

                        if (resp.data.hasPets == false) {
                            $(""#lblHasPet"").html(""<img src='../img/admin-panel/not-included.png'/> I don't have pets at home"");
                        }
                        else {
                            $(""#lblHasPet"").html(""<img src='../i");
                WriteLiteral(@"mg/admin-panel/included.png'/> I have pets at home"");
                        }
        
                        var htmlContent = ""<hr />"";
                        var currentDate = new Date();
                        var serviceDate = new Date(resp.data.serviceStartDate);
                        
                        if (serviceDate > currentDate) {
                            htmlContent = htmlContent = ""<div class='button-group'><button class='btn rounded-pill button-primary' "" +
                                "" onclick='OpenRescheduleServiceRequestModel("" + resp.data.serviceRequestId +
                                "", true)'><img src='../img/admin-panel/reschedule-icon-small.png' /> <span>Reschedule</span> </button>"";
                        }

                        htmlContent = htmlContent + ""<button class='btn rounded-pill button-danger ms-2' onclick='OpenCancelServiceRequestModel("" +
                            resp.data.serviceRequestId + "", true)' ><img src='../img/admin-panel");
                WriteLiteral(@"/close-icon-small.png' /> <span>Cancel</span> </button></div>""

                        $(""#divBtnCustServiceDetailModel"").html(htmlContent);
                        
                        $('#CustServiceDetailModel').modal({
                            backdrop: 'static',
                            keyboard: false
                        });
                        $('#CustServiceDetailModel').modal('show');
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });
            });

        });

        function OpenRescheduleServiceRequestModel(serviceRequestId, closeServiceDetailModel) {
            
            if (closeServiceDetailModel == true) {
                $('#CustServiceDetailModel').modal('hide');
            }

            $(""#hiddenServiceRequestIdModal"").val(serviceRequestId);

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url:");
                WriteLiteral(@" '/Customer/GetServiceRequest',
                type: 'post',
                dataType: 'json',
                data: { ""serviceRequestId"": serviceRequestId },
                success: function (resp) {
                    
                    $('#preloader').addClass(""d-none"");

                    var date = new Date(resp.data.serviceStartDate);
                    var servicedate = date.getFullYear().toString() + ""-"" + AppendZero((date.getMonth() + 1).toString()) + ""-"" + AppendZero(date.getDate().toString());

                    var currentDate = new Date();
                    currentDate.setDate(currentDate.getDate() + 1);
                    var inputTagMinDate = currentDate.getFullYear().toString() + ""-"" + AppendZero((currentDate.getMonth() + 1).toString()) + ""-"" + AppendZero(currentDate.getDate().toString());

                    $(""#RescheduleServiceDate"").val(servicedate);
                    $('#RescheduleServiceDate').attr(""min"", inputTagMinDate);

                    var servic");
                WriteLiteral(@"eRequestHour = date.getHours();
                    var serviceRequestMinute = date.getMinutes();

                    serviceRequestHour = serviceRequestHour + (serviceRequestMinute / 60);
                    serviceRequestHour = Math.round(serviceRequestHour * 10) / 10;
                    
                    $(""#RescheduleServiceTime"").val(serviceRequestHour);

                },
                error: function (err) {
                    console.log(err);
                }
            });

            $('#RescheduleServiceRequestModel').modal({
                backdrop: 'static',
                keyboard: false
            });
            $('#RescheduleServiceRequestModel').modal('show');
        }

        function UpdateRescheduleServiceRequest() {

            if ($(""#RescheduleServiceDate"").val() == """") {
                $(""#ErrorMessageServiceDate"").text(""Please Select Date"");
                return;
            }
            else {
                $(""#ErrorMessageService");
                WriteLiteral(@"Date"").text("""");
            }

            var serviceRequest = {};

            serviceRequest.serviceRequestId = $(""#hiddenServiceRequestIdModal"").val();
            serviceRequest.serviceStartDate = $(""#RescheduleServiceDate"").val();
            serviceRequest.serviceStartTime = $(""#RescheduleServiceTime option:selected"").text();

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Customer/UpdateRescheduleServiceRequest',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(serviceRequest),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    if (resp.status == ""ok"") {
                        $('#RescheduleServiceRequestModel').modal('hide');
                        $('#tblCurrentServiceRequest').DataTable().ajax.reload();
                    }
                    else if (r");
                WriteLiteral(@"esp.status == ""Error"") {
                        BootstrapAlert(""divRescheduleServiceRequestErrorMessage"", resp.errorMessage, ""danger"");
                    }

                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function OpenCancelServiceRequestModel(serviceRequestId, closeServiceDetailModel) {

            if (closeServiceDetailModel == true) {
                $('#CustServiceDetailModel').modal('hide');
            }

            $(""#hiddenServiceRequestIdModal"").val(serviceRequestId);

            $('#CancelServiceRequestModel').modal({
                backdrop: 'static',
                keyboard: false
            });
            $('#CancelServiceRequestModel').modal('show');
        }

        function CancelServiceRequestModel() {

            if ($(""#txtCancelServiceRequest"").val().trim() == """") {
                $(""#txtCancelServiceRequestErrorMessage"").html(""Please Enter reaso");
                WriteLiteral(@"n for cancel Service."");
                return;
            }
            else {
                $(""#txtCancelServiceRequestErrorMessage"").html("""");
            }

            var serviceRequest = {};

            serviceRequest.serviceRequestId = $(""#hiddenServiceRequestIdModal"").val();
            serviceRequest.comments = $(""#txtCancelServiceRequest"").val();

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Customer/CancelServiceRequest',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(serviceRequest),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    if (resp.status == ""ok"") {
                        $('#CancelServiceRequestModel').modal('hide');
                        $('#tblCurrentServiceRequest').DataTable().ajax.reload();
                    }

          ");
                WriteLiteral("          $(\"#txtCancelServiceRequest\").val(\"\");\r\n                },\r\n                error: function (err) {\r\n                    console.log(err);\r\n                }\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
