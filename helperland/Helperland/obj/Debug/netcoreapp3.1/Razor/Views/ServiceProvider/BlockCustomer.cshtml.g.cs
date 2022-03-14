#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\ServiceProvider\BlockCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ce665730fcd7cc0c8f2b23097bf735c6904825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProvider_BlockCustomer), @"mvc.1.0.view", @"/Views/ServiceProvider/BlockCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ce665730fcd7cc0c8f2b23097bf735c6904825", @"/Views/ServiceProvider/BlockCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceProvider_BlockCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\ServiceProvider\BlockCustomer.cshtml"
  
    ViewData["Title"] = "Block Customer";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"div-table\">\r\n    <table class=\"table block-customer-table\" id=\"tblBlockCustomer\">\r\n        <thead>\r\n            <tr>\r\n                <td>Rating</td>\r\n            </tr>\r\n        </thead>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
            DefineSection("UserLayoutScripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

            $('#tblBlockCustomer').DataTable({
                paging: true,
                pagingType: ""full_numbers"",
                processing: true,
                serverSide: true,
                filter: true,
                ordering: true,
                searching: false,
                info: true,
                ajax: {
                    url: ""/ServiceProvider/GetBlockCustomerList"",
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

                      ");
                WriteLiteral(@"      var htmlContent = """";

                            htmlContent = ""<div class='content-box'><img src = '../img/admin-panel/sp-avtar/avatar-hat.png' class='img-avtar' />"" +
                                ""<label class='user-name'>"" + row.firstName + "" "" + row.lastName + ""</label>""

                            if (row.favoriteAndBlockedTargetUsers.length > 0) {
                                if (row.favoriteAndBlockedUsers[0].isBlocked == true) {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-unblock' onclick='UpdateBlockStatus("" +
                                        row.favoriteAndBlockedUsers[0].targetUserId + "", false)' >Unblock</button></div >"";
                                }
                                else {
                                    htmlContent = htmlContent + ""<button class='button-blocUnblock button-block' onclick='UpdateBlockStatus("" +
                                        row.userId + "", true)' >Block");
                WriteLiteral(@"</button></div >"";
                                }
                            }
                            else {
                                htmlContent = htmlContent + ""<button class='button-blocUnblock button-block' onclick='UpdateBlockStatus("" +
                                    row.userId + "", true)' >Block</button></div >"";
                            }

                            return htmlContent;
                        }
                    }
                ],
                dom: '<""top"">rt<""bottom""lip><""clear"">',
                responsive: true,
                order: [[0, ""desc""]],
            });

        });

        function UpdateBlockStatus(targetUserId, isBlocked) {

            var favoriteAndBlockedCustomer = {};

            favoriteAndBlockedCustomer.targetUserId = targetUserId;
            favoriteAndBlockedCustomer.isBlocked = isBlocked;

            $('#preloader').removeClass(""d-none"");

            $.ajax({
                url: '/ServicePr");
                WriteLiteral(@"ovider/UpdateCustomerBlockStatus',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(favoriteAndBlockedCustomer),
                success: function (resp) {

                    $('#preloader').addClass(""d-none"");

                    $('#tblBlockCustomer').DataTable().ajax.reload();

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
