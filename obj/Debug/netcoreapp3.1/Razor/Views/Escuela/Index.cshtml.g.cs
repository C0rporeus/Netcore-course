#pragma checksum "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a494cd2328c4219be84cc7e0ecb1bb89553042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\_ViewImports.cshtml"
using NetCore_Estudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\_ViewImports.cshtml"
using NetCore_Estudio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a494cd2328c4219be84cc7e0ecb1bb89553042", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92787aeb8b0ab601f0d984fe17c3150f8706697e", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion escuela";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Escuela</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 6 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p><strong>Año fundacion: ");
#nullable restore
#line 7 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Escuela\Index.cshtml"
                     Write(Model.AñoFundacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>");
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