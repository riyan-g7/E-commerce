#pragma checksum "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c066b1c46156ceaecb8022d43213959dd88ea5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin_home), @"mvc.1.0.view", @"/Views/Admin/Admin_home.cshtml")]
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
#line 1 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\_ViewImports.cshtml"
using MainProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\_ViewImports.cshtml"
using MainProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c066b1c46156ceaecb8022d43213959dd88ea5d1", @"/Views/Admin/Admin_home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572863d442fe0f23e1b01a8877f3beed026199f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin_home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MainProject.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 6 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-info col-md-3 mt-4 mr-2\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 215, "\"", 239, 2);
            WriteAttributeValue("", 221, "/media/", 221, 7, true);
#nullable restore
#line 10 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
WriteAttributeValue("", 228, item.Image, 228, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250px\" class=\"mt-3\" />\r\n            </div>\r\n            <div>\r\n                <h3><b>");
#nullable restore
#line 13 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n            </div>\r\n            <div class=\" text-info\">\r\n                by <label class=\"font-weight-bold\">");
#nullable restore
#line 16 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
                                              Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div>\r\n                List Price : <label><strike>");
#nullable restore
#line 19 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
                                       Write(item.ListPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strike></label>\r\n            </div>\r\n            <div class=\"text-danger\">\r\n                As low as : <label class=\"font-weight-bold\">");
#nullable restore
#line 22 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c066b1c46156ceaecb8022d43213959dd88ea5d16206", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\Admin\Admin_home.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MainProject.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
