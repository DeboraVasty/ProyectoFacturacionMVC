#pragma checksum "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9cc882b1610320a71273fa41707b819874f1112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_Index), @"mvc.1.0.view", @"/Views/Reportes/Index.cshtml")]
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
#line 1 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\_ViewImports.cshtml"
using FacturacionMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\_ViewImports.cshtml"
using FacturacionMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cc882b1610320a71273fa41707b819874f1112", @"/Views/Reportes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287c032ab9d884a3249b50cf0c87bffc4ff8fc1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 12 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n   \r\n  \r\n        \r\n            ");
#nullable restore
#line 23 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Reportes\Index.cshtml"
       Write(Html.ActionLink("Reporte facturas", "ReporteFacturas", new { todos = 0, fechaInicio = "", fechaFinal = "" }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n  \r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
