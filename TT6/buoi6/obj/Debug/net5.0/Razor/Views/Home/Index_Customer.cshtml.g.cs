#pragma checksum "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Home\Index_Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86b51888d6b69ae43f966c625e5f61a180100753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index_Customer), @"mvc.1.0.view", @"/Views/Home/Index_Customer.cshtml")]
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
#line 1 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86b51888d6b69ae43f966c625e5f61a180100753", @"/Views/Home/Index_Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbe55abea7f39e35f2fe4962a48bbf2d9f74e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Home\Index_Customer.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    ViewData["Title"] = "Trang Khách Hàng";
    string username;
    if(ViewBag.AccountUsername!=null)
    {
        username = ViewBag.AccountUsername;
    }
    else
    {
        username= "Khách";
    }
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 17 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Home\Index_Customer.cshtml"
                             Write(username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Trang Khách Hàng</p>\r\n</div>\r\n");
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
