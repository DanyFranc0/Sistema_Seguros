#pragma checksum "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc25d3ea26cec92ff0a4c55d28628eb6c1626d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
#line 1 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc25d3ea26cec92ff0a4c55d28628eb6c1626d64", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea44def9759b7c4184a824174e6e654cf5b12dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SegurosFYP.Models.EmpleadoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary FetchData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#EditarModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#ModalEliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["ModelName"] = "EmpleadoViewModel".Replace("ViewModel","");
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header\">\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
   Write(ViewData["ModelName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>\r\n");
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal""><i class=""mdi mdi-folder-plus""></i>Nuevo</button>
    </p>
</div>
<table class=""table table-responsive table-bordered"" id=""Example"">
    <thead>
        <tr>

            <th>
                ");
#nullable restore
#line 21 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cargo_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perso_PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perso_SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perso_PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perso_SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perso_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cargo_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc25d3ea26cec92ff0a4c55d28628eb6c1626d6411021", async() => {
                WriteLiteral("<i class=\"bi bi-pencil\"></i>Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
                     WriteLiteral(item.Emple_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
                                                                                                                                                    Write(item.Emple_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2320, "\"", 2389, 1);
#nullable restore
#line 66 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
WriteAttributeValue("", 2327, Url.Action("Details","Cargo", new {Emple_Id = item.Emple_Id}), 2327, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"bi bi-eye\"></i>Detalles</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc25d3ea26cec92ff0a4c55d28628eb6c1626d6414574", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
                     WriteLiteral(item.Emple_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2598, "ObtenerID(\'", 2598, 11, true);
#nullable restore
#line 67 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
AddHtmlAttributeValue("", 2609, item.Emple_Id, 2609, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2623, "\')", 2623, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div class=""modal fade"" id=""EditarModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Editar</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
#nullable restore
#line 83 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
               Write(Html.Partial("_Update", new SegurosFYP.Models.EmpleadoViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Insertar</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
#nullable restore
#line 98 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
               Write(Html.Partial("_Insert", new SegurosFYP.Models.EmpleadoViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""ModalEliminar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
#nullable restore
#line 113 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Empleado\Index.cshtml"
               Write(Html.Partial("_Delete", new SegurosFYP.Models.EmpleadoViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>                     
            </div>
        </div>
    </div>
<script>
    document.querySelectorAll('.FetchData').forEach(item => {
        item.addEventListener('click', function () {
            var id = this.getAttribute('data-id');
            console.log(id);
            fetchData(id);
        });
    });
    function fetchData(id) {
        console.log(id);
        fetch('https://localhost:44327/api/Empleado/Cargar/Empleados?Emple_Id=' + id)
            .then(response => response.json())
            .then(data => {
                var dany = JSON.stringify(data.data);
                document.getElementById('Emple_Id').value = data.data[0].emple_Id;
                document.getElementById('Cargo_Id').value = data.data[0].cargo_Id;
            })
            .catch(error => console.error('Hubo un error:', error));
    }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SegurosFYP.Models.EmpleadoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
