#pragma checksum "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98bd8eebb979811a5d5fea5e5b5ff037420d7537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceDetails_Doanhsotheongay), @"mvc.1.0.view", @"/Views/InvoiceDetails/Doanhsotheongay.cshtml")]
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
#line 1 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bd8eebb979811a5d5fea5e5b5ff037420d7537", @"/Views/InvoiceDetails/Doanhsotheongay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbe55abea7f39e35f2fe4962a48bbf2d9f74e1", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceDetails_Doanhsotheongay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<buoi6.Models.InvoiceDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml"
  
    ViewData["Title"] = "Doanh số bán ra hôm nay";
    DateTime now = DateTime.Now;
    var Doanhsotheongay = from d in Model
                          where d.Invoice.IsuedDate.Day == now.Day && d.Invoice.IsuedDate.Month == now.Month && d.Invoice.IsuedDate.Year == now.Year
                          group d by d.Invoice.IsuedDate.Day == now.Day && d.Invoice.IsuedDate.Month == now.Month && d.Invoice.IsuedDate.Year == now.Year into gr
                          let ds = gr.Sum(t => t.Quantity)
                          select new
                          {
                              homnay = "Ngày " + now.Day + " tháng " + now.Month + " năm " + now.Year,
                              doanhso = ds+" sản phẩm"
                          };


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Doanh số bán ra hôm nay</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Ngày
            </th>
            <th>
                Doanh số
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 32 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml"
         foreach (var item in Doanhsotheongay)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml"
               Write(Html.DisplayFor(modelItem => item.homnay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml"
               Write(Html.DisplayFor(modelItem => item.doanhso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\Edit ASPdotNET_CORE\24_12_21 Do_an\Asp_Doan\Do_an_QA_Test\TT6\buoi6\Views\InvoiceDetails\Doanhsotheongay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<buoi6.Models.InvoiceDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
