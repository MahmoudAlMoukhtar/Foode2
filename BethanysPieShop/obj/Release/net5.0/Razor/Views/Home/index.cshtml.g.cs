#pragma checksum "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac098cfdac046dad15fb2b923064b614ae82e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
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
#line 2 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac098cfdac046dad15fb2b923064b614ae82e5e", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8de1cb8153c7cb0704e85ceac043e38668028b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BethanysPieShop.ViewModels.PieListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
/*    .product:hover {
        background-color: #C87D52;
        transition:1s

    }*/

</style>

<section id=""hero_section"" class=""d-flex justify-content-center align-items-center"" style=""background-color: #2eab93 "">
    
</section>

");
            WriteLiteral("    <div class=\"row row-cols-1 row-cols-md-3 g-4 py-4\">\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
         if (Model.Pies != null && Model.Pies.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
             foreach (var product in Model.Pies)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
           Write(await Html.PartialAsync("_ProductCard", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
                                                                 ;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No products found.</p>\r\n");
#nullable restore
#line 29 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Home\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BethanysPieShop.ViewModels.PieListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
