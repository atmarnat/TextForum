#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e52235ec7d70fc5cc9f80b2b8df42c3855d6f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_List), @"mvc.1.0.view", @"/Views/Shared/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/List.cshtml", typeof(AspNetCore.Views_Shared_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e52235ec7d70fc5cc9f80b2b8df42c3855d6f0", @"/Views/Shared/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(12, 23, false);
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
Write(Html.Partial("NavMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(35, 54, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"text-align: center\">\r\n    <h1>");
            EndContext();
            BeginContext(90, 22, false);
#line 6 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
   Write(Model.CurrentTopicName);

#line default
#line hidden
            EndContext();
            BeginContext(112, 69, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n\r\n<div style=\"text-align: center\">\r\n    Create\r\n    ");
            EndContext();
            BeginContext(182, 51, false);
#line 12 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
Write(Html.Partial("Create", new TextForum.Models.Post()));

#line default
#line hidden
            EndContext();
            BeginContext(233, 20, true);
            WriteLiteral("\r\n</div>\r\n\r\n<hr />\r\n");
            EndContext();
            BeginContext(253, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e52235ec7d70fc5cc9f80b2b8df42c3855d6f04836", async() => {
            }
            );
            __TextForum_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::TextForum.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__TextForum_Infrastructure_PageLinkTagHelper);
#line 16 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
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
            BeginContext(314, 17, true);
            WriteLiteral("\r\n<hr />\r\n<div>\r\n");
            EndContext();
#line 19 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
     foreach (var p in Model.Posts)
    {

#line default
#line hidden
            BeginContext(375, 31, true);
            WriteLiteral("        <div>\r\n            <h4>");
            EndContext();
            BeginContext(407, 21, false);
#line 22 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
           Write(Model.CurrentUserName);

#line default
#line hidden
            EndContext();
            BeginContext(428, 2, true);
            WriteLiteral(" [");
            EndContext();
            BeginContext(431, 9, false);
#line 22 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
                                   Write(p.Created);

#line default
#line hidden
            EndContext();
            BeginContext(440, 14, true);
            WriteLiteral("] <a href=\"#\">");
            EndContext();
            BeginContext(455, 8, false);
#line 22 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
                                                           Write(p.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(463, 23, true);
            WriteLiteral("</a></h4>\r\n            ");
            EndContext();
            BeginContext(487, 9, false);
#line 23 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
       Write(p.Content);

#line default
#line hidden
            EndContext();
            BeginContext(496, 34, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n");
            EndContext();
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
    }

#line default
#line hidden
            BeginContext(537, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(545, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e52235ec7d70fc5cc9f80b2b8df42c3855d6f08687", async() => {
            }
            );
            __TextForum_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::TextForum.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__TextForum_Infrastructure_PageLinkTagHelper);
#line 28 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
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
            BeginContext(606, 23, true);
            WriteLiteral("\r\n<hr />\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(630, 23, false);
#line 32 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\Sandbox\Sandbox\TextForum\TextForum\Views\Shared\List.cshtml"
Write(Html.Partial("NavMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(653, 8, true);
            WriteLiteral("\r\n</div>");
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
