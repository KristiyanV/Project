#pragma checksum "C:\Users\PC123\Desktop\Нова папка (12)\Project\BgAuto\BgAuto\Views\Contact\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47474a01fc82fc125a7bce71a51e966afac585c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contacts), @"mvc.1.0.view", @"/Views/Contact/Contacts.cshtml")]
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
#line 1 "C:\Users\PC123\Desktop\Нова папка (12)\Project\BgAuto\BgAuto\Views\_ViewImports.cshtml"
using BgAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC123\Desktop\Нова папка (12)\Project\BgAuto\BgAuto\Views\_ViewImports.cshtml"
using BgAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47474a01fc82fc125a7bce71a51e966afac585c1", @"/Views/Contact/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4a413bec6ef8e2b24016692139cfea7da9c115b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css\">\r\n<script src=\"https://kit.fontawesome.com/2ca93d86e5.js\" crossorigin=\"anonymous\"></script>\r\n<div class=\"container contact-form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47474a01fc82fc125a7bce71a51e966afac585c13802", async() => {
                WriteLiteral("\r\n        <h3>Drop Us a Message</h3>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" name=\"txtName\" class=\"form-control\" placeholder=\"Your Name *\"");
                BeginWriteAttribute("value", " value=\"", 504, "\"", 512, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" name=\"txtEmail\" class=\"form-control\" placeholder=\"Your Email *\"");
                BeginWriteAttribute("value", " value=\"", 686, "\"", 694, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" name=\"txtPhone\" class=\"form-control\" placeholder=\"Your Phone Number *\"");
                BeginWriteAttribute("value", " value=\"", 875, "\"", 883, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" name=""btnSubmit"" class=""btnContact"" value=""Send Message"" />
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <textarea name=""txtMsg"" class=""form-control"" placeholder=""Your Message *"" style=""width: 100%; height: 150px;""></textarea>
                </div>
                <ul class=""list-unstyled mb-0"">
                    <li>
                        <p><i class=""fa fa-map-marker"" aria-hidden=""true""></i> България, Перник, ул.Отец Паисий, бл.58, ап.57, вх.В ет.6</p>
                    </li>

                    <li>
                        <p><i class=""fa fa-phone"" aria-hidden=""true""></i> 0894535386</p>
                    </li>

                    <li>
                        <p><i class=""fa fa-envelope"" aria-hidden=""true""></i> k.vladimirov2017@pmg-pernik.com</p>
                    </li>
    ");
                WriteLiteral("            </ul>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
