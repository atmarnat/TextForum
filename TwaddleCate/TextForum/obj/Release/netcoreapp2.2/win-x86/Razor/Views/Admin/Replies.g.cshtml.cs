#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a80fb580b4486df06db61298c11ec01d255acd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Replies), @"mvc.1.0.view", @"/Views/Admin/Replies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Replies.cshtml", typeof(AspNetCore.Views_Admin_Replies))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a80fb580b4486df06db61298c11ec01d255acd1", @"/Views/Admin/Replies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Replies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Replies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a80fb580b4486df06db61298c11ec01d255acd15047", async() => {
            }
            );
            __TextForum_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::TextForum.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__TextForum_Infrastructure_PageLinkTagHelper);
#line 1 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
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
            BeginContext(62, 208, true);
            WriteLiteral("\r\n<table style=\"text-align: left; border-collapse: collapse;\">\r\n    <tr>\r\n        <th>Picture</th>\r\n        <th>ID</th>\r\n        <th>User</th>\r\n        <th>Content</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
     foreach (var post in Model.Replies)
    {

#line default
#line hidden
            BeginContext(319, 65, true);
            WriteLiteral("        <tr style=\"border: 1px solid black;\">\r\n            <td>\r\n");
            EndContext();
#line 15 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
                 if (post.ImgUrl != null)
                {
                    

#line default
#line hidden
#line 17 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
                     if (@post.ImgUrl.Contains("webm"))
                    {

#line default
#line hidden
            BeginContext(526, 95, true);
            WriteLiteral("                        <video class=\"thumbnail\" controls>\r\n                            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 621, "\"", 690, 2);
            WriteAttributeValue("", 627, "https://imgrepository.blob.core.windows.net/images/", 627, 51, true);
#line 20 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
WriteAttributeValue("", 678, post.ImgUrl, 678, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 57, true);
            WriteLiteral(" type=\"video/webm\" />\r\n                        </video>\r\n");
            EndContext();
#line 22 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(820, 46, true);
            WriteLiteral("                        <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 866, "\"", 935, 2);
            WriteAttributeValue("", 872, "https://imgrepository.blob.core.windows.net/images/", 872, 51, true);
#line 25 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
WriteAttributeValue("", 923, post.ImgUrl, 923, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(936, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
                    }

#line default
#line hidden
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(981, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(1017, 11, false);
#line 29 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
           Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1052, 13, false);
#line 30 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
           Write(post.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1089, 12, false);
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
           Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1142, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a80fb580b4486df06db61298c11ec01d255acd111008", async() => {
                BeginContext(1216, 2, true);
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
#line 33 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
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
            BeginContext(1222, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1277, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a80fb580b4486df06db61298c11ec01d255acd113644", async() => {
                BeginContext(1318, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1374, "\"", 1395, 1);
#line 37 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
WriteAttributeValue("", 1382, post.ReplyID, 1382, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1396, 88, true);
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
            BeginContext(1491, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Replies.cshtml"
    }

#line default
#line hidden
            BeginContext(1534, 8, true);
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
