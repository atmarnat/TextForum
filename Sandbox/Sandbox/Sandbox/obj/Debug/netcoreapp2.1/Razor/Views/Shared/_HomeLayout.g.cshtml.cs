#pragma checksum "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d37397d9b041af07af8d43c166b7792f687728c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HomeLayout), @"mvc.1.0.view", @"/Views/Shared/_HomeLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HomeLayout.cshtml", typeof(AspNetCore.Views_Shared__HomeLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d37397d9b041af07af8d43c166b7792f687728c0", @"/Views/Shared/_HomeLayout.cshtml")]
    public class Views_Shared__HomeLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8584eac615fe4a6e97c1fd7a64cdc536", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 138, "\"", 177, 1);
#line 7 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
WriteAttributeValue("", 145, Url.Content("~/css/styles.css"), 145, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(178, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 225, "\"", 268, 1);
#line 8 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
WriteAttributeValue("", 232, Url.Content("~/css/stylesHome.css"), 232, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(269, 40, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n");
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
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(318, 859, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "858b9815cc1d464785ef5f84eb3bca41", async() => {
                BeginContext(324, 34, true);
                WriteLiteral("\r\n    <div class=\"head\">\r\n        ");
                EndContext();
                BeginContext(359, 31, false);
#line 13 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
   Write(RenderSection("pageName", true));

#line default
#line hidden
                EndContext();
                BeginContext(390, 169, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"block\">\r\n            <p align=\"center\">Knowledge</p>\r\n            <div class=\"modified\">\r\n                ");
                EndContext();
                BeginContext(560, 27, false);
#line 19 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("left", true));

#line default
#line hidden
                EndContext();
                BeginContext(587, 161, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"block\">\r\n            <p align=\"center\">Health</p>\r\n            <div class=\"modified\">\r\n                ");
                EndContext();
                BeginContext(749, 26, false);
#line 25 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("mid", true));

#line default
#line hidden
                EndContext();
                BeginContext(775, 162, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"block\">\r\n            <p align=\"center\">Culture</p>\r\n            <div class=\"modified\">\r\n                ");
                EndContext();
                BeginContext(938, 28, false);
#line 31 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("right", true));

#line default
#line hidden
                EndContext();
                BeginContext(966, 141, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div style=\"text-align:center;\">\r\n        <footer class=\"panel-footer\">\r\n            ");
                EndContext();
                BeginContext(1108, 29, false);
#line 38 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
       Write(RenderSection("footer", true));

#line default
#line hidden
                EndContext();
                BeginContext(1137, 33, true);
                WriteLiteral("\r\n        </footer>\r\n    </div>\r\n");
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
            BeginContext(1177, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
