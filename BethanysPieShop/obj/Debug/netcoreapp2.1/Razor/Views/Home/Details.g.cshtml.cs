#pragma checksum "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeac1acf18f5e2177dc3659b7ad94b3aa23b44db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeac1acf18f5e2177dc3659b7ad94b3aa23b44db", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5dfc61500ac35f88041edbb91cce5c73559cd1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(55, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(60, 17, false);
#line 5 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(77, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(82, 10, false);
#line 5 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(92, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(127, 35, true);
            WriteLiteral("\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 162, "\"", 179, 1);
#line 10 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
WriteAttributeValue("", 168, Model.Name, 168, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 180, "\"", 201, 1);
#line 10 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
WriteAttributeValue("", 186, Model.ImageUrl, 186, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(202, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(269, 11, false);
#line 12 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(280, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(326, 10, false);
#line 14 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(336, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(370, 22, false);
#line 16 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(392, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(411, 21, false);
#line 17 "C:\Users\ONI David Adedoyin\source\repos\BethanyPieShop\BethanysPieShop\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(432, 24, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
