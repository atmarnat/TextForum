#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61732d03bbed19dfd2f7b61ac2d4d94f9ddeb6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Posts), @"mvc.1.0.view", @"/Views/Shared/Posts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Posts.cshtml", typeof(AspNetCore.Views_Shared_Posts))]
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
#line 1 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models;

#line default
#line hidden
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61732d03bbed19dfd2f7b61ac2d4d94f9ddeb6a", @"/Views/Shared/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Replies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::TextForum.Infrastructure.PageLinkTagHelper __TextForum_Infrastructure_PageLinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61732d03bbed19dfd2f7b61ac2d4d94f9ddeb6a5040", async() => {
            }
            );
            __TextForum_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::TextForum.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__TextForum_Infrastructure_PageLinkTagHelper);
#line 1 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
__TextForum_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __TextForum_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __TextForum_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(62, 209, true);
            WriteLiteral("\r\n<table style=\"text-align: left; border-collapse: collapse;\">\r\n    <tr>\r\n        <th>Picture</th>\r\n        <th>ID</th>\r\n        <th>Topic</th>\r\n        <th>Content</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
     foreach (var post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(318, 65, true);
            WriteLiteral("        <tr style=\"border: 1px solid black;\">\r\n            <td>\r\n");
            EndContext();
#line 15 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                 if (post.ImgUrl != null)
                {
                    

#line default
#line hidden
#line 17 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                     if (@post.ImgUrl.Contains("webm"))
                    {

#line default
#line hidden
            BeginContext(525, 95, true);
            WriteLiteral("                        <video class=\"thumbnail\" controls>\r\n                            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 620, "\"", 689, 2);
            WriteAttributeValue("", 626, "https://imgrepository.blob.core.windows.net/images/", 626, 51, true);
#line 20 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
WriteAttributeValue("", 677, post.ImgUrl, 677, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(690, 57, true);
            WriteLiteral(" type=\"video/webm\" />\r\n                        </video>\r\n");
            EndContext();
#line 22 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(819, 46, true);
            WriteLiteral("                        <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 865, "\"", 934, 2);
            WriteAttributeValue("", 871, "https://imgrepository.blob.core.windows.net/images/", 871, 51, true);
#line 25 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
WriteAttributeValue("", 922, post.ImgUrl, 922, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(935, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                    }

#line default
#line hidden
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(980, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(1016, 11, false);
#line 29 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
           Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1051, 12, false);
#line 30 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
           Write(post.TopicID);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1087, 12, false);
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
           Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1140, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61732d03bbed19dfd2f7b61ac2d4d94f9ddeb6a10987", async() => {
                BeginContext(1214, 2, true);
                WriteLiteral("Go");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
                                                                WriteLiteral(post.PostID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1220, 56, true);
            WriteLiteral(" \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1276, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61732d03bbed19dfd2f7b61ac2d4d94f9ddeb6a13623", async() => {
                BeginContext(1317, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1373, "\"", 1393, 1);
#line 37 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
WriteAttributeValue("", 1381, post.PostID, 1381, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1394, 88, true);
                WriteLiteral(" /><button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1489, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Shared\Posts.cshtml"
    }

#line default
#line hidden
            BeginContext(1532, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
