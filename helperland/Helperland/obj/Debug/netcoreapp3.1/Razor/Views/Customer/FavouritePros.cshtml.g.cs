#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\FavouritePros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa0a5509218851c9fc63cb1c7f3c3db1253080d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_FavouritePros), @"mvc.1.0.view", @"/Views/Customer/FavouritePros.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa0a5509218851c9fc63cb1c7f3c3db1253080d", @"/Views/Customer/FavouritePros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_FavouritePros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\FavouritePros.cshtml"
  
    ViewData["Title"] = "FavouritePros";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"div-table\">\r\n    <table class=\"table userlist-table\" id=\"tblFavouritePros\">\r\n        <thead>\r\n            <tr>\r\n                <td>Service Provider</td>\r\n            </tr>\r\n        </thead>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("UserLayoutScripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

            $('#tblFavouritePros').on('draw.dt', function () { //every time ajax call, this code execute
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

            $('#tblFavouritePros').DataTable({
                paging: true,
                pagingType: ""full_numbers"",
                processing: true,
                serverSide: true,
                filter: true,
                ordering: true,
                searching: fal");
                WriteLiteral(@"se,
                info: true,
                ajax: {
                    url: ""/Customer/GetServiceProviderListWorkWithCustomer"",
                    type: ""POST"",
                    datatype: ""json"",
                    dataSrc: 'data'
                },
                oLanguage: {
                    sInfo: ""Total Records: _TOTAL_"",
                    sProcessing: ""<div id='preloader'><div id='loader'></div></div>""
                },

                columns: [
                    {
                        name: 'ServiceDateTime',
                        render: function (data, type, row) {
                            console.log(row);
                            var htmlContent = """";

                            htmlContent = ""<div class='content-box'><div class='text-center'><img class='cap-img user-img-table' src = '"" + row.userProfilePicture +""' /></div>"" +
                                ""<label class='user-name mb-2'>"" + row.firstName + "" "" + row.lastName + ""</label>""


 ");
                WriteLiteral(@"                           htmlContent = htmlContent + ""<div class='text-center mb-2'>"";

                            var totalRating = 0;
                            var spRating = 0;
                            var count = 0;

                            row.rating.forEach(function (element) {
                                totalRating = totalRating + element.ratings;
                                count = count + 1;
                            });


                            if (count == 0) {
                                htmlContent = htmlContent + ""Not Rated"";
                            }
                            else {
                                spRating = (totalRating / count);

                                var spRatingRounded = Math.round(spRating * 10) / 10;

                                htmlContent = htmlContent + ""<input id='sprating_"" + row.userId + ""' class='spRating' value='"" + spRatingRounded + ""' type='text' title='' hidden>"";
                         ");
                WriteLiteral(@"   }
                            
                            htmlContent = htmlContent + ""</div><div class='text-center mb-3 fs-14'> "" + row.cleanings + "" Cleanings</div><div class='text-center'>"";

                            if (row.favoriteAndBlockedTargetUsers.length > 0) {
                                if (row.favoriteAndBlockedTargetUsers[0].isFavorite == true) {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-unblock me-2' onclick='UpdateFavoriteBlockStatus("" +
                                        row.favoriteAndBlockedTargetUsers[0].targetUserId + "", false, "" + row.favoriteAndBlockedTargetUsers[0].isBlocked + "")' >UnFavourite</button>"";
                                }
                                else {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-block me-2' onclick='UpdateFavoriteBlockStatus("" +
                                        row.userId + "", true, "" + ");
                WriteLiteral(@"row.favoriteAndBlockedTargetUsers[0].isBlocked + "")' >Favourite</button>"";
                                }
                                if (row.favoriteAndBlockedTargetUsers[0].isBlocked == true) {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-unblock' onclick='UpdateFavoriteBlockStatus("" +
                                        row.favoriteAndBlockedTargetUsers[0].targetUserId + "", "" + row.favoriteAndBlockedTargetUsers[0].isFavorite + "", false)' >Unblock</button></div >"";
                                }
                                else {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-block' onclick='UpdateFavoriteBlockStatus("" +
                                        row.userId + "", "" + row.favoriteAndBlockedTargetUsers[0].isFavorite + "", true)' >Block</button>"";
                                }
                            }
                            else {
      ");
                WriteLiteral(@"                          htmlContent = htmlContent + ""<button class='button-blocUnblock button-block me-2' onclick='UpdateFavoriteBlockStatus("" +
                                    row.userId + "", true, false)' >Favourite</button>"";

                                htmlContent = htmlContent + ""<button class='button-blocUnblock button-block' onclick='UpdateFavoriteBlockStatus("" +
                                    row.userId + "", false, true)' >Block</button>"";
                            }
                            htmlContent = htmlContent + ""</div></div >""
                            return htmlContent;
                        }
                    }
                ],
                dom: '<""top"">rt<""bottom""lip><""clear"">',
                responsive: true,
                order: [[0, ""desc""]],
            });

        });
          
        function UpdateFavoriteBlockStatus(targetUserId, isFavorite, isBlocked) {

            var favoriteAndBlockedCustomer = {};

            favo");
                WriteLiteral(@"riteAndBlockedCustomer.targetUserId = targetUserId;
            favoriteAndBlockedCustomer.isFavorite = isFavorite;
            favoriteAndBlockedCustomer.isBlocked = isBlocked;

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/Customer/UpdateServiceProviderFavoriteBlockStatus',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(favoriteAndBlockedCustomer),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $('#tblFavouritePros').DataTable().ajax.reload();

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
            WriteLiteral("\r\n\r\n");
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
