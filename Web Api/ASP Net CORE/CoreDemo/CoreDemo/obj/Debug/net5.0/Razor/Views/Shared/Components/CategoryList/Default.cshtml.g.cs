#pragma checksum "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a82cc527baef6dd3ef708ca23bb95170e3f23e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a82cc527baef6dd3ef708ca23bb95170e3f23e0", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Kategori>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\t<h4>Kategoriler</h4>\r\n\t<ul class=\"list-group single\">\r\n");
#nullable restore
#line 6 "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t\t");
#nullable restore
#line 9 "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
           Write(item.KategoriName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"badge badge-primary badge-pill\">0</span>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 12 "C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web Api\ASP Net CORE\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
		}		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Kategori>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
