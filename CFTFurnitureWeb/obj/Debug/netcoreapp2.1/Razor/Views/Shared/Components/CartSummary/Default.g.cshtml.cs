#pragma checksum "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32fef52591fc6d7e4cef5ca29e30b37ebb0974c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
#line 1 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\_ViewImports.cshtml"
using CFTFurnitureWeb.Models;

#line default
#line hidden
#line 2 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\_ViewImports.cshtml"
using CFTFurnitureWeb.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\_ViewImports.cshtml"
using CFTFurnitureWeb.Infrastructure;

#line default
#line hidden
#line 4 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32fef52591fc6d7e4cef5ca29e30b37ebb0974c", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded0ba90330e50eb47f86ac67995ccae1e8134a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-brand btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(22, 16, true);
            WriteLiteral("<div class=\"\">\r\n");
            EndContext();
#line 6 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml"
     if (Model.Lines.Count() > 0)
        {

#line default
#line hidden
            BeginContext(84, 80, true);
            WriteLiteral("        <small class=\"navbar-text\">\r\n            <b>Your cart:</b>\r\n            ");
            EndContext();
            BeginContext(165, 32, false);
#line 10 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml"
       Write(Model.Lines.Sum(x => x.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(197, 22, true);
            WriteLiteral(" item(s)\r\n            ");
            EndContext();
            BeginContext(220, 39, false);
#line 11 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml"
       Write(Model.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(259, 20, true);
            WriteLiteral("\r\n        </small>\r\n");
            EndContext();
#line 13 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(290, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(294, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4003f96d07c4406facf6ca48daec2e72", async() => {
                BeginContext(473, 51, true);
                WriteLiteral("\r\n        <i class=\"fa fa-shopping-cart\"></i>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Shared\Components\CartSummary\Default.cshtml"
                WriteLiteral(ViewContext.HttpContext.Request.PathAndQuery());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(528, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
