#pragma checksum "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d18ee362f15e7a0e7880fea6c3f6e96145924e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductsList), @"mvc.1.0.view", @"/Views/Product/ProductsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductsList.cshtml", typeof(AspNetCore.Views_Product_ProductsList))]
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
#line 1 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#line 2 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d18ee362f15e7a0e7880fea6c3f6e96145924e0", @"/Views/Product/ProductsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2527529f2c059606b53063abaf60c152c12d4419", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 29, true);
            WriteLiteral(" \r\n <ul class=\"collection\">\r\n");
            EndContext();
#line 4 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
            BeginContext(104, 47, true);
            WriteLiteral("    <li class=\"collection-item avatar\">\r\n      ");
            EndContext();
            BeginContext(151, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0e619fb88fc495bb83db59c323a2f2f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 28, true);
            WriteLiteral("\r\n      <span class=\"title\">");
            EndContext();
            BeginContext(234, 12, false);
#line 8 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml"
                     Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 18, true);
            WriteLiteral("</span>\r\n      <p>");
            EndContext();
            BeginContext(265, 19, false);
#line 9 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml"
    Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(284, 15, true);
            WriteLiteral("<br>\r\n         ");
            EndContext();
            BeginContext(300, 27, false);
#line 10 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml"
    Write(product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(327, 25, true);
            WriteLiteral("\r\n      </p>\r\n    </li>\r\n");
            EndContext();
#line 13 "E:\KURSY-PROGRAMOWANIA\Projekty\WebShop\Views\Product\ProductsList.cshtml"
}

#line default
#line hidden
            BeginContext(355, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
