#pragma checksum "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6a797345c5a6028ba64ded8d32acdf1f6fc1cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\_ViewImports.cshtml"
using ECommerce.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\_ViewImports.cshtml"
using ECommerce.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6a797345c5a6028ba64ded8d32acdf1f6fc1cc", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d153a22c3d84e9b5a7a98a669200007cf871ba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-9"">
            <div class=""row"">
                <div class=""col-md-4""><strong>Id</strong></div>
                <div class=""col-md-4""><strong>Name</strong></div>

            </div>
");
#nullable restore
#line 11 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-4\">");
#nullable restore
#line 14 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-4\">");
#nullable restore
#line 15 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    <div class=\"col-md-4 row\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
                   Write(Html.ActionLink("Düzenle", "Update", "Category", new { Id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
                   Write(Html.ActionLink("Sil", "Delete", "Category", new { Id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
                   Write(Html.ActionLink("Detay", "Detail", "Category", new { Id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
