#pragma checksum "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cc800a69d7e378b3845347b92da1fef2e23e41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Edit), @"mvc.1.0.view", @"/Templates/ViewGenerator/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cc800a69d7e378b3845347b92da1fef2e23e41", @"/Templates/ViewGenerator/Edit.cshtml")]
    public class Templates_ViewGenerator_Edit : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
   Write(Model.ViewDataTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
  
    if (Model.IsPartialView)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("@{\r\n        ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 12 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                          Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        ");
            WriteLiteral("ViewData[\"ModelName\"] = \"");
#nullable restore
#line 13 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".Replace(\"ViewModel\",\"\");\r\n");
#nullable restore
#line 14 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 16 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                   Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 17 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("}\r\n        ");
            WriteLiteral("\r\n                 ");
            WriteLiteral("<form asp-action=\"Update\">\r\n            ");
            WriteLiteral("<div class=\"d-flex justify-content-center flex-wrap\">\r\n            ");
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 23 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
        foreach (PropertyMetadata property in Model.ModelMetadata.Properties)
        {
            if (!property.PropertyName.EndsWith("FechaCreacion") &&
                                !property.PropertyName.EndsWith("FechaModificacion") &&
                                !property.PropertyName.EndsWith("Estado") &&
                                !property.PropertyName.EndsWith("UsuarioCreacion") &&
                                !property.PropertyName.EndsWith("UsuarioModificacion"))
                                {
            if (property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 33 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 34 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                continue;
            }

            if (property.Scaffold)
            {
                if (property.IsReadOnly)
                {
                    continue;
                }

                if (property.IsForeignKey)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 47 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 48 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 48 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 49 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 51 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                    continue;
                }

                bool isCheckbox = property.TypeName.Equals("System.Boolean");
                if (isCheckbox)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group form-check col-sm-5\">\r\n                ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                    ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 59 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 59 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                                                                                          Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                ");
            WriteLiteral("</label>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 62 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else if (property.IsEnum && !property.IsEnumFlags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 66 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 67 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 68 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 70 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else if (property.IsMultilineText)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 74 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 75 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 76 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 78 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 82 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 83 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 84 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 86 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
            }
            // Ideally we shouldn't be here  but if the user marks the foreign key as [ScaffoldColumn(false)], we want to atleast try to make it work.
            else if (property.IsForeignKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 91 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 92 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                continue;
            }
            }
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral(@"</div>
            <div class=""form-group d-flex justify-content-end"" style=""gap:5px"">
                <input type=""submit"" value=""Guardar"" class=""btn btn-primary"" />
                <a asp-action=""Index"" class=""btn btn-secondary"">Cancelar</a>            
            </div>
        ");
            WriteLiteral("</form>\r\n");
#nullable restore
#line 103 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"

            if (Model.ReferenceScriptLibraries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("@section Scripts {\r\n                ");
            WriteLiteral("@{await Html.RenderPartialAsync(\"_ValidationScriptsPartial\");}\r\n                ");
            WriteLiteral("}\r\n");
#nullable restore
#line 109 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
            }
    }
    else
    {
        if (Model.IsPartialView)
        {
        }
        else if (Model.IsLayoutPageSelected)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("@{\r\n            ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 119 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 120 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
            if (!string.IsNullOrEmpty(Model.LayoutPageFile))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 122 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                       Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 123 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("\r\n            ");
            WriteLiteral("<h1>");
#nullable restore
#line 126 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
             Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            ");
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("@{\r\n            ");
            WriteLiteral("Layout = null;\r\n            ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("\r\n            ");
            WriteLiteral("<!DOCTYPE html>\r\n            ");
            WriteLiteral("\r\n            ");
            WriteLiteral("<html>\r\n            ");
            WriteLiteral("<head>\r\n                ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n                ");
            WriteLiteral("<title>");
#nullable restore
#line 140 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                    Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n            ");
            WriteLiteral("</head>\r\n            ");
            WriteLiteral("<body>\r\n                ");
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                //    PushIndent("    ");
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<h4>");
#nullable restore
#line 146 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
             Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            ");
            WriteLiteral("<hr />\r\n                    ");
            WriteLiteral("<form asp-action=\"");
#nullable restore
#line 148 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                   Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            ");
            WriteLiteral("<div class=\"d-flex justify-content-center flex-wrap\">\r\n            ");
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 151 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
        foreach (PropertyMetadata property in Model.ModelMetadata.Properties)
        {
            if (property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 155 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 156 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                continue;
            }

            if (property.Scaffold)
            {
                if (property.IsReadOnly)
                {
                    continue;
                }

                if (property.IsForeignKey)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 169 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 170 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 170 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 171 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 173 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                    continue;
                }

                bool isCheckbox = property.TypeName.Equals("System.Boolean");
                if (isCheckbox)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group form-check col-sm-5\">\r\n                ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                    ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 181 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 181 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                                                                                                          Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                ");
            WriteLiteral("</label>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 184 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else if (property.IsEnum && !property.IsEnumFlags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 188 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 189 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 190 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 192 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else if (property.IsMultilineText)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 196 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 197 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 198 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 200 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 204 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 205 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                             Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 206 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 208 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                }
            }
            // Ideally we shouldn't be here  but if the user marks the foreign key as [ScaffoldColumn(false)], we want to atleast try to make it work.
            else if (property.IsForeignKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 213 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 214 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
                continue;
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n                <a asp-action=\"Index\" class=\"btn btn-secondary\">Cancelar</a>            \r\n            </div>\r\n        ");
            WriteLiteral("</form>\r\n            <div>\r\n                <a asp-action=\"Index\">Back to List</a>\r\n            </div>\r\n");
#nullable restore
#line 227 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"


            if (Model.ReferenceScriptLibraries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("@section Scripts {\r\n                ");
            WriteLiteral("@{await Html.RenderPartialAsync(\"_ValidationScriptsPartial\");}\r\n                ");
            WriteLiteral("}\r\n");
#nullable restore
#line 234 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
            }
            // The following code closes the tag used in the case of a view using a layout page and the body and html tags in the case of a regular view page
            if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</body>\r\n        ");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 240 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 247 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Edit.cshtml"
 
    // Do we need to use this in conjunction with the PrimaryKey check?
    bool IsPropertyGuid(IPropertyMetadata property)
    {
        return string.Equals("System.Guid", property.TypeName, StringComparison.OrdinalIgnoreCase);
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
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
