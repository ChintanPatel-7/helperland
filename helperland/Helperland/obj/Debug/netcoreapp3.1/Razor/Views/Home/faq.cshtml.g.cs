#pragma checksum "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80361c489ca11ec96937f533d16d63ec994597ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_faq), @"mvc.1.0.view", @"/Views/Home/faq.cshtml")]
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
using Helperland.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80361c489ca11ec96937f533d16d63ec994597ca", @"/Views/Home/faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37af33ccc2e6708637d6862e4cae0b6557aac472", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/faq/group-16.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NewsLetter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Company\Training\PSD to HTML\website\helperland\Helperland\Views\Home\faq.cshtml"
  
    ViewData["Title"] = "FAQ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Header Image -->\r\n<section class=\"header-img\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80361c489ca11ec96937f533d16d63ec994597ca4694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</section>

<!-- faq Question -->
<section class=""faq pt-0"" id=""faq"">
    <div class=""max-width-946"">

        <div class=""faq-questions"">
            <div class=""text-center position-relative mb-75"">
                <h2 class=""star-title"">FAQs</h2>
            </div>
            <p class=""text-center mb-36"">
                Whether you are Customer or Service provider,<br>
                We have tried our best to solve all your queries and questions.
            </p>

            <div class=""question-tab"">
                <ul class=""nav nav-pills mb-3 nav-justified"" id=""pills-tab"" role=""tablist"">
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""nav-link active"" id=""customer-tab"" data-bs-toggle=""pill""
                                data-bs-target=""#customer-home"" type=""button"" role=""tab"" aria-controls=""customer-home""
                                aria-selected=""true"">
                            For Customer
                      ");
            WriteLiteral(@"  </button>
                    </li>
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""nav-link"" id=""service-provider-tab"" data-bs-toggle=""pill""
                                data-bs-target=""#service-provider"" type=""button"" role=""tab"" aria-controls=""service-provider""
                                aria-selected=""false"">
                            For Service Provider
                        </button>
                    </li>
                </ul>

                <div class=""tab-content"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active"" id=""customer-home"" role=""tabpanel""
                         aria-labelledby=""customer-tab"">
                        <div class=""accordion accordion-flush"" id=""customer-accordion"">
                            <div class=""accordion-item"">
                                <h6 class=""accordion-header"" id=""customer-headingOne"">
                                    <button class=""");
            WriteLiteral(@"accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#customer-collapseOne""
                                            aria-expanded=""false"" aria-controls=""customer-collapseOne"">
                                        What's included in a cleaning?
                                    </button>
                                </h6>
                                <div id=""customer-collapseOne"" class=""accordion-collapse collapse""
                                     aria-labelledby=""customer-headingOne"" data-bs-parent=""#customer-accordion"">
                                    <div class=""accordion-body"">
                                        Bedroom, Living Room & Common Areas, Bathrooms, Kitchen, Extras
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion-item"">
                                <h6 class=""ac");
            WriteLiteral(@"cordion-header"" id=""customer-headingTwo"">
                                    <button class=""accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#customer-collapseTwo""
                                            aria-expanded=""false"" aria-controls=""customer-collapseTwo"">
                                        Which Helperland professional will come to my place?
                                    </button>
                                </h6>
                                <div id=""customer-collapseTwo"" class=""accordion-collapse collapse""
                                     aria-labelledby=""customer-headingTwo"" data-bs-parent=""#customer-accordion"">
                                    <div class=""accordion-body"">
                                        Helperland has a vast network of experienced, top-rated cleaners. Based on the time and date of your request, we work to assign the best professional available. Like workin");
            WriteLiteral(@"g with a specific pro? Add them to your Pro Team from the mobile app and they'll be requested first for all future bookings. You will receive an email with details about your professional prior to your appointment.
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion-item"">
                                <h6 class=""accordion-header"" id=""customer-headingThree"">
                                    <button class=""accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#customer-collapseThree""
                                            aria-expanded=""false"" aria-controls=""customer-collapseThree"">
                                        Can I skip or reschedule bookings?
                                    </button>
                                </h6>
                                <div id=""customer-collapseThree"" ");
            WriteLiteral(@"class=""accordion-collapse collapse""
                                     aria-labelledby=""customer-headingThree"" data-bs-parent=""#customer-accordion"">
                                    <div class=""accordion-body"">
                                        You can reschedule any booking for free at least 24 hours in advance of the scheduled start time. If you need to skip a booking within the minimum commitment, we’ll credit the value of the booking to your account. You can use this credit on future cleanings and other Helperland services.
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion-item"">
                                <h6 class=""accordion-header"" id=""customer-headingFour"">
                                    <button class=""accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#customer-collapseFour""
   ");
            WriteLiteral(@"                                         aria-expanded=""false"" aria-controls=""customer-collapseFour"">
                                        Do I need to be home for the booking?
                                    </button>
                                </h6>
                                <div id=""customer-collapseFour"" class=""accordion-collapse collapse""
                                     aria-labelledby=""customer-headingFour"" data-bs-parent=""#customer-accordion"">
                                    <div class=""accordion-body"">
                                        We strongly recommend that you are home for the first clean of your booking to show your cleaner around. Some customers choose to give a spare key to their cleaner, but this decision is based on individual preferences.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""");
            WriteLiteral(@"tab-pane fade"" id=""service-provider"" role=""tabpanel""
                         aria-labelledby=""service-provider-tab"">
                        <div class=""accordion accordion-flush"" id=""service-provider-accordion"">
                            <div class=""accordion-item"">
                                <h6 class=""accordion-header"" id=""service-provider-headingOne"">
                                    <button class=""accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#service-provider-collapseOne""
                                            aria-expanded=""false"" aria-controls=""service-provider-collapseOne"">
                                        How much do service providers earn?
                                    </button>
                                </h6>
                                <div id=""service-provider-collapseOne"" class=""accordion-collapse collapse""
                                     aria-labelledby=""ser");
            WriteLiteral(@"vice-provider-headingOne"" data-bs-parent=""#service-provider-accordion"">
                                    <div class=""accordion-body"">
                                        The self-employed service providers working with Helperland set their own payouts, this means that they decide how much they earn per hour.
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion-item"">
                                <h6 class=""accordion-header"" id=""service-provider-headingTwo"">
                                    <button class=""accordion-button collapsed"" type=""button""
                                            data-bs-toggle=""collapse"" data-bs-target=""#service-provider-collapseTwo""
                                            aria-expanded=""false"" aria-controls=""service-provider-collapseTwo"">
                                        What support do you provide to the service providers?
          ");
            WriteLiteral(@"                          </button>
                                </h6>
                                <div id=""service-provider-collapseTwo"" class=""accordion-collapse collapse""
                                     aria-labelledby=""service-provider-headingTwo"" data-bs-parent=""#service-provider-accordion"">
                                    <div class=""accordion-body"">
                                        Our call-centre is available to assist the service providers with all queries or issues in regards to their bookings during office hours. Before a service provider starts receiving jobs, every individual partner receives an orientation session to familiarise with the online platform and their profile.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80361c489ca11ec96937f533d16d63ec994597ca16557", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
