#pragma checksum "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7902f1a1f7251bfdae569ae7e9fcfc58d819f833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ProductDetails), @"mvc.1.0.view", @"/Views/User/ProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7902f1a1f7251bfdae569ae7e9fcfc58d819f833", @"/Views/User/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572863d442fe0f23e1b01a8877f3beed026199f4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainProject.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User_home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .line1 {\r\n        clear: both;\r\n        height: 2px;\r\n        margin-bottom: 3%;\r\n        width: 100%;\r\n        background-color: #E3E9E9;\r\n    }\r\n</style>\r\n\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card mt-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7902f1a1f7251bfdae569ae7e9fcfc58d819f8335277", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\" style=\"padding-left:30px;\">\r\n                <h1 class=\"text-info mt-2\">");
#nullable restore
#line 21 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                                      Write(Model.Products.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <div class=\"text-warning\">\r\n                    <h5>by ");
#nullable restore
#line 23 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                      Write(Model.Products.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 mt-4 text-right\" style=\"padding-right:30px;\">\r\n                <label class=\"btn bg-success text-white\">");
#nullable restore
#line 27 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                                                    Write(Model.Products.Cover_Types.Ctname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <label class=\"btn bg-warning text-white\">");
#nullable restore
#line 28 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                                                    Write(Model.Products.Categories.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"line1 mt-4\"></div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-7\" style=\"padding-left:40px\">\r\n                <div class=\"text-secondary\">\r\n                    ISBN : <label>");
#nullable restore
#line 35 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                             Write(Model.Products.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"text-secondary\">\r\n                    List Price : $<label>");
#nullable restore
#line 38 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                                    Write(Model.Products.ListPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                </div>
                <div>
                    <table class=""table bg-secondary"">
                        <tr>
                            <th>Quantity</th>
                            <th>1-49</th>
                            <th>50-99</th>
                            <th>100+</th>
                        </tr>
                        <tr class=""text-danger"">
                            <td>Price</td>
                            <td>");
#nullable restore
#line 50 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                           Write(Model.Products.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                           Write(Model.Products.Price50);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
                           Write(Model.Products.Price100);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 57 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
               Write(Model.Products.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""form-group row mt-4"">
                    <div class=""col-md-4"">
                        <h4 class=""text-info text-right"">Count:</h4>
                    </div>
                    <div class=""col-md-8"">
                        <input type=""number"" name=""count"" class=""form-control"" />
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7902f1a1f7251bfdae569ae7e9fcfc58d819f83310212", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 65 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-5\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 2608, "\"", 2642, 2);
                WriteAttributeValue("", 2614, "/media/", 2614, 7, true);
#nullable restore
#line 70 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
WriteAttributeValue("", 2621, Model.Products.Image, 2621, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"400px\" />\r\n            </div>\r\n        </div>\r\n        <div class=\"line1 mt-4\"></div>\r\n        <div class=\"row mb-4\">\r\n            <div class=\"col-md-6\" style=\"padding-left:30px\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7902f1a1f7251bfdae569ae7e9fcfc58d819f83312691", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""col-md-6"" style=""padding-right:30px"">
                <input type=""submit"" class=""btn btn-dark text-white form-control"" value=""Add to Cart""/>
            </div>
        </div>
        <div class=""row mb-4"">
            <div class=""col-md-6"" style=""padding-left:30px"">

            </div>
            <div class=""col-md-6"" style=""padding-right:30px"">
                ");
#nullable restore
#line 87 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
           Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7902f1a1f7251bfdae569ae7e9fcfc58d819f83314713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 89 "D:\websamples\Net_Core\MAINfilters\MAIN\MainProject\Views\User\ProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainProject.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
