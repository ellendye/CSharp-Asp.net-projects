#pragma checksum "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8fa75321371ba8e7a19bd45732831f87bd4ad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quotes), @"mvc.1.0.view", @"/Views/Home/Quotes.cshtml")]
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
#line 1 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\_ViewImports.cshtml"
using quotingDojo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\_ViewImports.cshtml"
using quotingDojo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8fa75321371ba8e7a19bd45732831f87bd4ad1", @"/Views/Home/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed270337e8f1fe98804b7a853320639ca205eed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
  
    ViewData["Title"] = "Quoting Dojo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"display-4 m-3\">Here are the awesome quotes!</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
 foreach(var user in ViewBag.Quotes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <p class=\"text-left\">\"");
#nullable restore
#line 11 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
                         Write(user["quote"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n        <p class=\"ml-4 font-italic\">- ");
#nullable restore
#line 12 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
                                 Write(user["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
                                               Write(user["created_at"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <hr>\r\n");
#nullable restore
#line 15 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\quotingDojo\Views\Home\Quotes.cshtml"
}

#line default
#line hidden
#nullable disable
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
