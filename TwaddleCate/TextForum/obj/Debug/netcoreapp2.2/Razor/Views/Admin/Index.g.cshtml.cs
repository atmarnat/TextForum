#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0befb20d2099b246b8aff8de857ba02de3c86ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0befb20d2099b246b8aff8de857ba02de3c86ef4", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h1>Admin Index</h1>\r\n<hr />\r\n[");
            EndContext();
            BeginContext(31, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef45666", async() => {
                BeginContext(81, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(100, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef47247", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("List Roles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(167, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef48829", async() => {
                BeginContext(216, 10, true);
                WriteLiteral("List Users");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(230, 272, true);
            WriteLiteral(@"]
<hr />
<h3>Posts List</h3>
<hr />

<table style=""text-align: left; border-collapse: collapse;"">
    <tr>
        <th>Picture</th>
        <th>ID</th>
        <th>Topic</th>
        <th>User</th>
        <th>Content</th>
        <th>Action</th>
    </tr>

");
            EndContext();
#line 20 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
     foreach (var post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(549, 57, true);
            WriteLiteral("    <tr style=\"border: 1px solid black;\">\r\n        <td>\r\n");
            EndContext();
#line 24 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
             if (post.ImgUrl != null)
                    {
            

#line default
#line hidden
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
             if (@post.ImgUrl.Contains("webm"))
                        {

#line default
#line hidden
            BeginContext(744, 71, true);
            WriteLiteral("            <video class=\"thumbnail\" controls>\r\n                <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 815, "\"", 884, 2);
            WriteAttributeValue("", 821, "https://imgrepository.blob.core.windows.net/images/", 821, 51, true);
#line 29 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 872, post.ImgUrl, 872, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(885, 45, true);
            WriteLiteral(" type=\"video/webm\" />\r\n            </video>\r\n");
            EndContext();
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1014, 34, true);
            WriteLiteral("            <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1048, "\"", 1117, 2);
            WriteAttributeValue("", 1054, "https://imgrepository.blob.core.windows.net/images/", 1054, 51, true);
#line 34 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1105, post.ImgUrl, 1105, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1118, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 35 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
#line 35 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1171, 27, true);
            WriteLiteral("        </td>\r\n        <td>");
            EndContext();
            BeginContext(1199, 11, false);
#line 38 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(1210, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1230, 12, false);
#line 39 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.TopicID);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1262, 13, false);
#line 40 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1295, 12, false);
#line 41 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1340, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef415027", async() => {
                BeginContext(1381, 52, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1433, "\"", 1453, 1);
#line 44 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1441, post.PostID, 1441, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1454, 84, true);
                WriteLiteral(" /><button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1545, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1580, 253, true);
            WriteLiteral("</table>\r\n<hr />\r\n<h3>Reply List</h3>\r\n<hr />\r\n<table style=\"text-align: left; border-collapse: collapse;\">\r\n    <tr>\r\n        <th>Picture</th>\r\n        <th>ID</th>\r\n        <th>User</th>\r\n        <th>Content</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 62 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
     foreach (var post in Model.Replies)
    {

#line default
#line hidden
            BeginContext(1882, 57, true);
            WriteLiteral("    <tr style=\"border: 1px solid black;\">\r\n        <td>\r\n");
            EndContext();
#line 66 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
             if (post.ImgUrl != null)
                    {
            

#line default
#line hidden
#line 68 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
             if (@post.ImgUrl.Contains("webm"))
                        {

#line default
#line hidden
            BeginContext(2077, 71, true);
            WriteLiteral("            <video class=\"thumbnail\" controls>\r\n                <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2148, "\"", 2217, 2);
            WriteAttributeValue("", 2154, "https://imgrepository.blob.core.windows.net/images/", 2154, 51, true);
#line 71 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2205, post.ImgUrl, 2205, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2218, 45, true);
            WriteLiteral(" type=\"video/webm\" />\r\n            </video>\r\n");
            EndContext();
#line 73 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2347, 34, true);
            WriteLiteral("            <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2381, "\"", 2450, 2);
            WriteAttributeValue("", 2387, "https://imgrepository.blob.core.windows.net/images/", 2387, 51, true);
#line 76 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2438, post.ImgUrl, 2438, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2451, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 77 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
#line 77 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(2504, 27, true);
            WriteLiteral("        </td>\r\n        <td>");
            EndContext();
            BeginContext(2532, 11, false);
#line 80 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(2543, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2563, 13, false);
#line 81 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2576, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2596, 12, false);
#line 82 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
       Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2608, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2641, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef422007", async() => {
                BeginContext(2682, 52, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2734, "\"", 2755, 1);
#line 85 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2742, post.ReplyID, 2742, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2756, 84, true);
                WriteLiteral(" /><button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2847, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 89 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2882, 19, true);
            WriteLiteral("</table>\r\n<hr />\r\n[");
            EndContext();
            BeginContext(2901, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef424734", async() => {
                BeginContext(2951, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2966, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(2970, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef426321", async() => {
                BeginContext(3019, 10, true);
                WriteLiteral("List Roles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3033, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(3037, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0befb20d2099b246b8aff8de857ba02de3c86ef427907", async() => {
                BeginContext(3086, 10, true);
                WriteLiteral("List Users");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3100, 9, true);
            WriteLiteral("]\r\n<hr />");
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
