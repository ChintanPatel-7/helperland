#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e332d7b4f08fd976bdbacd7c9275782e7d7064c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_MyAccount), @"mvc.1.0.view", @"/Views/Customer/MyAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e332d7b4f08fd976bdbacd7c9275782e7d7064c7", @"/Views/Customer/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "English", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "German", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/admin-panel/edit-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/admin-panel/delete-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Customer\MyAccount.cshtml"
  
    ViewData["Title"] = "MyAccount";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""my-account"">
    <ul class=""nav nav-pills mb-3 nav-fill"" id=""pills-tab"" role=""tablist"">
        <li class=""nav-item"" role=""presentation"">
            <button class=""nav-link active"" id=""my-detail-tab"" data-bs-toggle=""pill"" data-bs-target=""#my-detail"" type=""button"" role=""tab"" aria-controls=""pills-home"" aria-selected=""true"">
                <span class=""tab-icon my-detail-tabIcon d-block d-sm-none""></span>
                <span class=""d-none d-sm-block"">My Details</span>
            </button>
        </li>
        <li class=""nav-item"" role=""presentation"">
            <button class=""nav-link"" id=""my-addresses-tab"" data-bs-toggle=""pill"" data-bs-target=""#my-addresses"" type=""button"" role=""tab"" aria-controls=""pills-profile"" aria-selected=""false"">
                <span class=""tab-icon my-addresses-tabIcon d-block d-sm-none""></span>
                <span class=""d-none d-sm-block"">My Addresses</span>
            </button>
        </li>
        <li class=""nav-item"" role=""presentation"">
     ");
            WriteLiteral(@"       <button class=""nav-link"" id=""change-password-tab"" data-bs-toggle=""pill"" data-bs-target=""#change-password"" type=""button"" role=""tab"" aria-controls=""pills-contact"" aria-selected=""false"">
                <span class=""tab-icon my-change-password-tabIcon d-block d-sm-none""></span>
                <span class=""d-none d-sm-block"">Change Password</span>
            </button>
        </li>
    </ul>
    <div class=""tab-content"" id=""pills-tabContent"">
        <div class=""tab-pane fade show active"" id=""my-detail"" role=""tabpanel"" aria-labelledby=""my-detail-tab"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                    <label for=""FirstName"" class=""form-label"">First Name</label>
                    <input type=""text"" class=""form-control"" id=""FirstName"" placeholder=""First Name"">
                    <span id=""FirstNameErrorMessage"" class=""text-danger""></span>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
    ");
            WriteLiteral(@"                <label for=""LastName"" class=""form-label"">LastName</label>
                    <input type=""text"" class=""form-control"" id=""LastName"" placeholder=""Last Name"">
                    <span id=""LastNameErrorMessage"" class=""text-danger""></span>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                    <label for=""Email"" class=""form-label"">E-mail address</label>
                    <input type=""text"" class=""form-control"" id=""Email"" placeholder=""E-mail Address"" disabled>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                    <label for=""MobileNumber"" class=""form-label"">Mobile number</label>
                    <input type=""text"" class=""form-control"" id=""MobileNumber"" placeholder=""Mobile Number"">
                    <span id=""MobileNumberErrorMessage"" class=""text-danger""></span>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                    <label for");
            WriteLiteral(@"=""MobileNumber"" class=""form-label"">Date of Birth</label>
                    <div class=""row"">
                        <div class=""col-3 pe-1"">
                            <select class=""form-select small-select-tag"" id=""DateOfBirth"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332d7b4f08fd976bdbacd7c9275782e7d7064c79507", async() => {
                WriteLiteral("22");
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
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"col-5 pe-1 ps-1\">\r\n                            <select class=\"form-select\" id=\"DateOfBirth\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332d7b4f08fd976bdbacd7c9275782e7d7064c710708", async() => {
                WriteLiteral("January");
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
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"col-4 ps-1\">\r\n                            <select class=\"form-select small-select-tag\" id=\"DateOfBirth\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332d7b4f08fd976bdbacd7c9275782e7d7064c711927", async() => {
                WriteLiteral("2021");
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
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <span id=""MobileNumberErrorMessage"" class=""text-danger""></span>
                </div>
            </div>
            <hr />
            <div class=""mb-3"">
                <label for=""MobileNumber"" class=""form-label"">My Preferred Language</label>
                <select class=""width-120 form-select"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332d7b4f08fd976bdbacd7c9275782e7d7064c713343", async() => {
                WriteLiteral("English");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332d7b4f08fd976bdbacd7c9275782e7d7064c714524", async() => {
                WriteLiteral("German");
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
            WriteLiteral(@"
                </select>
            </div>
            <button class=""btn rounded-pill button-primary"">Save</button>
        </div>
        <div class=""tab-pane fade"" id=""my-addresses"" role=""tabpanel"" aria-labelledby=""my-addresses-tab"">

            <table class=""table"" id=""tblCustomerAddressList"">
                <thead>
                    <tr>
                        <th>Addresses</th>
                        <th class=""width-120"">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <b>Address:</b> Abc, xyz<br />
                            <b>Phone number:</b> Abc, xyz<br />
                        </td>
                        <td>
                            <a class=""actionIcon editIcon"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e332d7b4f08fd976bdbacd7c9275782e7d7064c716577", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                            <a class=\"actionIcon deleteIcon ms-1\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e332d7b4f08fd976bdbacd7c9275782e7d7064c717748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Address:</b> Abc, xyz<br />
                            <b>Address:</b> Abc, xyz<br />
                        </td>
                        <td>abc</td>
                    </tr>
                </tbody>
            </table>
            <a class=""btn rounded-pill button-primary"">Add New Address</a>
        </div>
        <div class=""tab-pane fade"" id=""change-password"" role=""tabpanel"" aria-labelledby=""change-password-tab"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 mb-3"">
                    <label for=""CustomerCurrentPassword"" class=""form-label"">Old Password</label>
                    <input type=""password"" class=""form-control"" id=""CustomerCurrentPassword"" placeholder=""Current Password"">
                    <span id=""CustomerCurrentPasswordErrorMessage"" class=""text-danger""></span>
");
            WriteLiteral(@"                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 mb-3"">
                    <label for=""CustomerNewPassword"" class=""form-label"">New Password</label>
                    <input type=""password"" class=""form-control"" id=""CustomerNewPassword"" placeholder=""Password"">
                    <span id=""CustomerNewPasswordErrorMessage"" class=""text-danger""></span>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 mb-3"">
                    <label for=""CustomerConfirmPassword"" class=""form-label"">Confirm Password</label>
                    <input type=""password"" class=""form-control"" id=""CustomerConfirmPassword"" placeholder=""Confirm Password"">
                    <span id=""CustomerConfirmPasswordErrorMessage"" class=""text-danger""></span>
                </div>
            </div>
            <div>
                <button class=""btn rounded-pill button-primary"">Save</button>");
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>


<!-- Address Modal -->
<div class=""modal"" id=""CustomerAddressModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""mb-3 mt-1"">Add New Address</h3>
                <div class=""row"">
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Street name</label>
                        <input type=""text"" class=""form-control"" placeholder=""Street name"" id=""UserStreetName"" name=""UserStreetName"">
                        <span id=""ErrorMessageUserStreetName"" class=""text-danger""></span>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                     ");
            WriteLiteral(@"   <label class=""form-label"">House number</label>
                        <input type=""text"" class=""form-control"" placeholder=""House number"" id=""UserHouseNumber"" name=""UserHouseNumber"">
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Postal code</label>
                        <input type=""text"" class=""form-control"" placeholder=""Postal code"" id=""UserPostalCode"" name=""UserPostalCode"">
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">City</label>
                        <select class=""form-select m-0"" id=""UserCity"" name=""UserCity"">
                        </select>
                    </div>
                    <div class=""col-sm-12 col-md-6 mb-3"">
                        <label class=""form-label"">Phone number</label>
                        <div class=""input-group mb-3"">
                            <span class=""input-group-te");
            WriteLiteral(@"xt"" id=""basic-addon1"">+49</span>
                            <input type=""text"" class=""form-control"" id=""UserPhoneNumber"" name=""UserPhoneNumber"" placeholder=""Phone Number"" aria-label=""Username"" aria-describedby=""basic-addon1"">
                        </div>
                        <span id=""ErrorMessageUserPhoneNumber"" class=""text-danger""></span>
                    </div>
                    <div class=""col-md-12"">
                        <button class=""model-button"">Add</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Delete Confirmation Modal -->
<div class=""modal"" id=""ConfirmDeleteCustomerAddressModel"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""btn-close model-btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
 ");
            WriteLiteral(@"               <h3 class=""mb-3 mt-1"">Delete Address</h3>
                <div class=""row"">
                    <div class=""col-md-12"">Are you sure you want to delete this address?</div>
                    <div class=""col-md-12 mt-4"">
                        <button class=""btn rounded-pill button-primary"">Delete</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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