#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Replies_List), @"mvc.1.0.view", @"/Views/Replies/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Replies/List.cshtml", typeof(AspNetCore.Views_Replies_List))]
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
#line 1 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models;

#line default
#line hidden
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd", @"/Views/Replies/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Replies_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd4066", async() => {
                BeginContext(6, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(20, 22, false);
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
      Write(Model.FirstPost.PostID);

#line default
#line hidden
                EndContext();
                BeginContext(42, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(44, 22, false);
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                              Write(Model.CurrentTopicName);

#line default
#line hidden
                EndContext();
                BeginContext(66, 22, true);
                WriteLiteral("-TwaddleCate</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 1365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd6060", async() => {
                BeginContext(103, 47, true);
                WriteLiteral("\r\n    <a name=\"top\"></a>\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(151, 23, false);
#line 8 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
   Write(Html.Partial("NavMenu"));

#line default
#line hidden
                EndContext();
                BeginContext(174, 66, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <div style=\"text-align: center\">\r\n        <h1>");
                EndContext();
                BeginContext(241, 22, false);
#line 12 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
       Write(Model.CurrentTopicName);

#line default
#line hidden
                EndContext();
                BeginContext(263, 108, true);
                WriteLiteral("</h1>\r\n    </div>\r\n\r\n    <a name=\"reply\"></a>\r\n    <div style=\"text-align: center\">\r\n        Reply\r\n        ");
                EndContext();
                BeginContext(372, 53, false);
#line 18 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
   Write(Html.Partial("Reply", new TextForum.Models.Replies()));

#line default
#line hidden
                EndContext();
                BeginContext(425, 111, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <hr />\r\n    <div>\r\n        <!--<input type=\"button\" value=\"Return\" onclick=\"location.href=\'");
                EndContext();
                BeginContext(537, 42, false);
#line 23 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                                                                   Write(Url.Action("List", "Topic", new {id="1" }));

#line default
#line hidden
                EndContext();
                BeginContext(579, 19, true);
                WriteLiteral("\'\" />-->\r\n        [");
                EndContext();
                BeginContext(598, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd8478", async() => {
                    BeginContext(682, 6, true);
                    WriteLiteral("Return");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 24 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                                                       WriteLiteral(Model.FirstPost.TopicID);

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
                BeginContext(692, 126, true);
                WriteLiteral("]\r\n        [<a href=\"#bottom\">Bottom</a>]\r\n        [<a href=\"\">Refresh</a>]\r\n    </div>\r\n    <hr />\r\n\r\n    <div>\r\n        <h4>");
                EndContext();
                BeginContext(819, 21, false);
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
       Write(Model.CurrentUserName);

#line default
#line hidden
                EndContext();
                BeginContext(840, 2, true);
                WriteLiteral(" [");
                EndContext();
                BeginContext(843, 23, false);
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                               Write(Model.FirstPost.Created);

#line default
#line hidden
                EndContext();
                BeginContext(866, 16, true);
                WriteLiteral("]</h4>\r\n        ");
                EndContext();
                BeginContext(883, 23, false);
#line 32 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
   Write(Model.FirstPost.Content);

#line default
#line hidden
                EndContext();
                BeginContext(906, 18, true);
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
                EndContext();
#line 36 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
     foreach (var r in Model.Replies)
    {

#line default
#line hidden
                BeginContext(970, 47, true);
                WriteLiteral("        <hr />\r\n        <div>\r\n            <h4>");
                EndContext();
                BeginContext(1018, 21, false);
#line 40 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
           Write(Model.CurrentUserName);

#line default
#line hidden
                EndContext();
                BeginContext(1039, 2, true);
                WriteLiteral(" [");
                EndContext();
                BeginContext(1042, 9, false);
#line 40 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                                   Write(r.Created);

#line default
#line hidden
                EndContext();
                BeginContext(1051, 20, true);
                WriteLiteral("]</h4>\r\n            ");
                EndContext();
                BeginContext(1072, 9, false);
#line 41 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
       Write(r.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1081, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 43 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
    }

#line default
#line hidden
                BeginContext(1106, 34, true);
                WriteLiteral("\r\n    <hr />\r\n    <div>\r\n        [");
                EndContext();
                BeginContext(1140, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db8a5c3e6ee31bbee3b580e213a49c0d0b093cd14429", async() => {
                    BeginContext(1224, 6, true);
                    WriteLiteral("Return");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
                                                       WriteLiteral(Model.FirstPost.TopicID);

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
                BeginContext(1234, 154, true);
                WriteLiteral("]\r\n        [<a href=\"#top\">Top</a>]\r\n        [<a href=\"\">Refresh</a>]\r\n        [<a href=\"#reply\">Reply</a>]\r\n    </div>\r\n    <hr />\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(1389, 23, false);
#line 55 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Replies\List.cshtml"
   Write(Html.Partial("NavMenu"));

#line default
#line hidden
                EndContext();
                BeginContext(1412, 43, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <a name=\"bottom\"></a>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
