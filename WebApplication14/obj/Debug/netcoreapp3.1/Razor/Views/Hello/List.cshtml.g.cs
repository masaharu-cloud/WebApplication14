#pragma checksum "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f1f816ed611a54e6ad41dc3fe0866dc4d30244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_List), @"mvc.1.0.view", @"/Views/Hello/List.cshtml")]
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
#line 1 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\_ViewImports.cshtml"
using WebApplication14;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\_ViewImports.cshtml"
using WebApplication14.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f1f816ed611a54e6ad41dc3fe0866dc4d30244", @"/Views/Hello/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed31929ca996604b1aad3b646e0d4134ed54058", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication14.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
  
    ViewData["Title"] = "List";
    //Layout = "_MyLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>List</h1>\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>書名</th>\r\n            <th>価格</th>\r\n            <th>著者</th>\r\n            <th>配布サンプル</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
               Write(item.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
               Write(item.Sample);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\li3201\source\repos\WebApplication14\WebApplication14\Views\Hello\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication14.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
