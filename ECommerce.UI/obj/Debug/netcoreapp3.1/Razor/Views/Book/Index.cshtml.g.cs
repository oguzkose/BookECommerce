#pragma checksum "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f41b936b3309fc2fb386d347b7306eab14ed2f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f41b936b3309fc2fb386d347b7306eab14ed2f2", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d153a22c3d84e9b5a7a98a669200007cf871ba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Anasayfa</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-9\">\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-1""><strong>Id</strong></div>
                <div class=""col-md-2""><strong>Name</strong></div>
                <div class=""col-md-2""><strong>Author</strong></div>
                <div class=""col-md-2""><strong>Publisher</strong></div>
                <div class=""col-md-2""><strong>Price</strong></div>
                <div class=""col-md-2""><strong>StockCount</strong></div>
                <div class=""col-md-1""><strong>CategoryId</strong></div>

            </div>
");
#nullable restore
#line 22 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
             foreach (var item in Model.Books)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 25 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 26 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 27 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 28 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 29 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 30 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.StockCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 31 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                                     Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    <div class=\"col-md-4 row\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                   Write(Html.ActionLink("Düzenle", "Update", "Product", new { bookId = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 36 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
                   Write(Html.ActionLink("Sil", "Delete", "Product", new { bookId = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\Oğuz KÖSE\source\repos\oguzkose\BookECommerce\ECommerce.UI\Views\Book\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
