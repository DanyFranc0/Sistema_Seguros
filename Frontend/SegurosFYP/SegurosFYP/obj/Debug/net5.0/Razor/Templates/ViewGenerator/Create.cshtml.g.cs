#pragma checksum "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc21b4078b9a572537902ef56da401bd6df72265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Create), @"mvc.1.0.view", @"/Templates/ViewGenerator/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21b4078b9a572537902ef56da401bd6df72265", @"/Templates/ViewGenerator/Create.cshtml")]
    public class Templates_ViewGenerator_Create : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
   Write(Model.ViewDataTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
  
    if (Model.IsPartialView)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("@{\r\n        ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 12 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                          Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        ");
            WriteLiteral("ViewData[\"ModelName\"] = \"");
#nullable restore
#line 13 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                              Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".Replace(\"ViewModel\",\"\");\r\n");
#nullable restore
#line 14 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 16 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                   Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 17 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("}\r\n        ");
            WriteLiteral("\r\n                <form asp-action=\"Insert\">\r\n                    <div class=\"d-flex justify-content-center flex-wrap\">\r\n                    <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 23 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                      
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
                                    if (property.IsForeignKey)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 37 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 38 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 38 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                        continue;
                                    }

                                    bool isCheckbox = property.TypeName.Equals("System.Boolean");
                                    if (isCheckbox)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group form-check col-sm-5\">\r\n                                            ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                                                ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 48 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                      Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 48 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                                                                                      Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                            ");
            WriteLiteral("</label>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 51 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else if (property.IsEnum && !property.IsEnumFlags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 55 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 56 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 57 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 59 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else if (property.IsMultilineText)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 63 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 64 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                            Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 65 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group col-sm-5\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 71 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 72 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 73 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 75 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                }
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""form-group d-flex justify-content-end"" style=""gap: 5px;"">
                        <input type=""submit"" value=""Guardar"" class=""btn btn-primary"" />
                        <a asp-action=""Index"" class=""btn btn-secondary"">Cancelar</a>
                    </div>
                </form>
");
#nullable restore
#line 86 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
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
#line 91 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
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
#line 101 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                              Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 102 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
            if (!string.IsNullOrEmpty(Model.LayoutPageFile))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 104 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                       Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 105 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("\r\n            ");
            WriteLiteral("<h1>");
#nullable restore
#line 108 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
             Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            ");
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
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
#line 122 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                    Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n            ");
            WriteLiteral("</head>\r\n            ");
            WriteLiteral("<body>\r\n                ");
            WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                //    PushIndent("    ");
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<h4>");
#nullable restore
#line 128 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
             Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            ");
            WriteLiteral("<hr />\r\n                    ");
            WriteLiteral("<form asp-action=\"");
#nullable restore
#line 130 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                   Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                     ");
            WriteLiteral("<div class=\"d-flex justify-content-center flex-wrap\">\r\n                        ");
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 133 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
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
                                    if (property.IsForeignKey)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 146 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 147 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 147 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 149 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                        continue;
                                    }

                                    bool isCheckbox = property.TypeName.Equals("System.Boolean");
                                    if (isCheckbox)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group form-check\">\r\n                                            ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                                                ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 157 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                      Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 157 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                                                                                                      Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                            ");
            WriteLiteral("</label>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 160 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else if (property.IsEnum && !property.IsEnumFlags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 164 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 165 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 166 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 168 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else if (property.IsMultilineText)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 172 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 173 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                            Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 174 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 176 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral("<div class=\"form-group\">\r\n                                            ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 180 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                                            ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 181 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                         Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                                            ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 182 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                                                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n                                        ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 184 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
                                    }
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                        </div>\r\n                    ");
            WriteLiteral("</form>\r\n            <div>\r\n                <a asp-action=\"Index\">Back to List</a>\r\n            </div>\r\n");
#nullable restore
#line 196 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"


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
#line 203 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
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
#line 209 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 216 "C:\Users\pavel\OneDrive\Escritorio\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ViewGenerator\Create.cshtml"
 
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