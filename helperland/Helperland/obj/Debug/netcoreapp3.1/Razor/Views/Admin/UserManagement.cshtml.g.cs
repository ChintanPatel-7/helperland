#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserManagement), @"mvc.1.0.view", @"/Views/Admin/UserManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f91e67fb2fdc1bf68d8402d136941dd2f8fbc08", @"/Views/Admin/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652f112e8065873fe745ee9ca2551637344ad94", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/admin-panel/group-38.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("position-relative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Admin\UserManagement.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    ViewData["Title"] = "User Management";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"data-table\">\r\n    <table id=\"user-management\">\r\n        <thead>\r\n            <tr>\r\n                <th>User Name <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 251, "\"", 257, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>User Type</th>\r\n                <th>Role</th>\r\n                <th>Postal Code <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 386, "\"", 392, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>City</th>\r\n                <th>Radius <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 480, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                <th>User Status <img class=\"sort-img\"");
            BeginWriteAttribute("alt", " alt=\"", 548, "\"", 554, 0);
            EndWriteAttribute();
            WriteLiteral(@"></th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <!-- 1&2 row -->
            <tr>
                <td>Lyum watson</td>
                <td>Call Center</td>
                <td>Inquiry Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc087197", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Service provider</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td>10 km</td>
                <td><label class="" lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc089389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <!-- 3&4 row -->
            <tr>
                <td>John Smith</td>
                <td>Call Center</td>
                <td>Inquiry Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0811615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Customer</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
  ");
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0813921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <!-- 5&6 row -->
            <tr>
                <td>John Smith</td>
                <td>Call Center</td>
                <td>Content Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data");
            WriteLiteral("-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0816277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Customer</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-danger"">Inactive</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
 ");
            WriteLiteral("                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0818584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <!-- 7&8 row -->
            <tr>
                <td>John Smith</td>
                <td>Service provider</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td>20 km</td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-t");
            WriteLiteral("oggle=\"dropdown\" aria-expanded=\"false\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0820935", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Call Center</td>
                <td>Finance Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-exp");
            WriteLiteral("anded=\"false\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0823261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <!-- 9&10 row -->
            <tr>
                <td>John Smith</td>
                <td>Customer</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropd");
            WriteLiteral("own\" aria-expanded=\"false\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0825600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Customer</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
  ");
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0827906", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>

            <!-- 1&2 row -->
            <tr>
                <td>Lyum watson</td>
                <td>Call Center</td>
                <td>Inquiry Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                d");
            WriteLiteral("ata-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0830265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Service provider</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td>10 km</td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0832457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <!-- 3&4 row -->
            <tr>
                <td>John Smith</td>
                <td>Call Center</td>
                <td>Inquiry Manager</td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0834684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr>
                <td>John Smith</td>
                <td>Customer</td>
                <td></td>
                <td>123456</td>
                <td>Berlin</td>
                <td></td>
                <td><label class=""lbl-btn lbl-success"">Active</label></td>
                <td>
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle"" type=""button"" id=""dropdownMenuButton1""
                                data-bs-toggle=""dropdown"" aria-expanded=""false"">
  ");
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f91e67fb2fdc1bf68d8402d136941dd2f8fbc0836990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </button>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <li><a class=""dropdown-item"" href=""#"">Edit</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Deactivate</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Service History</a></li>
                        </ul>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
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
