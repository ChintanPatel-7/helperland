#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4018e6c1cb228f7476e0d6c0977914712cc9acbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookServiceCustomerAddressList), @"mvc.1.0.view", @"/Views/Home/BookServiceCustomerAddressList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4018e6c1cb228f7476e0d6c0977914712cc9acbb", @"/Views/Home/BookServiceCustomerAddressList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BookServiceCustomerAddressList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserAddress>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
 if (Model.Any())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
     foreach (UserAddress userAddress in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"address\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 190, "\"", 218, 1);
#nullable restore
#line 12 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
WriteAttributeValue("", 196, userAddress.AddressId, 196, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input class=\"form-check-input address-radioBtn\" type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 299, "\"", 326, 1);
#nullable restore
#line 13 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
WriteAttributeValue("", 304, userAddress.AddressId, 304, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"UserAddressListYourDetailTab\" />\r\n                <span>\r\n                    <b>Address :</b> ");
#nullable restore
#line 15 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
                                Write(userAddress.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
                                                          Write(userAddress.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
                                                                                     Write(userAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
                                                                                                       Write(userAddress.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <b>Phone number :</b> ");
#nullable restore
#line 16 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
                                     Write(userAddress.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n        </li>\r\n");
#nullable restore
#line 20 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" id=\"isUserAddressListAvailable\" value=\"true\" />\r\n");
#nullable restore
#line 22 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"address p-3\">No address Found. Please Add New Address.</li>\r\n    <input type=\"hidden\" id=\"isUserAddressListAvailable\" value=\"false\" />\r\n");
#nullable restore
#line 27 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\BookServiceCustomerAddressList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserAddress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
