#pragma checksum "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5fe966b202983b46f5c98117b81843127c88591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\_ViewImports.cshtml"
using DojoSurveyNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\_ViewImports.cshtml"
using DojoSurveyNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fe966b202983b46f5c98117b81843127c88591", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cd6c3354d94e3153be281d351fed603f67f726", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Survey Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container box\">\r\n    <h1>Submitted info: </h1>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th scope=\"row\">Name: </th>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">Location: </th>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml"
           Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">Language: </th>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml"
           Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">Comment: </th>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\ellen\OneDrive\Coding Dojo\CSharp\aspdotnet\DojoSurveyNew\Views\Home\Results.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>");
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