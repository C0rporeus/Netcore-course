#pragma checksum "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\ListaObjetoEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f267a65710a1cedaacdc74a6e7515934a3ed2e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
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
#line 1 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\_ViewImports.cshtml"
using NetCore_Estudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\_ViewImports.cshtml"
using NetCore_Estudio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f267a65710a1cedaacdc74a6e7515934a3ed2e45", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92787aeb8b0ab601f0d984fe17c3150f8706697e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-dark table-hover table-sm\">\r\n<thead>\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <th scope=\"col\">Id</th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");
#nullable restore
#line 12 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\ListaObjetoEscuela.cshtml"
     foreach(var obj in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 15 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\ListaObjetoEscuela.cshtml"
       Write(obj.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\ListaObjetoEscuela.cshtml"
       Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 18 "e:\ProyectosdeProgramacion\Csharp\NetCore-Estudio\Views\Shared\ListaObjetoEscuela.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>");
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