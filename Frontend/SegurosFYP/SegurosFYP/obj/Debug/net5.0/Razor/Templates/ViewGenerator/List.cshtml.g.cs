#pragma checksum "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adda56b998ebb59ece10a0bd5822244d823e484a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_List), @"mvc.1.0.view", @"/Templates/ViewGenerator/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adda56b998ebb59ece10a0bd5822244d823e484a", @"/Templates/ViewGenerator/List.cshtml")]
    public class Templates_ViewGenerator_List : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
   Write(GetEnumerableTypeExpression(Model.ViewDataTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 14 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    ");
            WriteLiteral("ViewData[\"ModelName\"] = \"");
#nullable restore
#line 15 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                          Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".Replace(\"ViewModel\",\"\");\r\n");
#nullable restore
#line 16 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"

        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 19 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 20 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("<div class=\"card-header\">\r\n    ");
            WriteLiteral("<h1>");
            WriteLiteral("@ViewData[\"ModelName\"]</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 37 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
        Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
#nullable restore
#line 40 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("<p>\r\n        ");
            WriteLiteral("<a asp-action=\"Create\" class=\"btn btn-primary\"><i class=\"mdi mdi-folder-plus\"></i>Nuevo</a>\r\n        ");
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\"><i class=\"mdi mdi-folder-plus\"></i>Nuevo</button>\r\n    ");
            WriteLiteral("</p>\r\n");
            WriteLiteral("</div>\r\n");
            WriteLiteral("<table class=\"table table-responsive table-bordered\" id=\"Example\">\r\n    ");
            WriteLiteral("<thead>\r\n        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 50 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
        Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
        Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {
                if (!GetValueExpression(property).EndsWith("FechaCreacion") &&
                                !GetValueExpression(property).EndsWith("FechaModificacion") &&
                                !GetValueExpression(property).EndsWith("Estado") &&
                                !GetValueExpression(property).EndsWith("UsuarioCreacion") &&
                                !GetValueExpression(property).EndsWith("UsuarioModificacion"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\r\n                        ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 65 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </th>\r\n");
#nullable restore
#line 67 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                }
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<th></th>\r\n        ");
            WriteLiteral("</tr>\r\n    ");
            WriteLiteral("</thead>\r\n    ");
            WriteLiteral("<tbody>\r\n");
            WriteLiteral("@foreach (var item in Model) {\r\n        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 82 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {
                if (!GetValueExpression(property).EndsWith("FechaCreacion") &&
                                !GetValueExpression(property).EndsWith("FechaModificacion") &&
                                !GetValueExpression(property).EndsWith("Estado") &&
                                !GetValueExpression(property).EndsWith("UsuarioCreacion") &&
                                !GetValueExpression(property).EndsWith("UsuarioModificacion"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
#nullable restore
#line 94 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                       Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </td>\r\n");
#nullable restore
#line 96 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                }
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
               
    }
    string pkName = GetPrimaryKeyName();
    //if (pkName != null)
    //{

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<td>\r\n                ");
            WriteLiteral("<a asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 109 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                     Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-primary FetchData\" data-toggle=\"modal\" data-target=\"#EditarModal\" data-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 109 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                                                                                               Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"bi bi-pen-fill\"></i>Editar</a>\r\n                ");
            WriteLiteral("<a asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 110 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                     Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" asp-action=\"Details\" class=\"btn btn-warning\"><i class=\"fa fa-eye\"></i>Detalles</a>\r\n                ");
            WriteLiteral("<a asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 111 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                     Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#ModalEliminar\" onclick=\"ObtenerID(\'");
            WriteLiteral("@item.");
#nullable restore
#line 111 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                                                                                                 Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\"><i class=\"fa fa-trash\"></i>Eliminar</a>\r\n            ");
            WriteLiteral("</td>\r\n");
            WriteLiteral("        ");
            WriteLiteral("</tr>\r\n");
            WriteLiteral("}\r\n    ");
            WriteLiteral("</tbody>\r\n");
            WriteLiteral("</table>\r\n");
#nullable restore
#line 127 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"

/*Modales*/

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal fade\" id=\"EditarModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n        ");
            WriteLiteral("<div class=\"modal-dialog\" role=\"document\">\r\n            ");
            WriteLiteral("<div class=\"modal-content\">\r\n                ");
            WriteLiteral("<div class=\"modal-header\">\r\n                    ");
            WriteLiteral("<h5 class=\"modal-title\" id=\"exampleModalLabel\">Editar</h5>\r\n                    ");
            WriteLiteral("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        ");
            WriteLiteral("<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            WriteLiteral("</button>\r\n                ");
            WriteLiteral("</div>\r\n                ");
            WriteLiteral("<div class=\"modal-body\">\r\n                    ");
            WriteLiteral("@Html.Partial(\"_Update\", new SegurosFYP.Models.");
#nullable restore
#line 139 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                 Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ())\r\n                ");
            WriteLiteral("</div>\r\n            ");
            WriteLiteral("</div>\r\n        ");
            WriteLiteral("</div>\r\n    ");
            WriteLiteral("</div>\r\n    ");
            WriteLiteral("<div class=\"modal fade\" id=\"exampleModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n        ");
            WriteLiteral("<div class=\"modal-dialog\" role=\"document\">\r\n            ");
            WriteLiteral("<div class=\"modal-content\">\r\n                ");
            WriteLiteral("<div class=\"modal-header\">\r\n                    ");
            WriteLiteral("<h5 class=\"modal-title\" id=\"exampleModalLabel\">Insertar</h5>\r\n                    ");
            WriteLiteral("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        ");
            WriteLiteral("<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            WriteLiteral("</button>\r\n                ");
            WriteLiteral("</div>\r\n                ");
            WriteLiteral("<div class=\"modal-body\">\r\n                    ");
            WriteLiteral("@Html.Partial(\"_Insert\", new SegurosFYP.Models.");
#nullable restore
#line 154 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                 Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ())\r\n                ");
            WriteLiteral("</div>\r\n            ");
            WriteLiteral("</div>\r\n        ");
            WriteLiteral("</div>\r\n    ");
            WriteLiteral("</div>\r\n    ");
            WriteLiteral("<div class=\"modal fade\" id=\"ModalEliminar\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n        ");
            WriteLiteral("<div class=\"modal-dialog\" role=\"document\">\r\n            ");
            WriteLiteral("<div class=\"modal-content\">\r\n                ");
            WriteLiteral("<div class=\"modal-header\">\r\n                    ");
            WriteLiteral("<h5 class=\"modal-title\" id=\"exampleModalLabel\">Eliminar</h5>\r\n                    ");
            WriteLiteral("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        ");
            WriteLiteral("<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            WriteLiteral("</button>\r\n                ");
            WriteLiteral("</div>\r\n                ");
            WriteLiteral("<div class=\"modal-body\">\r\n                    ");
            WriteLiteral("@Html.Partial(\"_Delete\", new SegurosFYP.Models.");
#nullable restore
#line 169 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                 Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ())\r\n                ");
            WriteLiteral("</div>                     \r\n            ");
            WriteLiteral("</div>\r\n        ");
            WriteLiteral("</div>\r\n    ");
            WriteLiteral("</div>\r\n");
            WriteLiteral("<script>\r\n        ");
            WriteLiteral("var url = \'https://localhost:44347/api/EstadoCivil/Cargar/EstadoCivil?Estad_Id=\';\r\n");
            WriteLiteral("        ");
            WriteLiteral("document.querySelectorAll(\'.FetchData\').forEach(item => {\r\n            ");
            WriteLiteral("item.addEventListener(\'click\', function () {\r\n                ");
            WriteLiteral("var id = this.getAttribute(\'data-id\');\r\n                ");
            WriteLiteral("console.log(id);\r\n                ");
            WriteLiteral("fetchData(id);\r\n            ");
            WriteLiteral("});\r\n        ");
            WriteLiteral("});\r\n");
            WriteLiteral("        ");
            WriteLiteral("function fetchData(id) {\r\n            ");
            WriteLiteral("console.log(id);\r\n            ");
            WriteLiteral("fetch(url)\r\n                ");
            WriteLiteral(".then(response => response.json())\r\n                ");
            WriteLiteral(".then(data => {\r\n");
#nullable restore
#line 190 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"

                    foreach (var property in Model.ModelMetadata.Properties)
                    {
                        if (property.Scaffold && !property.IsAutoGenerated && !property.IsReadOnly)
                        {
                            if (!property.PropertyName.EndsWith("FechaCreacion") &&
                                !property.PropertyName.EndsWith("FechaModificacion") &&
                                !property.PropertyName.EndsWith("Estado") &&
                                !property.PropertyName.EndsWith("UsuarioCreacion") &&
                                !property.PropertyName.EndsWith("UsuarioModificacion"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("document.getElementById(\'");
#nullable restore
#line 201 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                      Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').value = data.data[0].");
#nullable restore
#line 201 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                                                                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 202 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
                            }
                        }
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("})\r\n                ");
            WriteLiteral(".catch(error => console.error(\'Hubo un error:\', error));\r\n        ");
            WriteLiteral("}\r\n    ");
            WriteLiteral("</script>\r\n");
#nullable restore
#line 210 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"

    if(!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 216 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 219 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\List.cshtml"
 
    string GetPrimaryKeyName()
    {
        return (Model.ModelMetadata.PrimaryKeys != null && Model.ModelMetadata.PrimaryKeys.Length == 1)
        ? Model.ModelMetadata.PrimaryKeys[0].PropertyName
        : null;
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
    }

    string GetEnumerableTypeExpression(string typeName)
    {
        return "IEnumerable<" + typeName + ">";
    }

#line default
#line hidden
#nullable disable
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
