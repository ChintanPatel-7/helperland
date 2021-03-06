#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a10136ac404d3e4a85ba064c81e709f52998f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ServiceHistory), @"mvc.1.0.view", @"/Views/Customer/ServiceHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a10136ac404d3e4a85ba064c81e709f52998f84", @"/Views/Customer/ServiceHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ServiceHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
  
    ViewData["Title"] = "Service History";
    Layout = "~/Views/Shared/_UserLayout.cshtml";
    var compeleted = (int)ServiceRequestStatusEnum.Completed;
    var cancelled = (int)ServiceRequestStatusEnum.Cancelled;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Service-history List -->
<div class=""d-flex justify-content-between align-items-center"">
    <h2 class=""title"">Service History</h2>
    <button class=""export-btn"" onclick=""ExportExcel();"">Export</button>
</div>
<div class=""div-table"">
    <table class=""table card-view-small-screen"" id=""tblServiceHistory"">
        <thead>
            <tr>
                <td>Service Id <img class=""sort-img""");
            BeginWriteAttribute("alt", " alt=\"", 635, "\"", 641, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                <td>Service Details <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 708, "\"", 714, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                <td>Service Provider <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 782, "\"", 788, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                <td>Payment <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 853, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                <td>Status</td>
                <td>Rate SP</td>
            </tr>
        </thead>
    </table>
</div>


<!-- Service Provider Rating Modal -->
<div class=""modal"" id=""ServiceProviderRatingModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered "">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                <div class=""clearfix mb-3 align-items-center d-flex"">
                    <img id=""spImageRatingModel"" class=""cap-img float-start""
                         alt=""cap image"">
                    <div class=""name-rating"">
                        <label id=""lblServiceProviderName""></label>
                        <div id=""divDisplayRatingServiceProviderInModel"">
                        </div>
                    </div>
                </div>
 ");
            WriteLiteral(@"               <h3 class=""mb-3"">Rate your service provider</h3>
                <hr />

                <input id=""hiddenInputServiceRequestId"" type=""hidden""/>
                <input id=""hiddenInputRatingTo"" type=""hidden""/>

                <div class=""row mb-3"">
                    <div class=""col-sm-12 col-md-4 mb-1 d-flex align-items-center"">
                        On time arrival
                    </div>
                    <div class=""col-sm-12 col-md-8 mb-1"" id=""divRatingOnTimeArrival"">
                    </div>
                </div>
                <div class=""row mb-3"">
                    <div class=""col-sm-12 col-md-4 mb-1 d-flex align-items-center"">
                        Friendly
                    </div>
                    <div class=""col-sm-12 col-md-8 mb-1"" id=""divRatingFriendly"">
                    </div>
                </div>
                <div class=""row mb-3"">
                    <div class=""col-sm-12 col-md-4 mb-1 d-flex align-items-center"">
              ");
            WriteLiteral(@"          Quality of service
                    </div>
                    <div class=""col-sm-12 col-md-8 mb-1"" id=""divRatingQualityOfService"">
                    </div>
                </div>
                <div class=""row mb-3"">
                    <div class=""col-sm-12 col-md-12 mb-1"">
                        Feedback on service provider
                    </div>
                    <div class=""col-sm-12 col-md-12 mb-1"">
                        <textarea id=""feedback"" class=""form-control"" rows=""3""></textarea>
                    </div>
                </div>

                <div>
                    <button id=""btnRatingSubmit"" class=""btn rounded-pill button-primary"" onclick=""SubmitRating()"">Submit</button>
                    <span id=""ratingMessage"" class=""text-danger""></span>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("UserLayoutScripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var table;

        $(document).ready(function () {
            $('#tblServiceHistory').on('draw.dt', function () { //every time ajax call, this code execute
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

            table = $('#tblServiceHistory').DataTable({
                paging: true,
                pagingType: ""full_numbers"",
                processing: true,
                serverSide: true,
                filter: true,
                ordering: true,
  ");
                WriteLiteral(@"              searching: false,
                info: true,
                ajax: {
                    url: ""/Customer/GetServiceRequestHistoryList"",
                    type: ""POST"",
                    datatype: ""json"",
                    dataSrc: 'data'
                },
                oLanguage: {
                    sInfo: ""Total Records: _TOTAL_"",
                    sProcessing: ""<div id='preloader'><div id='loader'></div></div>""
                },
                columnDefs: [
                    { ""orderable"": false, ""targets"": 4 },
                    { ""orderable"": false, ""targets"": 5 }
                ],
                columns: [
                    {
                        data: 'serviceRequestId',
                        name: 'ServiceRequestId',
                    },
                    {
                        name: 'ServiceDateTime',
                        render: function (data, type, row) {
                            return ""<img src='../img/admin-panel/cal");
                WriteLiteral(@"endar2.png' class='me-1' alt='calenderIcon'><span> "" +
                                ServiceStartDate(row.serviceStartDate) + ""</span ><br> "" +
                                ""<img src='../img/admin-panel/layer-14.png' class='me-1' alt='clockIcon'>"" +
                                ServiceTime(row.serviceStartDate, 0) + "" - "" +
                                ServiceTime(row.serviceStartDate, row.serviceHours);
                        }
                    },
                    {
                        name: 'ServiceProvider',
                        render: function (data, type, row) {

                            if (row.serviceProvider == null) {
                                return """";
                            }
                            else {
                                var totalRating = 0;
                                var spRating = 0;
                                var count = 0;

                                row.ratings.forEach(function (element) {
        ");
                WriteLiteral(@"                            totalRating = totalRating + element.ratings;
                                    count = count + 1;
                                });


                                if (count == 0) {
                                    return ""<div><img src='"" + row.serviceProvider.userProfilePicture + ""' class='cap-img float-start' alt='cap image'> "" +
                                        ""<div class='name-rating'> <label>"" + row.serviceProvider.firstName + "" "" + row.serviceProvider.lastName + ""</label> <div> "" + ""Not Rated"";
                                }

                                spRating = (totalRating / count);

                                var spRatingRounded = Math.round(spRating * 10) / 10;

                                return ""<div><img src='"" + row.serviceProvider.userProfilePicture + ""' class='cap-img float-start' alt='cap image'> "" +
                                    ""<div class='name-rating'> <label>"" + row.serviceProvider.firstName + "" "" + row.");
                WriteLiteral(@"serviceProvider.lastName + ""</label> <div> "" +
                                    ""<input id='sprating_"" + row.serviceProvider.userId + ""_"" + row.serviceRequestId + ""' class='spRating' value='"" + spRatingRounded + ""' type='text' title='' hidden>"";
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
                            if (row.status == ");
#nullable restore
#line 191 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
                                         Write(compeleted);

#line default
#line hidden
#nullable disable
                WriteLiteral(") {\r\n                                return \"<span class=\'compeleted-btn\'>Completed</span>\";\r\n                            }\r\n                            else if (row.status == ");
#nullable restore
#line 194 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
                                              Write(cancelled);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") {
                                return ""<span class='cancelled-btn'>Cancelled</span>"";
                            }
                            else {
                                return """";
                            }
                        }
                    },
                    {
                        render: function (data, type, row) {
                            //var customerRated = false;
                            //row.ratings.forEach(function (element) {
                            //    if (row.serviceRequestId == element.serviceRequestId) {
                            //        customerRated = true;
                            //    }
                            //});
                            return ""<button class='btn rounded-pill button-primary p-1 fs-14' onclick='OpenServiceProviderRatingModel("" + row.serviceRequestId + "")' "" + ((row.status == ");
#nullable restore
#line 210 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
                                                                                                                                                                                    Write(cancelled);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") ? ""disabled"" : """"/*(customerRated == true ? ""disabled"" : """" )*/) + "" >Rate SP</button>"";
                        }
                    }
                ],
                dom: '<""top"">rt<""bottom""lip><""clear"">',
                responsive: true,
                order: [[0, ""desc""]]
            });

            //click on row column
            $('#tblServiceHistory tbody').on('click', 'td', function () {

                if ($(this).index() == 5) { // prevent click on 4th column
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

             ");
                WriteLiteral(@"           $(""#lblServiceRequestDateTime"").html(""<b>"" + ServiceStartDate(resp.data.serviceStartDate) + ""</b> "" +
                            ""<b>"" + ServiceTime(resp.data.serviceStartDate, 0) + ""-"" +
                            ServiceTime(resp.data.serviceStartDate, resp.data.serviceHours) + ""</b>"");
                        $(""#lblDuration"").text(resp.data.serviceHours);
                        $(""#lblServiceRequestId"").text(resp.data.serviceRequestId);
                        $(""#lblExtraServices"").text(resp.extraServiceRequest);
                        $(""#lblTotalAmount"").html(""<b>"" + resp.data.totalCost + "" $</b>"");

                        var serviceAddress = resp.data.serviceRequestAddresses[0];

                        $(""#lblServiceAddress"").text(serviceAddress.addressLine1 + "" "" + serviceAddress.addressLine2 + "", "" + serviceAddress.postalCode + "" "" + serviceAddress.city)
                        $(""#lblPhone"").text(serviceAddress.mobile);   // User Or ServiceAddress
                     ");
                WriteLiteral(@"   $(""#lblEmail"").text(serviceAddress.email);
                        
                        $(""#lblComments"").text(resp.data.comments);

                        if (resp.data.hasPets == false) {
                            $(""#lblHasPet"").html(""<img src='../img/admin-panel/not-included.png'/> I don't have pets at home"");
                        }
                        else {
                            $(""#lblHasPet"").html(""<img src='../img/admin-panel/included.png'/> I have pets at home"");
                        }

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


        function ExportExcel() {
     ");
                WriteLiteral(@"       var tblData = table.data();
            let csvContent = ""data:text/csv;charset=utf-8,"";

            csvContent += ""Service Id, Service Details, Service Provider, Payment, Status \n"";

            for (let i = 0; i < tblData.length; i++) {
                csvContent += tblData[i].serviceRequestId + "","" +
                    ServiceStartDate(tblData[i].serviceStartDate) + "" "" + ServiceTime(tblData[i].serviceStartDate, 0) + "" - "" +
                    ServiceTime(tblData[i].serviceStartDate, tblData[i].serviceHours) + "","";
                
                if (tblData[i].serviceProvider == null) {
                    csvContent += "","";
                }
                else {
                    csvContent += tblData[i].serviceProvider.firstName + "" "" + tblData[i].serviceProvider.lastName + "","";
                }
                
                csvContent += tblData[i].totalCost + ""$,"";

                if (tblData[i].status == ");
#nullable restore
#line 297 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
                                    Write(compeleted);

#line default
#line hidden
#nullable disable
                WriteLiteral(") {\r\n                    csvContent += \"Completed\\n\";\r\n                }\r\n                else if (tblData[i].status == ");
#nullable restore
#line 300 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\ServiceHistory.cshtml"
                                         Write(cancelled);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") {
                    csvContent += ""Cancelled\n"";
                }
                else {
                    csvContent += ""\n"";
                }
            }

            var encodedUri = encodeURI(csvContent);
            var link = document.createElement(""a"");
            link.setAttribute(""href"", encodedUri);
            link.setAttribute(""download"", ""serviceRequestHistory.csv"");
            document.body.appendChild(link); // Required for FF
            link.click();
        }

        function OpenServiceProviderRatingModel(serviceRequestId) {

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Customer/GetServiceProvicerRatingFromServiceRequest',
                type: 'post',
                dataType: 'json',
                data: { ""serviceRequestId"": serviceRequestId },
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $(""#lblServiceProviderName"").htm");
                WriteLiteral(@"l(resp.result.serviceProvider.firstName + "" "" + resp.result.serviceProvider.lastName);
                    console.log(resp.result);
                    $(""#spImageRatingModel"").attr(""src"", resp.result.serviceProvider.userProfilePicture);
                    if (resp.result.serviceProviderRating == 0) {
                        $(""#divDisplayRatingServiceProviderInModel"").html(""Not Rated"");
                    }
                    else {
                        $(""#divDisplayRatingServiceProviderInModel"").html(""<input id='spratingInModel_"" + resp.result.ratingId + ""' class='spRatingInModel' value='"" + resp.result.serviceProviderRating + ""' type='text' title='' hidden>"");

                        $("".spRatingInModel"").rating({
                            min: 0,
                            max: 5,
                            step: 0.1,
                            size: ""xs"",
                            stars: ""5"",
                            showClear: false,
                            readonl");
                WriteLiteral(@"y: true,
                            starCaptions: function (val) {
                                return val;
                            },
                            starCaptionClasses: function () {
                                return ""fs-16"";
                            },
                        });
                    }

                    $(""#hiddenInputServiceRequestId"").val(resp.result.serviceRequestId);
                    $(""#hiddenInputRatingTo"").val(resp.result.serviceProvider.userId);

                    if (resp.result.ratingId == 0) {
                        $(""#divRatingOnTimeArrival"").html(""<input id='RatingOnTimeArrival' class='rating-serviceProvider' value='"" + 0 + ""' type='text' title='' hidden>"")
                        $(""#divRatingFriendly"").html(""<input id='RatingFriendly' class='rating-serviceProvider' value='"" + 0 + ""' type='text' title='' hidden>"")
                        $(""#divRatingQualityOfService"").html(""<input id='RatingQualityOfService' class='rating-");
                WriteLiteral(@"serviceProvider' value='"" + 0 + ""' type='text' title='' hidden>"")

                        $("".rating-serviceProvider"").rating({
                            min: 0,
                            max: 5,
                            step: 0.5,
                            size: ""sm"",
                            stars: ""5"",
                            showClear: false,
                            showCaption: false
                        });

                        $(""#feedback"").val("""");
                        $(""#feedback"").removeAttr(""disabled"");

                        $(""#btnRatingSubmit"").removeClass(""d-none"");
                        $(""#ratingMessage"").html("""");
                    }
                    else {

                        $(""#divRatingOnTimeArrival"").html(""<input id='RatingOnTimeArrival' class='rating-serviceProvider-disabled' value='"" + parseFloat(resp.result.onTimeArrival) + ""' type='text' title='' hidden>"")
                        $(""#divRatingFriendly"").html(""<input");
                WriteLiteral(@" id='RatingFriendly' class='rating-serviceProvider-disabled' value='"" + parseFloat(resp.result.friendly) + ""' type='text' title='' hidden>"")
                        $(""#divRatingQualityOfService"").html(""<input id='RatingQualityOfService' class='rating-serviceProvider-disabled' value='"" + parseFloat(resp.result.qualityOfService) + ""' type='text' title='' hidden>"")

                        $("".rating-serviceProvider-disabled"").rating({
                            min: 0,
                            max: 5,
                            step: 0.5,
                            size: ""sm"",
                            stars: ""5"",
                            showClear: false,
                            readonly: true,
                            showCaption: false
                        });

                        $(""#feedback"").val(resp.result.comments);
                        $(""#feedback"").attr(""disabled"", ""disabled"");

                        $(""#btnRatingSubmit"").addClass(""d-none"");
         ");
                WriteLiteral(@"               $(""#ratingMessage"").html(""You have already rated on "" + ServiceStartDate(resp.result.ratingDate) + "" "" + ServiceTime(resp.result.ratingDate, 0)) + ""."";
                    }

                    $('#ServiceProviderRatingModel').modal({
                        backdrop: 'static',
                        keyboard: false
                    });
                    $('#ServiceProviderRatingModel').modal('show');
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function SubmitRating() {

            var rating = {};

            rating.serviceRequestId = $(""#hiddenInputServiceRequestId"").val();
            rating.ratingTo = parseInt($(""#hiddenInputRatingTo"").val());
            rating.OnTimeArrival = $(""#RatingOnTimeArrival"").val();
            rating.Friendly = $(""#RatingFriendly"").val();
            rating.QualityOfService = $(""#RatingQualityOfService"").val();

            ");
                WriteLiteral(@"var totalRatingSp = (parseFloat(rating.OnTimeArrival) + parseFloat(rating.Friendly) + parseFloat(rating.QualityOfService)) / 3.0;

            rating.ratings = Math.round(totalRatingSp * 10) / 10;

            rating.comments = $(""#feedback"").val();

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Customer/SubmitRatingFromCustomer',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(rating),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $('#ServiceProviderRatingModel').modal('hide');

                    $('#tblServiceHistory').DataTable().ajax.reload();
                },
                error: function (err) {
                    console.log(err);
                }
            });
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
