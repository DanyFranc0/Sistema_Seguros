#pragma checksum "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd3e8043246c6f9dcb99a8f98188919e3e95bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_CreatePageModel), @"mvc.1.0.view", @"/Templates/RazorPageGenerator/CreatePageModel.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd3e8043246c6f9dcb99a8f98188919e3e95bab", @"/Templates/RazorPageGenerator/CreatePageModel.cshtml")]
    public class Templates_RazorPageGenerator_CreatePageModel : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing Microsoft.AspNetCore.Mvc.RazorPages;\r\nusing Microsoft.AspNetCore.Mvc.Rendering;\r\n");
#nullable restore
#line 11 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
  
    var entitySetName = Model.ModelMetadata.EntitySetName;
    var entitySetVar = Model.EntitySetVariable ??
        (String.IsNullOrEmpty(entitySetName)
            ? entitySetName
            : (entitySetName.Substring(0, length: 1).ToLowerInvariant() + entitySetName.Substring(1)));

    var relatedProperties = new Dictionary<string, dynamic>();
    foreach (var nav in Model.ModelMetadata.Navigations)
    {
        relatedProperties.Add(nav.AssociationPropertyName, nav);
    }

    foreach (var namespaceName in Model.RequiredNamespaces)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 26 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
   Write(namespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 27 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 30 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class ");
#nullable restore
#line 32 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
            Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : PageModel\r\n    {\r\n        private readonly ");
#nullable restore
#line 34 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                    Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" _context;\r\n\r\n        public ");
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
           Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                      Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" context)\r\n        {\r\n            _context = context;\r\n        }\r\n\r\n        public IActionResult OnGet()\r\n        {\r\n");
#nullable restore
#line 43 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
  
    foreach (var property in relatedProperties.Values)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("ViewData[\"");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                Write(property.ForeignKeyPropertyNames[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"] = new SelectList(_context.");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                                                                  Write(property.EntitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", \"");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                                                                                            Write(property.PrimaryKeyNames[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                                                                                                                            Write(property.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 47 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            return Page();\r\n        }\r\n\r\n        [BindProperty]\r\n        public ");
#nullable restore
#line 53 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
          Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                       Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.");
#nullable restore
#line 63 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                 Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Add(");
#nullable restore
#line 63 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\CreatePageModel.cshtml"
                                     Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            await _context.SaveChangesAsync();\r\n\r\n            return RedirectToPage(\"./Index\");\r\n        }\r\n    }\r\n}\r\n");
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
