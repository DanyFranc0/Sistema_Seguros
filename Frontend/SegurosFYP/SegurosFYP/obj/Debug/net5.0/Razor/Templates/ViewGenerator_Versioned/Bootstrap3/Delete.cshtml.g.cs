#pragma checksum "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a12b3c82f63a05a656693b721226400b61f392f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Versioned_Bootstrap3_Delete), @"mvc.1.0.view", @"/Templates/ViewGenerator_Versioned/Bootstrap3/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a12b3c82f63a05a656693b721226400b61f392f0", @"/Templates/ViewGenerator_Versioned/Bootstrap3/Delete.cshtml")]
    public class Templates_ViewGenerator_Versioned_Bootstrap3_Delete : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
   Write(Model.ViewDataTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
  
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
#line 14 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 15 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 17 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 18 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h2>");
#nullable restore
#line 21 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
 Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
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
#line 35 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>");
#nullable restore
#line 44 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
   Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 47 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
  
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
            WriteLiteral("        <dt>\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 57 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                            Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd>\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 60 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 62 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }
        else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 66 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                            Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd>\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 69 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                        Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 69 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                                        Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 71 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("</dl>\r\n    ");
            WriteLiteral("\r\n    ");
            WriteLiteral("<form asp-action=\"");
#nullable restore
#line 75 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                   Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 76 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
        foreach (var property in Model.ModelMetadata.Properties)
        {
            if(property.IsPrimaryKey){

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 79 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                   Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 80 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
            WriteLiteral("<a asp-action=\"Index\">Back to List</a>\r\n    ");
            WriteLiteral("</form>\r\n");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 86 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 91 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator_Versioned\Bootstrap3\Delete.cshtml"
 
    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
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
