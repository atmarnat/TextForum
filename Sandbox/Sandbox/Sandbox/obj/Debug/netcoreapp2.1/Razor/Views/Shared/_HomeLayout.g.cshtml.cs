#pragma checksum "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc38c4be0f763aa87c90f26c1a660e6fecd6289"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc38c4be0f763aa87c90f26c1a660e6fecd6289", @"/Views/Shared/_HomeLayout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc3fe45723b44626805530a4f11b7a17", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 138, "\"", 177, 1);
#line 7 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
WriteAttributeValue("", 145, Url.Content("~/css/styles.css"), 145, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(178, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 225, "\"", 268, 1);
#line 8 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
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
            BeginContext(318, 666, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fddfebe27c54de09c06cc3759feff2c", async() => {
                BeginContext(324, 34, true);
                WriteLiteral("\r\n    <div class=\"head\">\r\n        ");
                EndContext();
                BeginContext(359, 31, false);
#line 13 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
   Write(RenderSection("pageName", true));

#line default
#line hidden
                EndContext();
                BeginContext(390, 105, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"block\">\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(496, 27, false);
#line 18 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("left", true));

#line default
#line hidden
                EndContext();
                BeginContext(523, 98, true);
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"block\">\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(622, 26, false);
#line 23 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("mid", true));

#line default
#line hidden
                EndContext();
                BeginContext(648, 98, true);
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"block\">\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(747, 28, false);
#line 28 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
           Write(RenderSection("right", true));

#line default
#line hidden
                EndContext();
                BeginContext(775, 139, true);
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n    <div style=\"text-align:center;\">\r\n        <footer class=\"panel-footer\">\r\n            ");
                EndContext();
                BeginContext(915, 29, false);
#line 35 "C:\Users\Natha\Source\Repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_HomeLayout.cshtml"
       Write(RenderSection("footer", true));

#line default
#line hidden
                EndContext();
                BeginContext(944, 33, true);
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
            BeginContext(984, 11, true);
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
