#pragma checksum "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fd9a70abf4fa6dde792b2fbd1d2354701857ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Versioned_Bootstrap3_List), @"mvc.1.0.view", @"/Templates/ViewGenerator_Versioned/Bootstrap3/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fd9a70abf4fa6dde792b2fbd1d2354701857ac", @"/Templates/ViewGenerator_Versioned/Bootstrap3/List.cshtml")]
    public class Templates_ViewGenerator_Versioned_Bootstrap3_List : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
   Write(GetEnumerableTypeExpression(Model.ViewDataTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
  
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
#line 14 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 15 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 17 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 18 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h2>");
#nullable restore
#line 21 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
 Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
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
#line 35 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
#nullable restore
#line 38 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            WriteLiteral("<a asp-action=\"Create\">Create New</a>\r\n");
            WriteLiteral("</p>\r\n");
            WriteLiteral("<table class=\"table\">\r\n    ");
            WriteLiteral("<thead>\r\n        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 46 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
        Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 55 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n");
#nullable restore
#line 57 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 61 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n");
#nullable restore
#line 63 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
            }
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
#line 71 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
#nullable restore
#line 77 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                               Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </td>\r\n");
#nullable restore
#line 79 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
#nullable restore
#line 83 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                               Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 83 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                                               Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </td>\r\n");
#nullable restore
#line 85 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
            }
        }
        string pkName = GetPrimaryKeyName();
        if (pkName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<td>\r\n                ");
            WriteLiteral("<a asp-action=\"Edit\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 91 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                       Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n                ");
            WriteLiteral("<a asp-action=\"Details\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 92 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                          Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Details</a> |\r\n                ");
            WriteLiteral("<a asp-action=\"Delete\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 93 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
                                                         Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n            ");
            WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Edit\", \"Edit\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Delete\", \"Delete\", new { /* id=item.PrimaryKey */ })\r\n            </td>\r\n");
#nullable restore
#line 103 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("</tr>\r\n");
            WriteLiteral("}\r\n    ");
            WriteLiteral("</tbody>\r\n");
            WriteLiteral("</table>\r\n");
#nullable restore
#line 109 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
    if(!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 114 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\List.cshtml"
 
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
