#pragma checksum "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80bb4370b63b88f5331f1545d50da67e4a2675d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\_ViewImports.cshtml"
using Agenda_de_Contatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\_ViewImports.cshtml"
using Agenda_de_Contatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80bb4370b63b88f5331f1545d50da67e4a2675d", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05260a74c63dce5df40044ad5ed91916d4037929", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Agenda_de_Contatos.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
  
    ViewData["Title"] = "Contatos Cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"alert alert\"-dark row align-content-center>\r\n    <div class=\"col-10 align-content-start\">\r\n        <h6>");
#nullable restore
#line 10 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" contatos cadastrados</h6>\r\n    </div>\r\n\r\n    <div class=\"col-2 align-content-end\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e80bb4370b63b88f5331f1545d50da67e4a2675d5215", async() => {
                WriteLiteral("Novo Contato");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 19 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
     if (TempData["ContatoNovo"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-success\">");
#nullable restore
#line 21 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                  Write(TempData["ContatoNovo"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
    }
    else if (TempData["Contato Atualizado"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-primary\">");
#nullable restore
#line 25 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                  Write(TempData["Contato Atualizado"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
    }
    else if (TempData["Contato Excluido"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\">");
#nullable restore
#line 29 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                 Write(TempData["Contato Atualizado"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<hr /> \r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
     foreach (var item in Model)
    {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-4 pt-5\">\r\n        <div class=\"card\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1054, "\"", 1083, 1);
#nullable restore
#line 41 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
WriteAttributeValue("", 1060, Url.Content(item.Foto), 1060, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" height=\"350\" />\r\n            <div class=\"card-title\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-9 align-content-start\">\r\n                        <h5>");
#nullable restore
#line 45 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                  Write(item.Sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 45 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                                    Write(item.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos</h5>\r\n                    </div>\r\n\r\n                    <div class=\"col-3 badge-pill badge-secondary\">\r\n                        <text class=\"align-middle\">");
#nullable restore
#line 49 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                              Write(item.TipoTelefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-text\">\r\n                <h6 class=\"badge badge-info\">");
#nullable restore
#line 54 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                        Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"badge badge-warning\">");
#nullable restore
#line 55 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e80bb4370b63b88f5331f1545d50da67e4a2675d11534", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pessoaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
                                                    WriteLiteral(item.PessoaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pessoaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pessoaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pessoaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1977, "\"", 2022, 3);
            WriteAttributeValue("", 1987, "ConfirmarExclusao(", 1987, 18, true);
#nullable restore
#line 62 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
WriteAttributeValue("", 2005, item.PessoaId, 2005, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2021, ")", 2021, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger\">Deletar</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\Agenda de Contatos\Agenda de Contatos\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Confirmação de exclusão</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Prosseguir com a exclusão do contato <text class=""nomeContato""></text> ?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary btnFechar"" data-dismiss=""modal"">Não</button>
                <button type=""button"" class=""btn btn-outline-danger btnExcluir"" data-dismiss=""modal"">Sim</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function ConfirmarExclusao(pessoaId) {
           // $("".nomeContato"").text(nomeContato);
            $("".modal"").modal();
            $("".btnExcluir"").on('click', function () {
                $.ajax({
                    url: 'Pessoas/ExcluirPessoa',
                    method: 'POST',
                    data: { pessoaId: pessoaId },
                    success: function (data) {                       
                        location.reload(true);
                    }
                });
            });
            $("".btnFechar"").on('click', function() {
                pessoaId = null;
                nomeContato = null;
                $("".modal"").modal('hide');
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Agenda_de_Contatos.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591