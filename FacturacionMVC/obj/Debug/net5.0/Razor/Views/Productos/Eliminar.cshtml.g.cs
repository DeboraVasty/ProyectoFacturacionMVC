#pragma checksum "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd356a1d9d4ad062ad7ab24ee67a329e21aaba8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Eliminar), @"mvc.1.0.view", @"/Views/Productos/Eliminar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd356a1d9d4ad062ad7ab24ee67a329e21aaba8d", @"/Views/Productos/Eliminar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287c032ab9d884a3249b50cf0c87bffc4ff8fc1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Eliminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FacturacionMVC.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
  
    ViewData["Title"] = "Eliminar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Desea Eliminar?</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd356a1d9d4ad062ad7ab24ee67a329e21aaba8d3840", async() => {
                WriteLiteral("\r\n    <table>\r\n\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 12 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.CodigoProducto));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 13 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.CodigoProducto));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 18 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 19 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 23 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 24 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 29 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 30 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 35 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Costo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 36 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Costo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 41 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Existencia));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 42 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Existencia));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 45 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayNameFor(m => m.Activo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 46 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.DisplayFor(m => m.Activo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n            <td> <a");
                BeginWriteAttribute("href", " href=\"", 1271, "\"", 1359, 1);
#nullable restore
#line 51 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
WriteAttributeValue("", 1278, Url.Action("ConfirmacionEliminar","Productos",new { id = Model.CodigoProducto }), 1278, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <input type=\"button\" value=\"Eliminar\" class=\"btn btn-danger\" /></a></td>\r\n\r\n            <td> ");
#nullable restore
#line 53 "C:\Users\devas\source\repos\FacturacionMVC\FacturacionMVC\Views\Productos\Eliminar.cshtml"
            Write(Html.ActionLink("Regresar", "Index", "Productos"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FacturacionMVC.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591