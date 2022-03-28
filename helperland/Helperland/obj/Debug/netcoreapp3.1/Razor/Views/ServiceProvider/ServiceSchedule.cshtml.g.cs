#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\ServiceProvider\ServiceSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f96f7d1a212d45ea5d4d626c59d2d345bfe1d23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProvider_ServiceSchedule), @"mvc.1.0.view", @"/Views/ServiceProvider/ServiceSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f96f7d1a212d45ea5d4d626c59d2d345bfe1d23", @"/Views/ServiceProvider/ServiceSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceProvider_ServiceSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\ServiceProvider\ServiceSchedule.cshtml"
  
    ViewData["Title"] = "Service Schedule";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-content position-relative\">\r\n    <ul class=\"calendar-legend\">\r\n        <li class=\"completed\">Completed</li>\r\n        <li class=\"upcoming\">Upcoming</li>\r\n    </ul>\r\n    <div id=\'calendar\'></div>\r\n</div>\r\n\r\n");
            DefineSection("UserLayoutScripts", async() => {
                WriteLiteral(@"
 
    <script type=""text/javascript"">

        var events = [];

        $(document).ready(function () {

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/ServiceProvider/GetServiceRequestListForCalender',
                type: 'post',
                dataType: 'json',
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");
                    
                    resp.data.forEach((element) => {
                        events.push({
                            id: element.serviceRequestId,
                            title: eventTitle(element.serviceStartDate, element.serviceEndDate),
                            start: element.serviceStartDate,
                            end: element.serviceEndDate,
                            borderColor: (element.serviceStatus == ""Completed"") ? ""#efefef"" : ""#1d7a8c"",
                            backgroundColor: (element.serviceStatus == ""Completed"") ? ""#efe");
                WriteLiteral(@"fef"" : ""#1d7a8c"",
                            textColor: (element.serviceStatus == ""Completed"") ? ""#7d7979"" : ""#fff"",
                            allDay: true,
                            className: ""text-center fw-bold""
                        });
                    });

                    var calendarEl = document.getElementById('calendar');

                    var calendar = new FullCalendar.Calendar(calendarEl, {
                        initialView: 'dayGridMonth',
                        headerToolbar: {
                            left: 'prev,next today',
                            center: 'title',
                            right: ''
                        },
                        events: events,
                        eventClick: function (calEvent, jsEvent, view) {
                            OpenServiceRequestModal(calEvent.event.id);
                        },
                        contentHeight: 600
                    });

                    calendar.render();
");
                WriteLiteral(@"                },
                error: function (err) {
                    console.log(err);
                }
            });
        });

        function OpenServiceRequestModal(serviceRequestId) {
            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/ServiceProvider/GetServiceRequestWithCustomerDetails',
                type: 'post',
                dataType: 'json',
                data: { ""serviceRequestId"": serviceRequestId },
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $(""#lblSpServiceRequestDateTime"").html(""<b>"" + ServiceStartDate(resp.data.serviceStartDate) + ""</b> "" +
                        ""<b>"" + ServiceTime(resp.data.serviceStartDate, 0) + ""-"" +
                        ServiceTime(resp.data.serviceStartDate, resp.data.serviceHours) + ""</b>"");
                    $(""#lblSpDuration"").text(resp.data.serviceHours);
                    $(""#lblSpServiceRequ");
                WriteLiteral(@"estId"").text(resp.data.serviceRequestId);

                    $(""#lblSpExtraServices"").text(resp.extraServiceRequest);
                    $(""#lblSpTotalAmount"").html(""<b>"" + resp.data.totalCost + "" $</b>"");

                    $(""#lblSpCustomerName"").text(resp.data.user.firstName + "" "" + resp.data.user.lastName);

                    var serviceAddress = resp.data.serviceRequestAddresses[0];

                    $(""#lblSpServiceAddress"").text(serviceAddress.addressLine1 + "" "" + serviceAddress.addressLine2 + "", "" + serviceAddress.postalCode + "" "" + serviceAddress.city)
                    $(""#lblSpPhone"").text(serviceAddress.mobile);   // User Or ServiceAddress
                    $(""#lblSpEmail"").text(resp.data.user.email);

                    $(""#lblSpComments"").text(resp.data.comments);

                    if (resp.data.hasPets == false) {
                        $(""#lblSpHasPet"").html(""<img src='../img/admin-panel/not-included.png'/> I don't have pets at home"");
                    }");
                WriteLiteral(@"
                    else {
                        $(""#lblSpHasPet "").html(""<img src='../img/admin-panel/included.png'/> I have pets at home"");
                    }

                    $('#SpPanelServiceDetailModel').modal({
                        backdrop: 'static',
                        keyboard: false
                    });
                    $('#SpPanelServiceDetailModel').modal('show');
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function eventTitle(eventStartTime, eventEndTime) {
            var start = new Date(eventStartTime);
            var end = new Date(eventEndTime);
            return AppendZero(start.getHours().toString()) + "":"" + AppendZero(start.getMinutes().toString()) + "" - "" +
                AppendZero(end.getHours().toString()) + "":"" + AppendZero(end.getMinutes().toString());
        }

    </script>

");
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
