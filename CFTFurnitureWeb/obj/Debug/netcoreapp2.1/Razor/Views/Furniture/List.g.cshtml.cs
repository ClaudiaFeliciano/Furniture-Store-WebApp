#pragma checksum "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1eabda992858b5d12721b2f2dc17fd360fae6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Furniture_List), @"mvc.1.0.view", @"/Views/Furniture/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Furniture/List.cshtml", typeof(AspNetCore.Views_Furniture_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1eabda992858b5d12721b2f2dc17fd360fae6e", @"/Views/Furniture/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded0ba90330e50eb47f86ac67995ccae1e8134a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Furniture_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FurnituresListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::CFTFurnitureWeb.Infrastructure.PageLinkTagHelper __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
 foreach (var p in Model.Furnitures)
    {
    

#line default
#line hidden
            BeginContext(212, 35, false);
#line 9 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
Write(Html.Partial("FurnitureSummary", p));

#line default
#line hidden
            EndContext();
#line 9 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
                                        

    }

#line default
#line hidden
            BeginContext(258, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3819b49e24fc49f1aa3fa48ebcf3ca68", async() => {
                BeginContext(520, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::CFTFurnitureWeb.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__CFTFurnitureWeb_Infrastructure_PageLinkTagHelper);
#line 12 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
__CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
__CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "CFTFurnitureWeb.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
            }
#line 14 "C:\Users\Claudia\Documents\Web-Development-master\Web-Development-master\CFTFurnitureWeb\CFTFurnitureWeb\CFTFurnitureWeb\Views\Furniture\List.cshtml"
__CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __CFTFurnitureWeb_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(528, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FurnituresListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
