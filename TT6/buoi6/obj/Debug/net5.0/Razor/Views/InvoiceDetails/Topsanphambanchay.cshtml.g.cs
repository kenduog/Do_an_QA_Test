#pragma checksum "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c8cd7a05402811ef90b009217fdf2be2ff03bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceDetails_Topsanphambanchay), @"mvc.1.0.view", @"/Views/InvoiceDetails/Topsanphambanchay.cshtml")]
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
#line 1 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\_ViewImports.cshtml"
using buoi6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c8cd7a05402811ef90b009217fdf2be2ff03bc", @"/Views/InvoiceDetails/Topsanphambanchay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbe55abea7f39e35f2fe4962a48bbf2d9f74e1", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceDetails_Topsanphambanchay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<buoi6.Models.InvoiceDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml"
  
    ViewData["Title"] = "Index";
    var kq = from top in Model
             group top by top.Product.Name into gr
             let quatity = gr.Sum(top => top.Quantity)
             orderby quatity descending
             select new
             {
                 product = gr.Key,
                 soluong = quatity
             };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Top sản phẩm bán chạy</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Product
            </th>
            <th>
                Số lượng
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml"
         foreach(var item in kq)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml"
           Write(Html.DisplayFor(modelItem => item.product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml"
           Write(Html.DisplayFor(modelItem => item.soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 41 "D:\Edit ASPdotNET_CORE\TT6\buoi6\Views\InvoiceDetails\Topsanphambanchay.cshtml"
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