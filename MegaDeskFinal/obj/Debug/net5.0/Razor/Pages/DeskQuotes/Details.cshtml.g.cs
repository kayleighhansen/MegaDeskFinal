#pragma checksum "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2b4dde506ba706c6cb1e830504f68770e8562d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskFinal.Pages.DeskQuotes.Pages_DeskQuotes_Details), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Details.cshtml")]
namespace MegaDeskFinal.Pages.DeskQuotes
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
#line 1 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/_ViewImports.cshtml"
using MegaDeskFinal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2b4dde506ba706c6cb1e830504f68770e8562d", @"/Pages/DeskQuotes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62450f366f2842ba367a48d964418d1ff55b363d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DeskQuote</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.ShippingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.ShippingType.ShippingTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Desk.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Desk.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Desk.Depth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Desk.Depth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Desk.NumberOfDrawers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Desk.NumberOfDrawers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.QuotePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.QuotePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2b4dde506ba706c6cb1e830504f68770e8562d8648", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "/Users/kayleighhansen/Software/MegaDeskFinal/MegaDeskFinal/Pages/DeskQuotes/Details.cshtml"
                           WriteLiteral(Model.DeskQuote.DeskQuoteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2b4dde506ba706c6cb1e830504f68770e8562d10787", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskFinal.Pages.DeskQuotes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskFinal.Pages.DeskQuotes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskFinal.Pages.DeskQuotes.DetailsModel>)PageContext?.ViewData;
        public MegaDeskFinal.Pages.DeskQuotes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
