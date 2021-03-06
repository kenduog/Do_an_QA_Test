#pragma checksum "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8d6a2505287f37588a6319877eeab00fd885d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_Doạnhthutheonam), @"mvc.1.0.view", @"/Views/Invoices/Doạnhthutheonam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8d6a2505287f37588a6319877eeab00fd885d7", @"/Views/Invoices/Doạnhthutheonam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbe55abea7f39e35f2fe4962a48bbf2d9f74e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_Doạnhthutheonam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<buoi6.Models.Invoice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml"
  
    ViewData["Title"] = "Index";
    DateTime now = DateTime.Now;
    var doanhthuthang = from d in Model
                        where d.IsuedDate.Year == now.Year
                        group d by d.IsuedDate.Year==now.Year into gr
                        let dtd = gr.Sum(t => t.Total)
                        select new
                        {
                            thang = " Năm " + now.Year,
                            doanhthu = dtd+" VNĐ",
                        };
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Doanh thu hôm nay</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Tháng 
            </th>
            <th>
                Doanh thu
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml"
         foreach (var item in doanhthuthang)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml"
               Write(Html.DisplayFor(modelItem => item.thang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml"
               Write(Html.DisplayFor(modelItem => item.doanhthu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\QuangTrung\KTPM\Do_an_QA_Test\TT6\buoi6\Views\Invoices\Doạnhthutheonam.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<buoi6.Models.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
