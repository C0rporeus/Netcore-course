#pragma checksum "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\AsignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e2ea4b51b273a7b1d413b67563e2ca84700e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AsignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/AsignaturaSimple.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e2ea4b51b273a7b1d413b67563e2ca84700e64", @"/Views/Shared/AsignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92787aeb8b0ab601f0d984fe17c3150f8706697e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AsignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Nombre:  ");
#nullable restore
#line 3 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\AsignaturaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n   Id: ");
#nullable restore
#line 4 "E:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\AsignaturaSimple.cshtml"
  Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591