#pragma checksum "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a32748f206fb1095a1039c7895a90bf49626f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 5 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
using Senai.Finacas.Web.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a32748f206fb1095a1039c7895a90bf49626f0", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
  
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 33, true);
            WriteLiteral("<h3>Listagem de Usuários</h3>\r\n\r\n");
            EndContext();
            BeginContext(115, 20, false);
#line 8 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 179, true);
            WriteLiteral("\r\n\r\n<table>\r\n    <thead>\r\n        <th>Id</th>\r\n        <th>Nome</th>\r\n        <th>Email</th>\r\n        <th>Data Nascimento</th>\r\n        <th>Ações</th>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
        foreach (var item in ViewData["Usuarios"] as List<UsuarioModel>)
       {

#line default
#line hidden
            BeginContext(398, 59, true);
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(458, 7, false);
#line 23 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(465, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(533, 9, false);
#line 26 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(542, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(610, 10, false);
#line 29 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(620, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(688, 39, false);
#line 32 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(727, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 831, 2);
            WriteAttributeValue("", 803, "/Usuario/Excluir?id=", 803, 20, true);
#line 35 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 823, item.Id, 823, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(832, 36, true);
            WriteLiteral(">Excluir</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 868, "\"", 902, 2);
            WriteAttributeValue("", 875, "/usuario/Editar?id=", 875, 19, true);
#line 36 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 894, item.Id, 894, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(903, 54, true);
            WriteLiteral(">Editar</a>\r\n                </td>\r\n           </tr>\r\n");
            EndContext();
#line 39 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
       } 

#line default
#line hidden
            BeginContext(968, 52, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<select name=\"usuarios\">\r\n");
            EndContext();
#line 44 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
     foreach (var item in ViewData["Usuarios"] as List<UsuarioModel>) 
    {

#line default
#line hidden
            BeginContext(1099, 15, true);
            WriteLiteral("        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1114, "\"", 1133, 1);
#line 46 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1122, item.Email, 1122, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1134, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1150, 9, false);
#line 47 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 21, true);
            WriteLiteral("\r\n        </option>\r\n");
            EndContext();
#line 49 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1187, 9, true);
            WriteLiteral("</select>");
            EndContext();
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
