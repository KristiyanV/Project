#pragma checksum "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af90c296ac4ab0ceb6078187de762ea8d10a0353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestDrive_All), @"mvc.1.0.view", @"/Views/TestDrive/All.cshtml")]
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
#line 1 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\_ViewImports.cshtml"
using BgAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\_ViewImports.cshtml"
using BgAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af90c296ac4ab0ceb6078187de762ea8d10a0353", @"/Views/TestDrive/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4a413bec6ef8e2b24016692139cfea7da9c115b", @"/Views/_ViewImports.cshtml")]
    public class Views_TestDrive_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BgAuto.Models.TestDriveListingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All test drive made</h1>\r\n<table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
               Write(Html.DisplayNameFor(model => model.TestOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TestOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Student\Documents\Krisi12b\Project\BgAuto\BgAuto\Views\TestDrive\All.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BgAuto.Models.TestDriveListingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
